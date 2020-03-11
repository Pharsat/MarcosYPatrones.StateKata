using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StateKata
{
    public class SiegeState : IUnitState
    {
        public bool CanMove { get; set; }

        public int Damage { get; set; }

        public SiegeState()
        {
            CanMove = false;

            Damage = 20;
        }
    }
}
