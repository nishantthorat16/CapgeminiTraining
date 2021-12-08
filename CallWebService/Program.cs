using OnlineCalculator;
using System;
using static OnlineCalculator.CalculatorSoapClient;

namespace CallWebService
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            CalculatorSoapClient client = new CalculatorSoapClient(EndpointConfiguration.CalculatorSoap);
            int resdult =  client.AddAsync(10, 20).Result;
            int resultw =  client.SubtractAsync(30, 20).Result;

            Console.WriteLine(resdult);

        }
    }
}
