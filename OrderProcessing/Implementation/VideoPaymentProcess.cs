using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class VideoPaymentProcess : IPaymentProcess
    {
        private string _video;
        public string video
        { 
            get 
            {
                return _video;
            }
            set
            {
                _video = value;
            }
        }
        public string ProcessPayment()
        {
            string message = "";
            if (_video == "LearningToSki"){
                message = "Add a free video";
                PackingSlip packingSlip = new PackingSlip();
                var packing = packingSlip.CreatePackingSlip(Enum.EnumPackingSlip.VideoPacking);
                packing.Packing(message);
            }
            return message;
        }
    }
}
