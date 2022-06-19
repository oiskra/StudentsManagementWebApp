using Microsoft.EntityFrameworkCore;
using ProjektZaliczeniowyDziekanat.DAL.Models;

namespace ProjektZaliczeniowyDziekanat.DAL.Contexts
{
    public class DziekanatContext : DbContext 
    {

        public DziekanatContext(DbContextOptions<DziekanatContext> options) : base(options) {    }

        public DbSet<Admin> Admini { get; set; } 
        public DbSet<StudentLogowanie> StudenciLogowanie { get; set; } 
        public DbSet<Platnosc> Platnosci { get; set; }
        public DbSet<Grupa> Grupy { get; set; }
        public DbSet<Przedmiot> Przedmioty { get; set; }
        public DbSet<Student> Studenci { get; set; }
        public DbSet<StudentDTO> StudenciDTO { get; set; }
        public DbSet<StudentOceny> StudenciOceny { get; set; }
        public DbSet<Wykladowca> Wykladowcy { get; set; }
        public DbSet<WykladowcaDTO> WykladowcyDTO { get; set; }
        public DbSet<WykladowcaLogowanie> WykladowcyLogowanie { get; set; }
        public DbSet<Zajecia> PlanZajec { get; set; }


    }
}
