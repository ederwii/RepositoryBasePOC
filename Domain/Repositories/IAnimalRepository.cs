using Domain.DataModels;
using Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IAnimalRepository : IRepositoryBase<Animal>
    {
    }
}
