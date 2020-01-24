using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd
{
    public class Ability
    {
        private int _score = 10;

        public int Score { 
            get { return _score; } 
            set { 
                    if (value < 1 || value > 20)
                    {
                        throw new ArgumentException("Abilities must be between 1 and 20");
                    }

                _score = value;
            } 
        }

        public int Modifier { 
            get {
                    switch (_score)
                    {
                        case 1: return -5;
                        case 2:
                        case 3: return -4;
                        case 4:
                        case 5: return -3;
                        case 6:
                        case 7: return -2;
                        case 8:
                        case 9: return -1;
                        case 10:
                        case 11: return 0;
                        case 12:
                        case 13: return 1;
                        case 14:
                        case 15: return 2;
                        case 16:
                        case 17: return 3;
                        case 18:
                        case 19: return 4;
                            default:
                                return 5;
                    }
                }
            private set { } }
            

    }
}
