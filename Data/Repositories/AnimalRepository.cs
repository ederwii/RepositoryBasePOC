using Data.Repositories.Base;
using Domain.DataModels;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class AnimalRepository : RepositoryBase<Animal>, IAnimalRepository
    {
        private readonly AppDbContext _context;

        public AnimalRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
