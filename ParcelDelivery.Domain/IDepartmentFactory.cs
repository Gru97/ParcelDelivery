using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Domain
{
    public  interface IDepartmentFactory
    {
        IDepartment Get(Parcel parcel);
    }
}
