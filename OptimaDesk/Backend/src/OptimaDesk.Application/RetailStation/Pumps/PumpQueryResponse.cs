using AutoMapper;
using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Mappings;
using OptimaDesk.Domain.RetailStations;

namespace OptimaDesk.Application.RetailStation.Pumps
{
    public class PumpQueryResponse : IMapFrom<Pump>
    {
        public string? Id { get; set; }
        public string? RetailStationId { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public ProductType Type { get; set; }
        public decimal OpeningMeter { get; set; }
        public decimal ClosingMeter { get; set; }
        public decimal Totalizer { get; set; }
        public decimal RTT { get; set; }
        public decimal TotalSales { get; set; }
        public decimal ActualSales { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pump, PumpQueryResponse>()
                .ForMember(dest => dest.Totalizer, opt => opt.MapFrom(src => src.Totalizer))
                .ForMember(dest => dest.ActualSales, opt => opt.MapFrom(src => src.ActualSales));
        }
    }
}
