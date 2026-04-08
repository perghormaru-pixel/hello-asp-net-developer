namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;
/// <summary>
/// A record representing a request to greet a developer
/// </summary>
/// <param name="FirstName">The developer name, it can be null</param>
/// <param name="LastName">The developer last name, it can be null</param>

public record GreatDeveloperRequest(string? FirstName, string? LastName);