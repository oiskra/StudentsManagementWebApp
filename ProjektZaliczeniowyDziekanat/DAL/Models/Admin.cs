using System.ComponentModel.DataAnnotations;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Required(ErrorMessage = "Proszę podać login")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Proszę podać hasło")]
        public string Haslo { get; set; }

    }
}
