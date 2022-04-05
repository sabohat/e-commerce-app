using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaCommerce.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }


        public String Name { get; set; }
        public String Description { get; set; }

        // Relentionships
        public List<Product> Products { get; set; }
    }
}
