using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Domain
{
    public class MailDepartment:IDepartment
    {
        public void Handle(Parcel parcel)
        {
            Console.WriteLine("Parcel is being handled by mail department");
        }
    }
}
