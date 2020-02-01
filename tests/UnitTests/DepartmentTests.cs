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
            departmentFactoryFakeInterface = new Mock<IDepartmentFactory>();

        }
        [Fact]
        public void MailDepartment_Should_Handle_UpToOneKiloGram_Parcel()
        {
            var parcel = new Parcel(1, 10);
            var department = departmentFactoryFakeInterface.Setup(e=>e.)
            if (parcel.tag == Tag.UpToOneKiloGram)
                //myInterface.Setup(m => m.Handle(parcel));


        }
        [Fact]
        public void RegularDepartment_Should_Handle_UpToTenKiloGram_Parcel()
        {

        }
        [Fact]
        public void HeavyDepartment_Should_Handle_OverTenKiloGram_Parcel()
        {

        }
        [Fact]
        public void InsuranceDepartment_Should_Handle_OverAHundredPound_Parcel_Before_Other_Departments()
        {

        }
    }
}
