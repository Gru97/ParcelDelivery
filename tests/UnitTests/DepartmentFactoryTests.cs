using System;
using System.Collections.Generic;
using System.Text;
using ParcelDelivery.Domain;
using Xunit;

namespace UnitTests
{
    public class DepartmentFactoryTests
    {
        [Fact]
        public void Factory_Should_Return_MailDepartment_For_Parcel()
        {
            DepartmentFactory f=new DepartmentFactory();
            var parcel=new Parcel(1,1);
            Assert.Equal(typeof(MailDepartment), f.Get(parcel).GetType());
        }
        [Fact]

        public void Factory_Should_Return_RegularDepartment_For_Parcel()
        {
            DepartmentFactory f = new DepartmentFactory();
            var parcel = new Parcel(1, 9);
            Assert.Equal(typeof(RegularDepartment), f.Get(parcel).GetType());
        }
        [Fact]

        public void Factory_Should_Return_HeavyDepartment_For_Parcel()
        {
            DepartmentFactory f = new DepartmentFactory();
            var parcel = new Parcel(1, 11);
            Assert.Equal(typeof(HeavyDepartment), f.Get(parcel).GetType());
        }
        [Fact]

        public void Factory_Should_Return_InsuranceDepartment_For_Parcel()
        {
            DepartmentFactory f = new DepartmentFactory();
            var parcel = new Parcel(1001, 1);
            Assert.Equal(typeof(InsuranceDepartment), f.Get(parcel).GetType());
        }

    }
}
