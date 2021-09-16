using System;
using System.Collections.Generic;
using System.Linq;
using Exterminator.Models;
using Exterminator.Models.Dtos;
using Exterminator.Models.Entities;
using Exterminator.Repositories.Data;
using Exterminator.Repositories.Interfaces;

namespace Exterminator.Repositories.Implementations
{
    public class LogRepository : ILogRepository
    {
        private readonly LogDbContext _dbContext = new LogDbContext();

        public void LogToDatabase(ExceptionModel exception)
        {
            _dbContext.Logs.Add(new Log
            {
                ExceptionMessage = exception.ExceptionMessage,
                StackTrace = exception.StackTrace,
                Timestamp = DateTime.Now
            });
            _dbContext.SaveChanges();
        }

        // TODO: Should contain a method which retrieves all logs (LogDto) ordered by timestamp (descending)
        public IEnumerable<LogDto> GetAllLogs()
        {
            return _dbContext.Logs.Select(x => new LogDto()
            {
                Id = x.Id,
                ExceptionMessage = x.ExceptionMessage,
                StackTrace = x.StackTrace,
                Timestamp = x.Timestamp

            }).OrderBy(x => x.Timestamp).AsEnumerable();

        }
    }
}