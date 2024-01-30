using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class Work : IWork
    {
        ILogger _logger;
        ImessageSender _messageSender;
        public string WorkName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public Work(ILogger logger, ImessageSender messagesender)
        {
            _logger = logger;
            _messageSender = messagesender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
           /* ILogger log = new Logger();*/           
            _logger.Log($"Performed work on {WorkName}");
        }
        public void CompleteWork()
        {
            IsComplete = true;
            /*ILogger log = new Logger();*/
            _logger.Log($"Completed {WorkName}");

            /*ImessageSender emailer = new Emailer();*/
            _messageSender.SendMessage(Owner, $"The work {WorkName} is completed");

        }
    }
}
