

using BoletoBus.Infraestructure.Base;

namespace BoletoBus.Infraestructure.Notification.Interfaces
{
    public interface INotificationService<TModel> where TModel : class
    {
        public Task<NotificationResult>Send(TModel model);
    }
}
