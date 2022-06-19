using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Zajecia
    {
        [Key]
        public int ZajeciaID { get; set; }
        [ForeignKey("Grupa")]
        public string GrupaNr { get; set; }
        [ForeignKey("Przedmiot")]
        public string NazwaPrzedmiotu { get; set; }
        public DateTime TerminZajec { get; set; }
        [ForeignKey("Wykladowca")]
        public int WykladowcaID { get; set; }



        public virtual Grupa Grupa { get; set; }
        public virtual Przedmiot Przedmiot { get; set; }
        public virtual Wykladowca Wykladowca { get; set; }

        public Zajecia() { }

        public Zajecia(string GrupaNr, string NazwaPrzedmiotu, DateTime TerminZajec, int WykladowcaID)
        {
            this.GrupaNr = GrupaNr;
            this.NazwaPrzedmiotu = NazwaPrzedmiotu;
            this.TerminZajec = TerminZajec;
            this.WykladowcaID = WykladowcaID;
        }
    }
}
