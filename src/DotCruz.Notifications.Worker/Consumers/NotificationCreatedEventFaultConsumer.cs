using DotCruz.Notifications.Application.Events.Notifications;
using DotCruz.Notifications.Application.UseCases.Notifications.RegisterFailureNotification;
using DotCruz.Notifications.CrossCutting.Resources;
using MassTransit;
using MediatR;

namespace DotCruz.Notifications.Worker.Consumers;

public class NotificationCreatedEventFaultConsumer : IConsumer<Fault<NotificationCreatedEvent>>
{
    private readonly IMediator _mediator;
    private readonly ILogger<NotificationCreatedEventFaultConsumer> _logger;

    public NotificationCreatedEventFaultConsumer(IMediator mediator, ILogger<NotificationCreatedEventFaultConsumer> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<Fault<NotificationCreatedEvent>> context)
    {
        var notificationId = context.Message.Message.NotificationId;
        var exceptions = context.Message.Exceptions.Select(x => x.Message);

        _logger.LogCritical(ResourceLogMessages.NOTIFICATION_FAILED_DEFINITIVELY, notificationId);

        await _mediator.Send(new RegisterFailureNotificationCommand(notificationId, exceptions), context.CancellationToken);
    }
}
