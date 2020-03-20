using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StateKata
{
    public class TankState : IUnitState
    {
        public bool CanMove { get; set; }

        public int Damage { get; set; }

        public TankState()
        {
            CanMove = true;
            Damage = 5;
        }
    }
}
