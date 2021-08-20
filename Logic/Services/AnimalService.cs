using Domain.DataModels;
using Domain.Repositories;
using Domain.Services;
using Logic.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Services
{
    public class AnimalService : ServiceBase<Animal>, IAnimalService
    {
        private readonly IAnimalRepository _repository;
        public AnimalService(IAnimalRepository repository)
            :base(repository)
        {

        }
    }
}
