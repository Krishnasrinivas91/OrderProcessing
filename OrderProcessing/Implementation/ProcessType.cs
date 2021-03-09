using OrderProcessing.Enum;
using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class ProcessType : IProcessType
    {
        public IPaymentProcess GetProcessType(EnumProcessType enumProcessType)
        {
            switch (enumProcessType)
            {
                case EnumProcessType.PhysicalProduct:
                    return new PhysicalProductPaymentProcess();
                case EnumProcessType.Book:
                    return new BookPaymentProcess();
                case EnumProcessType.MemberShip:
                    return new MemberShipPaymentProcess();
                case EnumProcessType.UpgradeMemberShip:
                    return new UpgradeMemberShipPaymentProcess();
                case EnumProcessType.Video:
                    return new VideoPaymentProcess();
                default:
                    return null;
            }
        }
    }
}
