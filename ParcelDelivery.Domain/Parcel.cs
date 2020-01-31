using System;

namespace ParcelDelivery.Domain
{

    public enum Tag
    {
        UpToOneKiloGram,
        UpToTenKiloGram,
        OverTenKiloGram,
        OverAHundredPound


    }
    public class Parcel
    {
        public int Value { get; private set; }
        public int Weight { get; private set; }
        public Tag tag { get; private set; }

        public Parcel(int value, int weight)
        {
            Value = value;
            Weight = weight;
            if (weight <= 1)
                tag = Tag.UpToOneKiloGram;
            else if (1 < weight && weight <= 10)
                tag = Tag.UpToTenKiloGram;
            else if (weight > 10)
                tag = Tag.OverTenKiloGram;

            if (value > 1000)
                tag = Tag.OverAHundredPound;
        }      

        public int GetValue()
        {
            return Value;
        }

        public int GetWeight()
        {
            return  Weight;
        }

        public Tag GetTag()
        {
            return tag;
        }
    }
}
