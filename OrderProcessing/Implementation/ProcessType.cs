using OrderProcessing.Enum;
using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class ProcessType : IProcessType
    {
        public IPaymentProcess GetProcessType(int processType)
        {
            switch (processType)
            {
                case (int)EnumProcessType.PhysicalProduct:
                    return new PhysicalProductPaymentProcess();
                case (int)EnumProcessType.Book:
                    return new BookPaymentProcess();
                case (int)EnumProcessType.MemberShip:
                    return new MemberShipPaymentProcess();
                case (int)EnumProcessType.UpgradeMemberShip:
                    return new UpgradeMemberShipPaymentProcess();
                case (int)EnumProcessType.Video:
                    return new VideoPaymentProcess();
                default:
                    return null;
            }
        }
    }
}
