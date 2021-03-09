using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessing.Implementation;
using OrderProcessing.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Test
{
    [TestClass]
    public class ProcessTypeTest
    {
        [TestMethod]
        public void GetProperProcessType()
        {
            var mock = new Mock<IProcessType>();
            mock.Setup(p => p.GetProcessType(1)).Returns(new PhysicalProductPaymentProcess());
            ProcessType processType = new ProcessType();
            var result = processType.GetProcessType(1);
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void GetNullProcessType()
        {
            
            ProcessType processType = new ProcessType();
            var result = processType.GetProcessType(7);
            Assert.IsTrue(result == null);
        }
    }
}
