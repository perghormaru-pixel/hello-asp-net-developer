using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

public static class GreetDeveloperAssembler 
{
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity is null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse(message: "Welcome Anonymus ASP.NET Developer");
        return new GreetDeveloperReponse(entity.Id , entity.GetFullName(),
            Messsage: $"Congrats {entity.GetFullName()} ! You are an"
    }
}