using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingTime { get; set; }


        //Category-Heading Relation (2)
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        //Heading-Content Relation (1)
        public ICollection<Content> Contents { get; set; }


        //Wrıter-Heading Relation (2)
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
