using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StateKata
{
    public interface IUnit
    {
        IUnitState State { get; set; }

        bool CanMove { get; }

        int Damage { get; }
    }
}
