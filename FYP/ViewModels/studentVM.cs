using FYP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYP.ViewModels
{
    public class studentVM
    {
        //// just for primitive data type because atleast one primitive data type is compulsory in VM
        //[Key]
        //public int Id { get; set; }

        public List<Supervisor> Supervisors { get; set; }
        public List<Co_Supervisor> Co_Supervisors { get; set; }
        [Required]
        [StringLength(50)]
        public string SupervisorName { get; set; }
        [Required]
        [StringLength(50)]
        public string CoSupervisorName { get; set; }

    }
}