using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Manga
{
    public class ModelloManga
    {
        public int Id {  get; set; }
        public string Titolo { get; set; }
        public EnumManga Tipo { get; set; }   
        public double Prezzo { get; set; }
        public int NumeroPagine { get; set; }
        public ModelloManga()
        {
        }
    }
}
