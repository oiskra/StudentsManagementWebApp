using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class StudentLogowanie
    {
        [Key]
        public int StudentLogowanieID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Proszę podać login")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Proszę podać hasło")]
        public string Haslo { get; set; }



        public virtual Student Student { get; set; }

        public StudentLogowanie() { }

        public StudentLogowanie(int StudentID, string Login, string Haslo)
        {
            this.StudentID = StudentID;
            this.Login = Login;
            this.Haslo = Haslo;
        }
    }
}
