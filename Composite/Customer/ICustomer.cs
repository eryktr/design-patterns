namespace Composite.Customer
{
    internal interface ICustomer
    {
        string Name { get; }
        void Notify(Message message);
    }
}