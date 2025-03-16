using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TechnologyManager : ITechnologyService
    {
        private readonly ITechnologyRepository _technologyRepository;

        public TechnologyManager(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        public void Add(Technology entity)
        {
            _technologyRepository.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Technology> GetAll()
        {
            throw new NotImplementedException();
        }

        public Technology GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Technology entity)
        {
            throw new NotImplementedException();
        }
    }
}
