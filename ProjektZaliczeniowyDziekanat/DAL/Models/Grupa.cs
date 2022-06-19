using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektZaliczeniowyDziekanat.DAL.Models
{
    public class Grupa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string GrupaNr { get; set; }

    }
}
