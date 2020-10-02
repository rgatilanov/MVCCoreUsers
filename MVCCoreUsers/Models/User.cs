using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreUsers.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Nick { get; set; }

        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}
