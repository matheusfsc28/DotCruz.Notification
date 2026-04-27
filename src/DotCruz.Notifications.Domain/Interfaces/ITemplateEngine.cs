namespace DotCruz.Notifications.Domain.Interfaces;

public interface ITemplateEngine
{
    string Render(string content, Dictionary<string, object>? data);
}
