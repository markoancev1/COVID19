using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19.Data.Entities
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int testCases { get; set; }
        public int confirmedCases { get; set; }
        public int recoveredCases { get; set; }
        public int fatalCases { get; set; }
        public virtual ICollection<Cases> Cases { get; set; }
    }
}

