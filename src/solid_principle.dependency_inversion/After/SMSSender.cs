namespace solid_principle.dependency_inversion.After
{
    public class SMSSender : INotificationSender
    {
        public void Notify(string phoneNumber, string message)
        {
            // Implementation for sending an SMS.
        }
    }
}
