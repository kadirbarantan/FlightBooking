using AutoMapper;
using FlightBooking.Dtos.FlightDtos;
using FlightBooking.Entities;

namespace FlightBooking.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Flight, CreateFlightDto>().ReverseMap();
            CreateMap<Flight, GetFlightDto>().ReverseMap();
            CreateMap<Flight, ResultFlightDto>().ReverseMap();
            CreateMap<Flight, UpdateFlightDto>().ReverseMap();
        }
    }
}
