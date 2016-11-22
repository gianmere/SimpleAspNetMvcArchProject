﻿using SimpleAspNetMvcArchProject.Data.Domain;

namespace SimpleAspNetMvcArchProject.Service
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long Id);
    }
}
