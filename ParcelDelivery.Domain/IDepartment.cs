﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Domain
{
    public interface IDepartment
    {
        
        string Handle(Parcel parcel);
    }
}
