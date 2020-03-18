using System;
using System.Collections.Generic;
using System.Text;

namespace IacobEduard
{
    class Garsoniere : Imobiliar
    {
        public Garsoniere(int m_P, int camere, int etaj) : base(m_P, camere, etaj) { }

        public int CalcPret()
       {
            if (camere == 1) { basicPret = m_P * 800; }
            else if (camere != 1) { throw new InvalidOperationException("Numarul camerelor trebuie sa coincida cu 1"); }
            if (etaj >= 2 || etaj <= 8) {basicPret += 100; }
            else if (etaj == 13) { basicPret -= 130; }
            else { basicPret -= 50; }
            return basicPret;
        }

    }
}
