using ProjektZaliczeniowyDziekanat.DAL.Models;

namespace ProjektZaliczeniowyDziekanat.Interfaces
{
    public interface IObslugaAccount
    {
        bool CzyAdmin(string Login, string Haslo);
        bool WyszukajStudentaDoZalogowania(string Login, string Haslo);
        Student PobierzZalogowanegoStudenta(string Login, string Haslo);
        bool WyszukajWykladowceDoZalogowania(string Login, string Haslo);
        Wykladowca PobierzZalogowanegoWykladowce(string Login, string Haslo);

    }
}
