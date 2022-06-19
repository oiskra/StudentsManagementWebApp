using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class StudentDTO
    {
        [Key]
        public int StudentID { get; set; }
        public string NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string MiejsceUrodzenia { get; set; }
        public string AdresZamieszkania { get; set; }
        public string MiejsceZamieszkania { get; set; }
        public string Narodowosc { get; set; }
        public string Obywatelstwo { get; set; }
        public string PESEL { get; set; }
        [ForeignKey("Grupa")]
        public string GrupaNr { get; set; }



        public virtual Grupa Grupa { get; set; }

        public StudentDTO() { }

        public StudentDTO(string NumerIndeksu, string Imie, string Nazwisko, DateTime DataUrodzenia, string MiejsceUrodzenia, string AdresZamieszkania, string MiejsceZamieszkania, string Narodowosc, string Obywatelstwo, string PESEL, string GrupaNr)
        {
            this.NumerIndeksu = NumerIndeksu;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.DataUrodzenia = DataUrodzenia;
            this.MiejsceUrodzenia = MiejsceUrodzenia;
            this.AdresZamieszkania = AdresZamieszkania;
            this.MiejsceZamieszkania = MiejsceZamieszkania;
            this.Narodowosc = Narodowosc;
            this.Obywatelstwo = Obywatelstwo;
            this.PESEL = PESEL;
            this.GrupaNr = GrupaNr;
        }
    }
}
