namespace solid_principle.dependency_inversion.After
{
    public interface INotificationSender
    {
        void Notify(string recipient, string message);
    }
}
