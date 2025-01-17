using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Struct
{
    public static class Autentikacija
    {
        private static Korisnik korisnikInstruktor;
        public static void SpremiKorisnika(Korisnik korisnik)
        {
            korisnikInstruktor = korisnik;
        }
        public static int VratiIDKorisnika()
        {
            if (korisnikInstruktor != null)
            {
                return korisnikInstruktor.korisnik_ID;
            }
            return 0;
        }
        public static void ObrisiKorisnika()
        {
            korisnikInstruktor = null;
        }
        public static Korisnik VratiImeKorisnika()
        {
            return korisnikInstruktor;
        }
    }
}
