using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class WykladowcaDTO
    {

        [Key]
        public int WykladowcaID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string StopienNaukowy { get; set; }
        [ForeignKey("Przedmiot")]
        public string ProwadzonyPrzedmiot { get; set; }
        public string PESEL { get; set; }
        public string AdresZamieszkania { get; set; }
        public string MiejsceZamieszkania { get; set; }
        public string Narodowosc { get; set; }
        public string Obywatelstwo { get; set; }


        public virtual Przedmiot Przedmiot { get; set; }


        public WykladowcaDTO() { }

        public WykladowcaDTO(string Imie, string Nazwisko, string StopienNaukowy, string ProwadzonyPrzedmiot, string PESEL, string AdresZamieszkania, string MiejsceZamieszkania, string Narodowosc, string Obywatelstwo)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.StopienNaukowy = StopienNaukowy;
            this.ProwadzonyPrzedmiot = ProwadzonyPrzedmiot;
            this.PESEL = PESEL;
            this.AdresZamieszkania = AdresZamieszkania;
            this.MiejsceZamieszkania = MiejsceZamieszkania;
            this.Narodowosc = Narodowosc;
            this.Obywatelstwo = Obywatelstwo;
        }
    }
}
