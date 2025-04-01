using AspNetCoreHero.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OptimaDesk.Application.Interfaces;
using OptimaDesk.Common.Enums;
using OptimaDesk.Domain.Context;
using OptimaDesk.Domain.RetailStations;

namespace OptimaDesk.Application.RetailStation.Pumps.Commands.AddPump
{
    internal sealed class AddPumpCommandHandler : IRequestHandler<AddPumpCommand, IResult<string>>
    {
        private readonly ApplicationContext _context;
        private readonly ILogger<AddPumpCommandHandler> _logger;
        private readonly ICurrentUserService _currentUserService;

        public AddPumpCommandHandler(ApplicationContext context, ILogger<AddPumpCommandHandler> logger, ICurrentUserService currentUserService)
        {
            _context = context;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        public async Task<IResult<string>> Handle(AddPumpCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var userId = _currentUserService.UserId;
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
                if (user is null || user.UserType != UserType.Control)
                {
                    _logger.LogInformation($"User with ID {userId} not found or not authorized to perfom this operation");
                    return await Result<string>.FailAsync("User not found or user not authorized");
                }

                var pumpentity = new Pump()
                {
                    Id = Guid.NewGuid().ToString(),
                    RetailStationId = request.RetailStationId,
                    Name = request.Name,
                    Model = request.Model,
                    Type = request.ProductType,
                    OpeningMeter = request.OpeningMeter,
                    ClosingMeter = request.OpeningMeter,
                    Totalizer = request.Totalizer,
                    TotalSales = 0,
                    RTT = 0,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = user.FullName,
                    Version = 1
                };

                await _context.AddAsync(pumpentity);
                await _context.SaveChangesAsync();

                return await Result<string>.SuccessAsync(pumpentity.Id, $"Pump with ID {pumpentity.Id} successfully added to retail station with Id {pumpentity.RetailStationId}");
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Failed to create a new pump entity {ex}");
                return await Result<string>.FailAsync("An error occur, please try again");
            }
        }
    }
}
