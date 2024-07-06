using BoletoBus.Infraestructure.Base;
using BoletoBus.Infraestructure.Notification.Interfaces;
using BoletoBus.Infraestructure.Notification.Models;


namespace BoletoBus.Infraestructure.Notification.Services.Email

{
    public sealed class EmailService : INotificationService<EmailModel>
    {
        public Task<NotificationResult> Send(EmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
