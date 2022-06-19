using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class StudentOceny
    {
        [Key]
        public int StudentOcenyID { get; set; }
        [ForeignKey("StudentZajecia")]
        public int StudentID { get; set; }
        [ForeignKey("StudentZajecia")]
        public int ZajeciaID { get; set; }
        [Range(2,6)]
        public float Ocena { get; set; }



        public virtual Student Student { get; set; }
        public virtual Zajecia Zajecia { get; set; }

    }
}
