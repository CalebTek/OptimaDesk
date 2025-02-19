using AspNetCoreHero.Results;
using MediatR;

namespace OptimaDesk.Application.Authentication.Login
{
    public partial class LoginCommand : UserAuth, IRequest<IResult<AuthToken>>
    {
    }
}
