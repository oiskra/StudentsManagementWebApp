using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class WykladowcaLogowanie
    {

        [Key]
        public int WykladowcaLogowanieID { get; set; }
        [ForeignKey("Wykladowca")]
        public int WykladowcaID { get; set; }
        [Required(ErrorMessage = "Proszę podać login")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Proszę podać hasło")]
        public string Haslo { get; set; }



        public virtual Wykladowca Wykladowca { get; set; }


        public WykladowcaLogowanie() { }

        public WykladowcaLogowanie(int WykladowcaID, string Login, string Haslo)
        {
            this.WykladowcaID = WykladowcaID;
            this.Login = Login;
            this.Haslo = Haslo;
        }
    }
}
