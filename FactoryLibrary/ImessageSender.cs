namespace FactoryLibrary
{
    public interface ImessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}