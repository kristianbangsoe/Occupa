using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using occupaTab.Models;

namespace occupaTab.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Anatomi - Muskler", Description="Efter en blodprop eller blødning i hjernen, får hver anden problemer med at tygge og synke mad. Det kaldes dysfagi.\nSenest opdateret: 06. september kl. 02:17\nLigesom en blodprop eller blødning i hjernen kan give lammelser i arm og ben, kan den forårsage lammelser og føleforstyrrelser i mund og svælg – også kaldet dysfagi.\n\nDysfagi er typisk mindre synligt for den ramte og de pårørende.\n\nHvad er dysfagi?\nDysfagi betyder, at det kan være svært at spise, drikke og synke og kan indebære, at:" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Anatomi – Skilettet", Description="Hver anden problemer med at tygge og synke mad. Det kaldes dysfagi." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fysiologi – Åndedræt", Description="Celler egentlig kan holde til belastninger og hvad der sker med dem, når belastningen bliver for stor, fx cancer. Forskellen på virus og bakterier, og hvordan de på forskellig vis kan skade kroppen." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sygdomslære – Hygiene", Description="Almen sygdomslære\nGenerelt indledende kapitel om, hvordan celler egentlig kan holde til belastninger og hvad der sker med dem, når belastningen bliver for stor, fx cancer. Forskellen på virus og bakterier, og hvordan de på forskellig vis kan skade kroppen.\n\nInfektionssygdomme\nDe mest almindelige sygdomme, der udløses af virus og bakterier, fx børnesygdommene, almindelige forkølelse, mellemørebetændelse og aids.\n\nAllergiske lidelser\nHvad der sker, når kroppens forsvar ikke fungerer optimalt, og nogle forskellige former for allergi\n\nHjerte- og krredsløbssygdomme samt blodsygdomme\nHvorfor er forhøjet blodtryk egentlig farligt? Åreforkalkning, blodpropper, åreknuder. Selve blodet og celler, der danner de forskellige blodlegemer fx de røde, kan også være udsat for sygdomme.\n\nLunger.\nLungerne er et udsat område, bronkitis, kræft. Hvad er rygerlunger (KOL) egentlig, og er alle med KOL rygere?\n\nFordøjelsessystemets sygdomme\nFra mund, spiserør, mavesæk og gennem hele tarmsystemet er en hel række forskellige sygdomme, man kan komme til at fejle, fx leverbetændelse og forskellige former for både tyndtarms- og tyktarmsbetændelser.\n\nNyrer og blære.\nDet er generelt skidt at få dårlige nyrer, for ofte når de at blive meget dårlige før man mærker noget. Man kan også få nyrebækkenbetændelse og blærebetændelse.\n\nNeurologiske sygdomme\nHer er det nervesystemet, der er noget i vejen med, det kan fx være epilepsi, migræne, parkinsons sygdom. Hjernen kan også blive ramt af en blodprop eller hjerneblødning.\n\nHormonelle sygdomme\nHer vil fokus ligge på diabetes 1+2, men der er mange andre former for ubalancer skyldet hormoner, fx for høj/lav stofskifte.\n\nSygdomme i bryst og kønsorganer\nDet er forskellige former for underlivslidelser, cancer i bryst og prostata(blærehalsskirtlen)\n\nHudsygdomme\nBlot en enkelt nævnes her: Psoriasis\n\nBevægeapparatets sygdomme\nDet er kort sagt, når man har ondt i muskler, led og knogler. Myoser, forskellige gigt former og brud på knogler.\n\nPsykiatriske sygdomme \nSåvel som kroppen kan blive syg, kan sindet blive sygt. Personlighedsforstyrrelser, angst, OCD, skizofreni, spiseforstyrrelser for blot at nævne nogle af lidelserne.\n\nPsykosomatik\nDer er en ganske tæt sammenhæng med sind og krop, og de påvirker hinanden hele tiden, nogle gange viser det sig som sygdomme, fx hjertebanken og søvnløshed ved stress." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ergoterapi – Dysfagi", Description="Efter en blodprop eller blødning i hjernen, får hver anden problemer med at tygge og synke mad. Det kaldes dysfagi.\nSenest opdateret: 06. september kl. 02:17\nLigesom en blodprop eller blødning i hjernen kan give lammelser i arm og ben, kan den forårsage lammelser og føleforstyrrelser i mund og svælg – også kaldet dysfagi.\n\nDysfagi er typisk mindre synligt for den ramte og de pårørende.\n\nHvad er dysfagi?\nDysfagi betyder, at det kan være svært at spise, drikke og synke og kan indebære, at:" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Pædagogik – Flytte teknikker", Description="Fordøjelsessystemets sygdomme\nFra mund, spiserør, mavesæk og gennem hele tarmsystemet er en hel række forskellige sygdomme, man kan komme til at fejle, fx leverbetændelse og forskellige former for både tyndtarms- og tyktarmsbetændelser.\n\nNyrer og blære." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}