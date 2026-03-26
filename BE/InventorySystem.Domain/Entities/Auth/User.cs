using InventorySystem.Domain.Entities;
using InventorySystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Domain.Entities.Auth
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public Role Role { get; set; } // Admin, Staff

        public bool IsActive { get; set; } = true;
    }
}
