using Bogus;
using DotCruz.Notifications.Application.UseCases.Notifications.RegisterFailureNotification;

namespace CommonTestUtilities.Commands.Notifications;

public class RegisterFailureNotificationCommandBuilder
{
    public static RegisterFailureNotificationCommand Build(Guid? notificationId = null, IEnumerable<string>? errors = null)
    {
        var f = new Faker();
        return new RegisterFailureNotificationCommand(
            NotificationId: notificationId ?? f.Random.Guid(),
            ErrorsMessage: errors ?? [f.Lorem.Sentence(), f.Lorem.Sentence()]
        );
    }
}
