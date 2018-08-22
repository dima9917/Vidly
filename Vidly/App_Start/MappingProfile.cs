using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Customer, CustomerDto>();
            //    cfg.CreateMap<CustomerDto, Customer>();
            //});

            this.CreateMap<Customer, CustomerDto>();
            this.CreateMap<CustomerDto, Customer>().IgnoreAllPropertiesWithAnInaccessibleSetter(); //to ignore test prop
            this.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            this.CreateMap<Movie, MovieDto>();
            this.CreateMap<MembershipType, MembershipTypeDto>();
            this.CreateMap<Genre, GenreDto>();
            this.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}