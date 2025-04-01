using AspNetCoreHero.Results;
using FluentValidation;
using MediatR;
using OptimaDesk.Common.Enums;

namespace OptimaDesk.Application.RetailStation.Pumps.Commands.AddPump
{
    public class AddPumpCommand : IRequest<IResult<string>>
    {
        public string? RetailStationId { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public ProductType ProductType { get; set; }
        public decimal OpeningMeter { get; set; }
        public decimal Totalizer { get; set; }
    }

    public class AddPumpCommandValidator : AbstractValidator<AddPumpCommand>
    {
        public AddPumpCommandValidator()
        {
            RuleFor(x => x.RetailStationId).NotNull().NotEmpty();
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x=> x.Model).NotNull().NotEmpty();
            RuleFor(x => x.ProductType).NotNull().NotEmpty();
            RuleFor(x => x.OpeningMeter).NotNull().NotEmpty();
        }
    }
}
