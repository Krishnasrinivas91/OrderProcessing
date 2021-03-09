﻿using OrderProcessing.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Inerfaces
{
    public interface IProcessType
    {
        IPaymentProcess GetProcessType(int processType);
    }
}
