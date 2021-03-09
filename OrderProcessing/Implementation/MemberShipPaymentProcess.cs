using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class MemberShipPaymentProcess : IPaymentProcess
    {
        public string ProcessPayment()
        {
            string message = "ActivateMembership";
            PackingSlip packingSlip = new PackingSlip();
            var packing = packingSlip.CreatePackingSlip(Enum.EnumPackingSlip.ActivateMemberShip);
            packing.Packing(message);
            return message;
        }
    }
}
