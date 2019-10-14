using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYP.ViewModels
{
    public class SupervisorandCosupervisorVM
    {
        // just for primitive data type because atleast one primitive data type is compulsory in VM
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SupervisorName { get; set; }

        [Required]
        [StringLength(50)]
        public string CoSupervisorName { get; set; }
    }
}