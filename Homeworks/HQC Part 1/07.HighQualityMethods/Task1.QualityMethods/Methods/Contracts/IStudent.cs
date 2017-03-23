namespace Methods.Contracts
{
    public interface IStudent
    {
        string FirstName { get; }

        string LastName { get; }

        string OtherInfo { get; set; }

        bool IsOlderThan(IStudent other);
    }
}
