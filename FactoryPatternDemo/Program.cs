using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLibrary;

namespace FactoryPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Kenan";
            owner.LastName = "Kurda";
            owner.EmailAddress = "kenan@chuki.com";
            owner.PhoneNumber = "1234567890";
            
            IWork work = Factory.CreateWork();

            work.WorkName = "Javascript programming";
                work.Owner = owner;
            
            work.PerformedWork(3);
            work.PerformedWork(1.5);
            work.CompleteWork();

            Console.ReadLine();
        }
    }
}
