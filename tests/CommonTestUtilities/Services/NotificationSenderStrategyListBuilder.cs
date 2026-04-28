using DotCruz.Notifications.Domain.Interfaces;

namespace CommonTestUtilities.Services;

public class NotificationSenderStrategyListBuilder
{
    private readonly List<INotificationSenderStrategy> _strategies = [];

    public NotificationSenderStrategyListBuilder Add(INotificationSenderStrategy strategy)
    {
        _strategies.Add(strategy);
        return this;
    }

    public IEnumerable<INotificationSenderStrategy> Build() => _strategies;
}
