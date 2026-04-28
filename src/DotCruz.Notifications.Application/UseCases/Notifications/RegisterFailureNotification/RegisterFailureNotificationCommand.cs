using MediatR;

namespace DotCruz.Notifications.Application.UseCases.Notifications.RegisterFailureNotification;

public record RegisterFailureNotificationCommand(
    Guid NotificationId,
    IEnumerable<string> ErrorsMessage
): IRequest;
