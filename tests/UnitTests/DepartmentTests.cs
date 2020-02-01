using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using ParcelDelivery.Domain;
using Xunit;

namespace UnitTests
{
    public class DepartmentTests
    {
        private Mock<IDepartmentFactory> departmentFactoryFakeInterface;
        public DepartmentTests()
        {
            departmentFactoryFakeInterface = new Mock<IDepartmentFactory>(){CallBase = true};

        }
        [Fact]
        public void MailDepartment_Should_Handle_UpToOneKiloGram_Parcel()
        {
            var parcel = new Parcel(1, 1);
            //Assuming the factory works. I should later write a test for my factory
            departmentFactoryFakeInterface.Setup(e => e.Get(parcel)).Returns(new MailDepartment());
            var dep=departmentFactoryFakeInterface.Object.Get(parcel);
            Assert.Equal("mail", dep.Handle(parcel));



        }
        [Fact]
        public void RegularDepartment_Should_Handle_UpToTenKiloGram_Parcel()
        {
            var parcel = new Parcel(1, 9);
            //Assuming the factory works. I should later write a test for my factory
            departmentFactoryFakeInterface.Setup(e => e.Get(parcel)).Returns(new MailDepartment());
            var dep = departmentFactoryFakeInterface.Object.Get(parcel);
            Assert.Equal("regular", dep.Handle(parcel));
        }
        [Fact]
        public void HeavyDepartment_Should_Handle_OverTenKiloGram_Parcel()
        {
            var parcel = new Parcel(1, 11);
            //Assuming the factory works. I should later write a test for my factory
            departmentFactoryFakeInterface.Setup(e => e.Get(parcel)).Returns(new RegularDepartment());
            var dep = departmentFactoryFakeInterface.Object.Get(parcel);
            Assert.Equal("heavy", dep.Handle(parcel));
        }
        [Fact]
        public void InsuranceDepartment_Should_Handle_OverAHundredPound_Parcel_Before_Other_Departments()
        {
            var parcel = new Parcel(1000, 11);
            //Assuming the factory works. I should later write a test for my factory
            departmentFactoryFakeInterface.Setup(e => e.Get(parcel)).Returns(new MailDepartment());
            var dep = departmentFactoryFakeInterface.Object.Get(parcel);
            Assert.Equal("insurance", dep.Handle(parcel));
        }
    }
}
