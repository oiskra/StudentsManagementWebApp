using ProjektZaliczeniowyDziekanat.DAL.Contexts;
using ProjektZaliczeniowyDziekanat.DAL.Models;
using ProjektZaliczeniowyDziekanat.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyDziekanat.Services
{
    public class ObslugaWykladowca : IObslugaWykladowca
    {
        private readonly DziekanatContext dziekanatDb;

        public ObslugaWykladowca(DziekanatContext dziekanatDb)
        {
            this.dziekanatDb = dziekanatDb;
        }

        public async Task<List<Zajecia>> WyswietlZajeciaAsync(Wykladowca ZalWykladowca)
        {
            IQueryable<Zajecia> zajecia = await Task.Run(() => from z in dziekanatDb.PlanZajec where z.WykladowcaID == ZalWykladowca.WykladowcaID  orderby z.TerminZajec select z);

            return zajecia.ToList();
        }
        
        public async Task<Wykladowca> ZalogowanyWykladowcaAsync(int? WykladowcaID)
        {
            if (WykladowcaID != null)
            {
                Wykladowca wykladowca = await Task.Run(() => dziekanatDb.Wykladowcy.First(x => x.WykladowcaID == WykladowcaID));
                return wykladowca;
            }
            else
                return null;
        }

        public async Task<WykladowcaDTO> ZalogowanyWykladowcaDTOAsync(int? WykladowcaID)
        {
            if (WykladowcaID != null)
            {
                WykladowcaDTO wykladowcaDTO = await Task.Run(() => dziekanatDb.WykladowcyDTO.First(x => x.WykladowcaID == WykladowcaID));
                return wykladowcaDTO;
            }
            else
                return null;
        }
    }
}
