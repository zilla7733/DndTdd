using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd
{
    public class Combat
    {
        public void ResolveAttack (int dieRoll, Character attacker, Character defender)
        {
            if (defender.ArmorClass <= dieRoll+attacker.Strength.Modifier)
            {
                defender.HitPoints = defender.HitPoints - GetDamage(dieRoll, attacker.Strength.Modifier);
            }
        }

        private int GetDamage(int dieRoll, int strenghtModifier)
        {
            int result = 0;

            if (dieRoll == 20)
            {
                result = strenghtModifier * 2 + 2;
            }
            else 
            {
                result = ++strenghtModifier;
            }

            if (result < 0)
            {
                result= 1;
            }
            
            return result;
        }
    }
}
