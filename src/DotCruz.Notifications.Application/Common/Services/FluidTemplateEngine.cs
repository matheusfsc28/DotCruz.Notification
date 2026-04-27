using DotCruz.Notifications.Domain.Interfaces;
using Fluid;

namespace DotCruz.Notifications.Application.Common.Services;

public class FluidTemplateEngine : ITemplateEngine
{
    private static readonly FluidParser _parser = new();

    public string Render(string content, Dictionary<string, object>? data)
    {
        if (data == null || data.Count == 0) 
            return content;

        if (_parser.TryParse(content, out var template, out var error))
        {
            var context = new TemplateContext(data);
            return template.Render(context);
        }

        return content;
    }
}
