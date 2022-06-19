using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Przedmiot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string NazwaPrzedmiotu { get; set; }

        public Przedmiot() { }

        public Przedmiot(string NazwaPrzedmiotu)
        {
            this.NazwaPrzedmiotu = NazwaPrzedmiotu;
        }
    }
}
