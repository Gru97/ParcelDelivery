using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Domain
{
    public class DepartmentFactory:IDepartmentFactory
    {
        public IDepartment Get(Parcel parcel)
        {
            if (parcel.tag == Tag.OverAHundredPound)
                return new InsuranceDepartment();
            if (parcel.tag==Tag.UpToOneKiloGram)
                return new MailDepartment(); 
            if (parcel.tag == Tag.UpToTenKiloGram)
                return new RegularDepartment();
            
            if (parcel.tag == Tag.OverTenKiloGram)
                return new HeavyDepartment();
            return null;




        }
    }
}
