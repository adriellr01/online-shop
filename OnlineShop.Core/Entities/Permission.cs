using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Entities
{
    public class Permission
    {
        [Required]
        public int Id { get; set; }
        [Required,MaxLength(128)]
        public string Name { get; set; }
        [Required]
        public bool IsGranted{ get; set; } 
        public int RoleId { get; set; }
        public long UserId { get; set; }

            
        
                
    }
}
