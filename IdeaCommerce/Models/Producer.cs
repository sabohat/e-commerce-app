using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaCommerce.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string CompanyName { get; set; }
        public string Bio { get; set; }

        // Relentionships
        public List<Product> Products { get; set; }

    }
}
