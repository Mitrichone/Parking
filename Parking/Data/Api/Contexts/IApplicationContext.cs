﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parking.Data;
using System.Threading;
namespace Parking.Data.Api.Contexts
{
    public interface IApplicationDataContext : 
    IKeyDataContext, 
    ITariffDataContext, 
    ISellOutDataContext, 
    ISubscriptionDataContext, 
    ICouponDataContext,
    IStatisticDataContext,
    IParkingDataContext
    {
    }
}
