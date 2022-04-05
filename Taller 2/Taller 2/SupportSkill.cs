using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class SupportSkill : Card, IValues
    {
        int eP;
        EffectType eType;

        void ApplyValues()
        {
            eP = rnd.Next(2, 7);           
        }
    }
}
