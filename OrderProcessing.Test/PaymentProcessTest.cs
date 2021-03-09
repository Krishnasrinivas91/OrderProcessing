using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessing.Implementation;
using OrderProcessing.Inerfaces;

namespace OrderProcessing.Test
{
    [TestClass]
    public class PaymentProcessTest
    {
        [TestMethod]
        public void CompleteBookPayment()
        {
            var mock = new Mock<IPaymentProcess>();
            mock.Setup(p => p.ProcessPayment()).Returns("DuplicateSlipForRoyaltyDepartment");
            BookPaymentProcess bookPaymentProcess = new BookPaymentProcess();
            var result = bookPaymentProcess.ProcessPayment();
            Assert.AreEqual("DuplicateSlipForRoyaltyDepartment", result);
        }

        [TestMethod]
        public void CompleteMembershipPayment()
        {
            var mock = new Mock<IPaymentProcess>();
            mock.Setup(p => p.ProcessPayment()).Returns("ActivateMembership");
            MemberShipPaymentProcess bookPaymentProcess = new MemberShipPaymentProcess();
            var result = bookPaymentProcess.ProcessPayment();
            Assert.AreEqual("ActivateMembership", result);
        }
        [TestMethod]
        public void CompletePhysicalProductPayment()
        {
            var mock = new Mock<IPaymentProcess>();
            mock.Setup(p => p.ProcessPayment()).Returns("GeneratePackingSlip");
            PhysicalProductPaymentProcess bookPaymentProcess = new PhysicalProductPaymentProcess();
            var result = bookPaymentProcess.ProcessPayment();
            Assert.AreEqual("GeneratePackingSlip", result);
        }
    }
}
