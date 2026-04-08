using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;


namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// The Developer Assembler verify request
/// </summary>

public static class DeveloperAssembler
{
    public static Developer? ToEntityFromRequest(GreetDeveloperResponse? request)
    {
        if (request is null 
            || string.IsNullOrWhiteSpace(request.FirstName)
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;

        var firstName = request.FirstName;
        var lastName = request.LastName;
        return new Developer(firstName, lastName);

    }
}