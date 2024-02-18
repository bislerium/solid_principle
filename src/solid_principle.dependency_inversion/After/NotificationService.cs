namespace solid_principle.dependency_inversion.After
{
    public class NotificationService
    {
        private readonly INotificationSender[] _notificationSenders;

        public NotificationService(params INotificationSender[] senders)
        {
            _notificationSenders = senders;
        }

        public void Notify(string recipient, string message)
        {
            foreach (var sender in _notificationSenders)
            {
                sender.Notify(recipient, message);
            }
        }
    }
}
