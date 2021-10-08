using System;

namespace Builder
{
    public abstract class Bottle
    {
        protected readonly float[] bottleVolumes = { 0.33f, 0.5f, 1.25f };
        public BottleColor Color { get; protected set; }
        public float Volume { get; protected set; }

        public Bottle(BottleSize size)
        {
            Volume = bottleVolumes[(int)size];
        }

        public override string ToString()
        {
            return Volume + "l";
        }
    }
}
