using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolrNetPrimer
{
    // Objekat za prosleđivanje dokumenata Solr-u prilikom indeksiranja i 
    // preuzimanje rezultata nakon pretraživanja. 
    class Knjiga
    {
        // Objekat treba da sadrži javne property-je sa get i set delom. 
        // Property se mapira na odgovarajuće Solr polje atributom SolrField. 
        [SolrField("id")]
        public string Id { get; set; }

        [SolrField("link")]
        public string Link { get; set; }

        [SolrField("last_modified")]
        public DateTime LastModified { get; set; }

        [SolrField("body")]
        public String Body { get; set; }

        public override string ToString()
        {
            return Id + " " + Link + " " + LastModified;
        }

        // Da bi dodavanje uspelo kroz Solr web admin 
        // treba dodati ova polja u Core. Na http://localhost:8983/solr/#/ u padajućem 
        // meniju "Core Selector" izabrati jezgro "primer" pa zatim izabrati opciju "Schema". 
        // Zatm se klikom na dugme "Add Field" dodaju odgovarajuća polja. Posle dodavanja
        // ovih polja kroz web admin aplikaciju u fajlu managed-schema su automatski dodate
        // sledeće linije:
        // <field name="body" type="text_general" multiValued="true" indexed="true" stored="false"/>
        // <field name="id" type="string" multiValued="false" indexed="true" required="true" stored="true"/>
        // <field name="last_modified" type="pdate" indexed="true" stored="true"/>
        // <field name="link" type="string" indexed="true" stored="true"/>
    }
}
