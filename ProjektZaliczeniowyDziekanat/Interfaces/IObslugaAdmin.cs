using ProjektZaliczeniowyDziekanat.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjektZaliczeniowyDziekanat.Interfaces
{
    public interface IObslugaAdmin
    {
        List<Zajecia> PobierzPlanZajec(string searchString);
        IQueryable<Zajecia> WyszukajZajecia(string searchString, IQueryable<Zajecia> zajecia);
        List<StudentDTO> PobierzListeStudentow(string searchString);
        IQueryable<StudentDTO> WyszukajStudent(string searchString, IQueryable<StudentDTO> studenci);
        List<WykladowcaDTO> PobierzListeWykladowcow(string searchString);
        IQueryable<WykladowcaDTO> WyszukajWykladowca(string searchString, IQueryable<WykladowcaDTO> wykladowcy);
        bool DodajDoPlanu(string GrupaNr, string NazwaPrzedmiotu, string TerminZajec, string WykladowcaID);
        bool UsunZPlanu(string ZajeciaID);
        bool DodajStudenta(string NumerIndeksu, string Imie, string Nazwisko, string DataUrodzenia, string MiejsceUrodzenia, string AdresZamieszkania, string MiejsceZamieszkania, string Narodowosc, string Obywatelstwo, string PESEL, string GrupaNr);
        bool UsunStudenta(string StudentID);
        bool DodajWykladowceDoBazy(string Imie, string Nazwisko, string StopienNaukowy, string ProwadzonyPrzedmiot, string PESEL, string AdresZamieszkania, string MiejsceZamieszkania, string Narodowosc, string Obywatelstwo);
        bool UsunWykladowceZBazy(string WykladowcaID);
        
    }
}
