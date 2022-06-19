using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Platnosc
    {
        [Key]
        public int PlatnoscID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public int Kwota { get; set; }
        public DateTime DataPlatnosci { get; set; }



        public virtual Student Student { get; set; }
    }
}
