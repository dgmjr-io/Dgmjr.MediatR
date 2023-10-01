namespace Dgmjr.MediatR.Notifications;

using Microsoft.Extensions.Logging;

public class NotificationsLogger<TNotification>
    : global::MediatR.INotificationHandler<TNotification>
    where TNotification : INotification
{
    private readonly ILogger<NotificationsLogger<TNotification>> _logger;

    public NotificationsLogger(ILogger<NotificationsLogger<TNotification>> logger)
    {
        _logger = logger;
    }

    public Task Handle(TNotification notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Notification: {Notification}", notification);
        return Task.FromResult(Unit.Value);
    }
}
