using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Domain.Entities.Auth
{
    public class RefreshToken:BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string TokenHash {  get; set; }
        public bool IsRevoked { get; set; }
        public DateTime? RevokedAt { get; set; }

        public string CreatedByIp { get; set; }
    }
}
