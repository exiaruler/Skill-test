using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Server.Models
{
    public class Client
    {
        [Key]
        [Required]
        public int ID { get; set; }
      public string firstName { get; set; }
      public string lastName { get; set; }
       public string dob { get; set; }
    }
}
