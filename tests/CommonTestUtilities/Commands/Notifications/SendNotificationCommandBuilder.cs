using Bogus;
using DotCruz.Notifications.Application.UseCases.Notifications.SendNotification;

namespace CommonTestUtilities.Commands.Notifications;

public class SendNotificationCommandBuilder
{
    public static SendNotificationCommand Build(Guid? notificationId = null)
    {
        return new SendNotificationCommand(notificationId ?? Guid.NewGuid());
    }
}
