using DotCruz.Notifications.Domain.Entities.Notifications;
using DotCruz.Notifications.Domain.Enums.Notifications;
using DotCruz.Notifications.Domain.Interfaces;
using Moq;

namespace CommonTestUtilities.Services;

public class NotificationSenderStrategyBuilder
{
    private readonly Mock<INotificationSenderStrategy> _mock;

    public NotificationSenderStrategyBuilder(NotificationType type)
    {
        _mock = new Mock<INotificationSenderStrategy>();
        _mock.Setup(s => s.HandledType).Returns(type);
    }

    public INotificationSenderStrategy Build() => _mock.Object;
}
