using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class TechnologyRepository : IGenericRepository<Technology>
    {
        private List<Technology> _technologies;

        public TechnologyRepository()
        {
            _technologies = new List<Technology>();
            _technologies.Add(new Technology { Id = 1, Name = "ASP.NET Core", ProgrammingLanguage = new ProgrammingLanguage { Id = 1, Name = "C#" } });
            _technologies.Add(new Technology { Id = 2, Name = "Spring Boot", ProgrammingLanguage = new ProgrammingLanguage { Id = 2, Name = "Java" } });
            _technologies.Add(new Technology { Id = 3, Name = "Django", ProgrammingLanguage = new ProgrammingLanguage { Id = 3, Name = "Python" } });
        }

        public void Add(Technology entity)
        {
            _technologies.Add(entity);
            Console.WriteLine($"{entity.Name} teknolojisi eklendi.");
        }

        public void Delete(int id)
        {
            var tech = _technologies.Find(t => t.Id == id);
            if (tech != null)
            {
                _technologies.Remove(tech);
                Console.WriteLine($"{tech.Name} teknolojisi silindi.");
            }
        }

        public void Update(Technology entity)
        {
            var tech = _technologies.Find(t => t.Id == entity.Id);
            if (tech != null)
            {
                tech.Name = entity.Name;
                tech.ProgrammingLanguage.Id = entity.Id;
                Console.WriteLine($"{entity.Id} ID'li teknoloji güncellendi.");
            }
        }

        public List<Technology> GetAll()
        {
            return _technologies;
        }

        public Technology GetById(int id)
        {
            return _technologies.Find(t => t.Id == id);
        }
    }
}
