namespace solid_principle.dependency_inversion.After
{
    public class PushNotificationSender : INotificationSender
    {
        public void Notify(string deviceId, string message)
        {
            // Implementation for sending a push notification.
        }
    }
}
