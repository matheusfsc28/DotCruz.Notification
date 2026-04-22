using DotCruz.Notifications.Exceptions.Enums;

namespace DotCruz.Notifications.Exceptions.BaseExceptions;

public class NotificationTypeNotSupportedException : NotificationException
{
    public NotificationTypeNotSupportedException() : base(ResourceMessagesException.NOTIFICATION_TYPE_NOT_SUPPORTED)
    {
    }

    public override IEnumerable<string> GetErrorsMessages() => [Message];

    public override ErrorType GetErrorType() => ErrorType.Validation;
}
