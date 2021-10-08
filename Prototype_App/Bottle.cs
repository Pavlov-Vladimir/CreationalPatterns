using System;

namespace Prototype_App
{
    public abstract class Bottle : ICloneable
    {
        public string Name { get; protected set; }

        public object Clone()
        {
            return this.MemberwiseClone() as Bottle;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
