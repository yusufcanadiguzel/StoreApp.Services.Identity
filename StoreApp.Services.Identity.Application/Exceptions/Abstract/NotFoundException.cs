namespace StoreApp.Services.Identity.Application.Exceptions.Abstract;

public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message) : base(message)
    {
        
    }
}