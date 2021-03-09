using OrderProcessing.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class PackingSlip
    {
        public PackingSlipParent CreatePackingSlip(EnumPackingSlip enumPackingSlip)
        {
            switch (enumPackingSlip)
            {
                case EnumPackingSlip.ShippingPack:
                    return new ShippingPack();
                case EnumPackingSlip.RoyaltyDepartmentPacking:
                    return new RoyaltyDepartmentPacking();
                case EnumPackingSlip.VideoPacking:
                    return new VideoPacking();
                case EnumPackingSlip.ActivateMemberShip:
                    return new ActivateMemberShip();
                case EnumPackingSlip.UpgradeMembership:
                    return new UpgradeMembership();
                default:
                    return null;
            }
        }
    }
}
