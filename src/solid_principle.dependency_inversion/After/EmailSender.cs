namespace solid_principle.dependency_inversion.After
{
    public class EmailSender : INotificationSender
    {
        public void Notify(string to, string message)
        {
            // Implementation for sending an email.
        }
    }
}
