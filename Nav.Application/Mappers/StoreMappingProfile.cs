using AutoMapper;
using Nav.Application.Responses;
using Nav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nav.Application.Mappers
{
  public  class StoreMappingProfile:Profile
    {
        public StoreMappingProfile()
        {
            CreateMap<Store, StoreResponse>().ReverseMap();
        }
    }
}
