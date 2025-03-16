using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private List<ProgrammingLanguage> _languages;

        public ProgrammingLanguageRepository()
        {
            _languages = new List<ProgrammingLanguage>();
            _languages.Add(new ProgrammingLanguage { Id = 1, Name = "C#" });
            _languages.Add(new ProgrammingLanguage { Id = 2, Name = "Java" });
            _languages.Add(new ProgrammingLanguage { Id = 3, Name = "Python" });
        }
        public void Add(ProgrammingLanguage entity)
        {
            _languages.Add(entity);
            Console.WriteLine($"{entity.Name} eklendi.");
        }

        public void Delete(int id)
        {
            var language = _languages.Find(l => l.Id == id);
            if (language != null)
            {
                _languages.Remove(language);
                Console.WriteLine($"{language.Name} silindi.");
            }
        }

        public void Update(ProgrammingLanguage entity)
        {
            var language = _languages.Find(l => l.Id == entity.Id);
            if (language != null)
            {
                language.Name = entity.Name;
                Console.WriteLine($"{entity.Id} ID'li dil güncellendi.");
            }
        }

        public List<ProgrammingLanguage> GetAll()
        {
            return _languages;
        }

        public ProgrammingLanguage GetById(int id)
        {
            return _languages.Find(l => l.Id == id);
        }
    }
}