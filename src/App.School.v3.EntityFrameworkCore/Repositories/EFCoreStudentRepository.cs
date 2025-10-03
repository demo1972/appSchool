using App.School.v3.DTLs;
using App.School.v3.Entities;
using App.School.v3.EntityFrameworkCore;
using App.School.v3.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace App.School.v3.Repositories
{
    public class EFCoreStudentRepository : EfCoreRepository<v3DbContext, StudentDTL>, IStudent
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly ILogger<EFCoreStudentRepository> _logger;
        public EFCoreStudentRepository(IDbContextProvider<v3DbContext> dbContextProvider, IRepository<Student> studentRepository, ILogger<EFCoreStudentRepository> logger) : base(dbContextProvider)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public async Task<Student> CreateAsync(Student student) {
            try
            {
                var newStudent = await _studentRepository.InsertAsync(student);
                return newStudent;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in EFCoreStudentRepository: {ex.Message}");
                throw new Exception(ex.Message);
            }
             
        }
    }
}
