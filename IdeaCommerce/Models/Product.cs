using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaCommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
         
        // Relationships
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
