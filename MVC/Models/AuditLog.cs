using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    [Table("logs")]
    public class AuditLog
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("created_by_user")]
        public string CreatedByUser { get; set; }
        [Column("action")]
        public string Action{ get; set; }
        [Column("created_date")]
        public DateTimeOffset CreatedDate{ get; set; }
    }
}
