namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;
/// <summary>
/// 
/// </summary>
/// <param name="Id"></param>
/// <param name="FullName"></param>
/// <param name="Message"></param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    public GreetDeveloperResponse(string message) : this(Id: null, FullName: null, message) { }
}