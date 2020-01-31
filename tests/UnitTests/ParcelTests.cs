using System;
using ParcelDelivery.Domain;
using Xunit;

namespace UnitTests
{
    public class ParcelTests
    {
        [Fact]
        public void Parcel_Should_Be_Created_Successfully()
        {
            var value = 1;
            var weight = 1;
            var parcel = new Parcel(value, weight);
            Assert.NotNull(parcel);
            Assert.Equal( value, parcel.GetValue());
            Assert.Equal(weight, parcel.GetWeight());
        }
        [Fact]
        public void Parcel_Tag_Should_Be_Set_To_UpToOneKiloGram()
        {
            var value = 1;
            var weight = 1;
            var tag = Tag.UpToOneKiloGram;
            var parcel = new Parcel(value, weight);
            Assert.NotNull(parcel);
            Assert.Equal(value, parcel.GetValue());
            Assert.Equal(weight, parcel.GetWeight());
            Assert.Equal(parcel.GetTag(), tag);

        }
        [Fact]
        public void Parcel_Tag_Should_Be_Set_To_UpToTenKiloGram()
        {
            var value = 1;
            var weight = 9;
            var tag = Tag.UpToTenKiloGram;
            var parcel = new Parcel(value, weight);
            Assert.NotNull(parcel);
            Assert.Equal(value, parcel.GetValue());
            Assert.Equal(weight, parcel.GetWeight());
            Assert.Equal(parcel.GetTag(), tag);

        }
       
        [Fact]
        public void Parcel_Tag_Should_Be_Set_To_OverTenKiloGram()
        {
            var value = 1;
            var weight = 11;
            var tag = Tag.OverTenKiloGram;
            var parcel = new Parcel(value, weight);
            Assert.NotNull(parcel);
            Assert.Equal(value, parcel.GetValue());
            Assert.Equal(weight, parcel.GetWeight());
            Assert.Equal(parcel.GetTag(), tag);

        }
        [Fact]
        public void Parcel_Tag_Should_Be_Set_To_OverAHundredPound()
        {
            var value = 2000;
            var weight = 11;
            var tag = Tag.OverAHundredPound;
            var parcel = new Parcel(value, weight);
            Assert.NotNull(parcel);
            Assert.Equal(value, parcel.GetValue());
            Assert.Equal(weight, parcel.GetWeight());
            Assert.Equal(parcel.GetTag(), tag);

        }
    }
}
