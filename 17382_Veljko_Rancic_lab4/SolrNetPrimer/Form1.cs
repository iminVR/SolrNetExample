﻿using CommonServiceLocator;
using SolrNet;
using SolrNet.Commands.Parameters;
using System;
using System.IO;
using System.Windows.Forms;

namespace SolrNetPrimer
{
    // Potrebno je najpre pokrenuti Solr (solr.cmd start), 
    // zatim u web browser-u otvoriti adresu http://localhost:8983/solr/#/ i tamo 
    // kreirati novo jezgro (core) sa nazivom "primer" (Core Admin -> Add Core). 
    // Pre kreiranja jezgra treba ručno kreirati odgovarajuću strukturu foldera 
    // na lokaciji solr-8.11.1\server\solr\
    // Najpre kreirati folder solr-8.11.1\server\solr\primer, pa zatim kreirati 
    // solr-8.11.1\server\solr\primer\data
    // Zatim ručno iskopirati default konfiguracione fajlove sa 
    // solr-8.11.1\server\solr\configsets\_default\conf\ u folder 
    // solr-8.11.1\server\solr\primer\conf\
    // Parametri za kreiranje novog jezgra kroz Core Admin stranicu na 
    // http://localhost:8983/solr/#/
    // name: primer
    // instanceDir: primer
    // dataDir: data
    // config: solrconfig.xml
    // scheme: schema.xml

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbPolje.SelectedIndex = 0;
            // Inicijalizacija objekta za konekciju sa Solr serverom. Potrebno je 
            // izvršiti samo jednom u toku životnog ciklusa aplikacije da 
            // bi kasnije bilo moguće otvaranje konekcija ka Solr serveru po potrebi. 
            Startup.Init<Knjiga>("http://localhost:8983/solr/primer");
        }

        private void btnIndeksiranje_Click(object sender, System.EventArgs e)
        {
            // Otvaranje konekcije ka Solr serveru
            ISolrOperations<Knjiga> solr = ServiceLocator.Current.GetInstance<ISolrOperations<Knjiga>>();

            // Kreiranje DirectoryInfo objekta na osnovu relativne putanje do 
            // direktorijuma sa knjigama za indeksiranje
            DirectoryInfo mydir = new DirectoryInfo(@"..\..\Knjige");
            // Obilazak svih fajlova iz kolekcije fajlova
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                // Kreiranje dokumenta za dodavanje u indeks (dokument je predstavljen
                // instancom klase Knjiga). 
                Knjiga knjiga = new Knjiga();
                knjiga.Id = Guid.NewGuid().ToString();
                knjiga.LastModified = file.LastWriteTime;
                knjiga.Link = file.Name;
                using (StreamReader sr = file.OpenText())
                    knjiga.Body = sr.ReadToEnd();
                solr.Add(knjiga);
            }
            // Prosleđivanje dodatih dokumenata u indeks. 
            solr.Commit();
        }

        private void btnPretrazivanje_Click(object sender, System.EventArgs e)
        {
            // Otvaranje konekcije ka Solr serveru
            ISolrOperations<Knjiga> solr =
                ServiceLocator.Current.GetInstance<ISolrOperations<Knjiga>>();
            
            // Dodatne opcije za izvršenje upita. Ovde se podešavaju Start i Rows za 
            // paginaciju. 
            QueryOptions query_options = new QueryOptions
            {
                Rows = 10,
                StartOrCursor = new StartOrCursor.Start(0)
            };
            // Izvršenje upita. 
            SolrQueryResults<Knjiga> results = solr.Query(
                new SolrQueryByField((String)cmbPolje.SelectedItem, txtUpit.Text),
                query_options);
            // Prikaz rezulatata. 
            dgvResults.DataSource = results;
        }
    }
}
