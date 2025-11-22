namespace StoreApp.Services.Identity.Application.Logging;

public interface ILoggerService
{
    void LogInfo(string message);
    void LogWarning(string message);
    void LogError(string message);
    void LogDebug(string message);
}
