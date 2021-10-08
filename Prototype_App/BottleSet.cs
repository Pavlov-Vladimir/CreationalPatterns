using System;
using System.Collections.Generic;

namespace Prototype_App
{
    public class BottleSet
    {
        List<Bottle> _bottles;

        public BottleSet(byte quantity)
        {
            _bottles = new List<Bottle> { Capacity = quantity };
        }

        public void Pack(Bottle bottle)
        {
            for (int i = 0; i < _bottles.Capacity; i++)
                _bottles.Add((Bottle)bottle.Clone());
        }

        public void Show()
        {
            foreach (Bottle bottle in _bottles)
                Console.WriteLine(bottle);
        }
    }
}
