using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYP.ViewModels
{
    public class AddLoginDetailVM
    {
        // just for primitive data type because atleast one primitive data type is compulsory in VM
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BatchName { get; set; }

        [Required]
        [StringLength(50)]
        public string CampusName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramName { get; set; }
    }
}