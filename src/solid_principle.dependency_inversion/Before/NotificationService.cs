namespace solid_principle.dependency_inversion.Before
{
    public class NotificationService
    {
        private readonly EmailSender _emailSender;
        private readonly SMSSender _smsSender;
        private readonly PushNotificationSender _pushNotificationSender; 
        // Add for new channel.

        public NotificationService()
        {
            _emailSender = new EmailSender();
            _smsSender = new SMSSender();
            _pushNotificationSender = new PushNotificationSender();
            // Assign new channels.
        }

        public void Notify(string recipient, string message)
        {
            _emailSender.SendEmail(recipient, message);
            _smsSender.SendSMS(recipient, message);
            _pushNotificationSender.SendPushNotification(recipient, message);
        }
    }
}
