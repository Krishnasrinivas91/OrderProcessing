using OrderProcessing.Implementation;
using OrderProcessing.Inerfaces;
using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Process Type between 1 and 6");
            IProcessType processType = new ProcessType();
            int process;
            string readLine = Console.ReadLine();
            int.TryParse(readLine, out process);
            IPaymentProcess paymentProcess = processType.GetProcessType(process);
            paymentProcess.ProcessPayment();
            Console.WriteLine("Processed Succesfully");
            Console.Read();
        }

    }
}
