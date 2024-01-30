using FactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    internal static class Factory
    {
        public static IPerson CreatePerson()
        { 
            return new Person();
        }
        public static IWork CreateWork()
        {
            return new Work(CreateLogger(),CreateMessageSender());
        }
        public static ILogger CreateLogger()
        { 
            return new Logger();
        }
        public static ImessageSender CreateMessageSender() 
        {
            return new Emailer();
        }
        public static ImessageSender CreateSmsSender() 
        {
            return new Sms();
        }
       
    }
}
