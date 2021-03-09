using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class UpgradeMemberShipPaymentProcess : IPaymentProcess
    {
        public string ProcessPayment()
        {
            string message = "UpgradeMembership";
            PackingSlip packingSlip = new PackingSlip();
            var packing = packingSlip.CreatePackingSlip(Enum.EnumPackingSlip.UpgradeMembership);
            packing.Packing(message);
            return message;
        }
    }
}
