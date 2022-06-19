using ProjektZaliczeniowyDziekanat.Interfaces;
using ProjektZaliczeniowyDziekanat.DAL.Contexts;
using ProjektZaliczeniowyDziekanat.DAL.Models;
using System.Linq;

namespace ProjektZaliczeniowyDziekanat.Services
{
    public class ObslugaAccount : IObslugaAccount
    {
        private readonly DziekanatContext dziekanatDb;

        public ObslugaAccount(DziekanatContext dziekanatDb)
        {
            this.dziekanatDb = dziekanatDb;
        }

        public bool CzyAdmin(string Login, string Haslo)
        {
            Admin adminLogin = dziekanatDb.Admini.First(x => x.Login == Login && x.Haslo == Haslo);

            if (!(adminLogin == null))
                return true;
            else
                return false;
        }


        public bool WyszukajStudentaDoZalogowania(string Login, string Haslo)
        {
            StudentLogowanie studentDoZalogowania = dziekanatDb.StudenciLogowanie.First(x => x.Login == Login && x.Haslo == Haslo);

            if (!(studentDoZalogowania == null))
                return true;
            else
                return false;
        }

        public Student PobierzZalogowanegoStudenta(string Login, string Haslo)
        {
            StudentLogowanie studentDoZalogowania = dziekanatDb.StudenciLogowanie.First(x => x.Login == Login && x.Haslo == Haslo);

            if (!(studentDoZalogowania == null))
            {
                Student student = dziekanatDb.Studenci.First(x => x.StudentID == studentDoZalogowania.StudentID);
                return student;
            }

            return null;
        }

        public bool WyszukajWykladowceDoZalogowania(string Login, string Haslo)
        {
            WykladowcaLogowanie wykladowcaDoZalogowania = dziekanatDb.WykladowcyLogowanie.First(x => x.Login == Login && x.Haslo == Haslo);

            if (!(wykladowcaDoZalogowania == null))
                return true;
            else
                return false;
        }

        public Wykladowca PobierzZalogowanegoWykladowce(string Login, string Haslo)
        {
            WykladowcaLogowanie wykladowcaDoZalogowania = dziekanatDb.WykladowcyLogowanie.First(x => x.Login == Login && x.Haslo == Haslo);

            if (!(wykladowcaDoZalogowania == null))
            {
                Wykladowca wykladowca = dziekanatDb.Wykladowcy.First(x => x.WykladowcaID == wykladowcaDoZalogowania.WykladowcaID);
                return wykladowca;
            }

            return null;
        }

    }
}
