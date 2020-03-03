using System;
using System.Collections.Generic;
using System.Text;

namespace IacobEduard
{
    class Apartamente : Imobiliar {
        public Apartamente(int m_P, int camere, int etaj) : base(m_P, camere, etaj) { }

        public int CalcPret()
        {
            if (camere == 2) { basicPret = 69000; }
            else { basicPret = m_P * 1175; }
            if (etaj >= 2 || etaj <= 8) { basicPret += 100; }
            else if (etaj == 13) { basicPret -= 130; }//for the ppl with Triskaidekaphobia (13 number phobia)
            else { basicPret -= 50; }
            return basicPret;
        }

    }
}
