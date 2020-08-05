using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;

namespace COVID19.Models
{
    public class CaseViewModel
    {
        [StringLength(250)]
        public string NameSurname { get; set; }

        public int Age { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        [StringLength(150)]
        public string City { get; set; }

        public Cities Cities { get; set; }

        [StringLength(250)]
        public string FirstSymptoms { get; set; }
        public DateTime FirstSyptomsDate { get; set; }
        public DateTime FirstTestDate { get; set; }
        public bool ResultFirstTest { get; set; }

        [StringLength(250)]
        public string Condition { get; set; }

        public DateTime Recover { get; set; }
        public DateTime Death { get; set; }

    }
}
