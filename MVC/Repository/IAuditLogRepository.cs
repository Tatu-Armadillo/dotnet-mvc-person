using System.Collections.Generic;
using MVC.Models;

namespace MVC.Repository
{
    public interface IAuditLogRepository
    {
        void Save(string createdUser, string action);
        void Erase(long id);
        List<AuditLog> FindLogs();
    }
}
