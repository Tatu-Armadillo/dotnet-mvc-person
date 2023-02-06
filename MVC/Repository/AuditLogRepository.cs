using Microsoft.AspNetCore.Mvc;
using MVC.Data.Context;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Repository
{
    public class AuditLogRepository : IAuditLogRepository
    {
        private MySQLContext context;

        public AuditLogRepository(MySQLContext context)
        {
            this.context = context;
        }
        public virtual void Save(string createUser = "usuario criador", string action = "")
        {
            var log = new AuditLog
            {
                CreatedByUser = createUser,
                CreatedDate = DateTime.Now,
                Action = action
            };
            context.Add(log);
            context.SaveChanges();
        }

        public virtual void Erase(long id)
        {
            var result = context.Logs.SingleOrDefault(l => l.Id.Equals(id));
            context.Logs.Remove(result);
            context.SaveChanges();
        }

        public virtual List<AuditLog> FindLogs()
        {
            return context.Logs.ToList();
        }

    }
}
