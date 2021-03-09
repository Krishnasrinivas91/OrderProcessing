using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class PhysicalProductPaymentProcess : IPaymentProcess
    {
        public string ProcessPayment()
        {
            string message = "GeneratePackingSlip";
            PackingSlip packingSlip = new PackingSlip();
            var packing = packingSlip.CreatePackingSlip(Enum.EnumPackingSlip.ShippingPack);
            packing.Packing(message);
            return message;
        }
    }
}
