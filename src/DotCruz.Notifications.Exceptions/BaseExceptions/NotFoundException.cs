using DotCruz.Notifications.Exceptions.Enums;

namespace DotCruz.Notifications.Exceptions.BaseExceptions;

public class NotFoundException : NotificationException
{
    public NotFoundException(string message) : base(message) { }

    public override IEnumerable<string> GetErrorsMessages() => [Message];

    public override ErrorType GetErrorType() => ErrorType.NotFound;
}
