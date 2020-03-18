using System;
using System.Collections.Generic;
using System.Text;

namespace IacobEduard
{
    class Case : Imobiliar
    {
        public Case(int m_P, int camere, int etaje) : base(m_P, camere, etaje) { }

        public int etaje { get; set; }

        public int CalcPret()
        {
            if (camere == 1) { basicPret = m_P*640; }
            else { basicPret = m_P * 1175 + camere*100; }
            if (etaje > 3) { throw new InvalidOperationException("O casa nu poate avea mai mult de 3 etaje."); }
            else { basicPret += etaje*100; }
            return basicPret;
        }

    }
}
