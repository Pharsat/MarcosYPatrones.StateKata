using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StateKata
{
    public interface IUnitState
    {
        bool CanMove { get; set; }

        int Damage { get; set; }
    }
}
