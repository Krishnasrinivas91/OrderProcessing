using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class BookPaymentProcess : IPaymentProcess
    {
        public string ProcessPayment()
        {
            string message = "DuplicateSlipForRoyaltyDepartment";
            PackingSlip packingSlip = new PackingSlip();
            var packing = packingSlip.CreatePackingSlip(Enum.EnumPackingSlip.RoyaltyDepartmentPacking);
            packing.Packing(message);
            return message;
        }
    }
}
