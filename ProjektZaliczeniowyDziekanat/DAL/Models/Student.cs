using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [ForeignKey("Grupa")]
        public string GrupaNr { get; set; }


        public virtual Grupa Grupa { get; set; }

        public Student() { }

        public Student(string NumerIndeksu, string Imie, string Nazwisko, string GrupaNr)
        {
            this.NumerIndeksu = NumerIndeksu;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.GrupaNr = GrupaNr;
        }
    }
}
