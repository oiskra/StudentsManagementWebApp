using ProjektZaliczeniowyDziekanat.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyDziekanat.Interfaces
{
    public interface IObslugaWykladowca
    {
        Task<List<Zajecia>> WyswietlZajeciaAsync(Wykladowca ZalWykladowca);
        Task<Wykladowca> ZalogowanyWykladowcaAsync(int? WykladowcaID);
        Task<WykladowcaDTO> ZalogowanyWykladowcaDTOAsync(int? WykladowcaID);
    }
}
