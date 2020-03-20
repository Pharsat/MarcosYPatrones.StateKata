using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StateKata
{
    public class Tank : IUnit
    {
        public IUnitState State { get; set; }

        public bool CanMove => State.CanMove;

        public int Damage => State.Damage;

        public Tank()
        {
            State = new TankState();
        }
    }
}
