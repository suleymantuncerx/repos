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
    public class ProgrammingLanguageManager:IProgrammingLanguageService
    {
        private readonly IGenericRepository<ProgrammingLanguage> _programmingLanguageRepository;
        public ProgrammingLanguageManager(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }
        public void Add(ProgrammingLanguage entity)
        {
            _programmingLanguageRepository.Add(entity);
        }
        public void Delete(int id)
        {
            _programmingLanguageRepository.Delete(id);
        }
        public void Update(ProgrammingLanguage entity)
        {
            _programmingLanguageRepository.Update(entity);
        }
        public List<ProgrammingLanguage> GetAll()
        {
            return _programmingLanguageRepository.GetAll();
        }
        public ProgrammingLanguage GetById(int id)
        {
            return _programmingLanguageRepository.GetById(id);
        }
    }
}
