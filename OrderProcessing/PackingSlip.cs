using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class PackingSlipParent
    {
        public virtual void Packing(string message)
        {
            Console.WriteLine(message);
        }

        public void SendEmail()
        {
            Console.WriteLine("EmailSent");
        }

        public void GenerateCommissionToAgent()
        {
            Console.WriteLine("CommissionToAgentGenerated");
        }
    }

    public class ShippingPack : PackingSlipParent
    {
        public override void Packing(string message)
        {
            Console.WriteLine(message);
            base.GenerateCommissionToAgent();
        }
    }

    public class RoyaltyDepartmentPacking : PackingSlipParent
    {
        public override void Packing(string message)
        {
            Console.WriteLine(message);
            base.GenerateCommissionToAgent();
        }
    }

    public class VideoPacking : PackingSlipParent
    {
    }

    public class ActivateMemberShip : PackingSlipParent
    {
        public override void Packing(string message)
        {
            Console.WriteLine(message);
            base.SendEmail();
        }
    }

    public class UpgradeMembership : PackingSlipParent
    {
        public override void Packing(string message)
        {
            Console.WriteLine(message);
            base.SendEmail();
        }
    }

}
