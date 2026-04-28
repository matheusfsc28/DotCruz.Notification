using DotCruz.Notifications.Domain.Interfaces;
using Moq;

namespace CommonTestUtilities.Services;

public class TemplateEngineBuilder
{
    private readonly Mock<ITemplateEngine> _mock;

    public TemplateEngineBuilder()
    {
        _mock = new Mock<ITemplateEngine>();
        
        // Default behavior to avoid validation errors when Render is called
        _mock.Setup(e => e.Render(It.IsAny<string>(), It.IsAny<Dictionary<string, object>?>()))
            .Returns("Default Rendered Body");
    }

    public TemplateEngineBuilder Render(string result)
    {
        _mock.Setup(e => e.Render(It.IsAny<string>(), It.IsAny<Dictionary<string, object>?>()))
            .Returns(result);

        return this;
    }

    public ITemplateEngine Build() => _mock.Object;
}
