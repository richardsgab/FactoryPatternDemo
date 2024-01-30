using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class Sms : ImessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulatin of a sms sned to {person.PhoneNumber}"); ;
        }
    }
}
