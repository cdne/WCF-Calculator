using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DerivativesCalculatorService;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                using(ServiceHost host = new ServiceHost(typeof(Calculator))) 
                {
                    host.Open();
                    Console.WriteLine("The derivative calculator is running");
                    foreach (var address in host.BaseAddresses)
                    {
                        Console.WriteLine($"BaseAddress: {address}");
                    }
                    Console.WriteLine($"Host is running...Press Enter to stop");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occured. {ex.Message}");
            }
            Console.WriteLine("Service is stopped.");
            Console.ReadLine();
        }
    }
}
