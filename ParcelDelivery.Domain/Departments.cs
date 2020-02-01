using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Domain
{
    public class MailDepartment:IDepartment
    {
        public string Handle(Parcel parcel)
        {
            Console.WriteLine("Parcel is being handled by mail department");
            return "mail";
        }
    }
    public class RegularDepartment : IDepartment
    {
        public string Handle(Parcel parcel)
        {
            Console.WriteLine("Parcel is being handled by regular department");
            return "regular";
        }
    }
    public class HeavyDepartment : IDepartment
    {
        public string Handle(Parcel parcel)
        {
            Console.WriteLine("Parcel is being handled by heavy department");
            return "heavy";
        }
    }
    public class InsuranceDepartment : IDepartment
    {
        public string Handle(Parcel parcel)
        {
            Console.WriteLine("Parcel is being handled by insurance department");
            return "insurance";
        }
    }

}
