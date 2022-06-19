using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Wykladowca
    {

        [Key]
        public int WykladowcaID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string StopienNaukowy { get; set; }
        [ForeignKey("Przedmiot")]
        public string ProwadzonyPrzedmiot { get; set; }


        public virtual Przedmiot Przedmiot { get; set; }


        public Wykladowca() { }
        public Wykladowca(string Imie, string Nazwisko, string StopienNaukowy, string ProwadzonyPrzedmiot)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.StopienNaukowy = StopienNaukowy;
            this.ProwadzonyPrzedmiot = ProwadzonyPrzedmiot;
        }
    }
}
