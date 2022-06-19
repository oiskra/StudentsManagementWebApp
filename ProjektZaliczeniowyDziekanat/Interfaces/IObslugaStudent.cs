using ProjektZaliczeniowyDziekanat.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyDziekanat.Interfaces
{
    public interface IObslugaStudent
    {
        Task<List<Zajecia>> WyswietlZajeciaAsync(Student ZalStudent, string sortOrder, string searchString);
        Student ZalogowanyStudent(int? StudentID);
        Task<StudentDTO> ZalogowanyStudentDTOAsync(int? StudentID);
        Task<IQueryable<Zajecia>> SortujZajeciaAsync(string sortOrder, IQueryable<Zajecia> zajecia);
        Task<IQueryable<Zajecia>> SzukajFrazyWZajeciachAsync(string searchString, IQueryable<Zajecia> zajecia);
        Platnosc ZnajdzPlatnosc(int? id);
        Task<List<StudentOceny>> PobierzOcenyStudentaAsync(int? id);
        Zajecia PobierzZajecia(int idZajec);
    }
}
