using System;
using MVC.Models;
using MVC.Repository;

namespace MVC.Services
{
    public abstract class AuditLogServices
    {
        private AuditLogRepository repository;
        
        public AuditLogServices(AuditLogRepository repository)
        {
            this.repository = repository;
        }

        protected AuditLogServices() { }

       
    }
}
