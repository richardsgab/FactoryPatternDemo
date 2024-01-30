namespace FactoryLibrary
{
    public interface IWork
    {
        double HoursWorked { get; set; }
        bool IsComplete { get; set; }
        IPerson Owner { get; set; }
        string WorkName { get; set; }

        void CompleteWork();
        void PerformedWork(double hours);
    }
}