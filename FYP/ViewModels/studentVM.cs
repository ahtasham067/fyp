using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FYP.ViewModels
{
    public class StudentVM
    {
        // just for primitive data type because atleast one primitive data type is compulsory in VM
        [Key]
        public int Id { get; set; }



        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Supervisor { get; set; }

        public int CoSupervisor { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Summary { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Objective { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Scope { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ToolsAndTechnologies { get; set; }

        [StringLength(500)]
        public string ProposalFileType { get; set; }

        [Required]
        [StringLength(500)]
        public string ProposalFilePath { get; set; }

        [Required]
        [StringLength(500)]
        public string ProposalFileName { get; set; }

        public int Semester { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int ContactNo { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(50)]
        public string RegNo { get; set; }

        public int ProjectId { get; set; }
    }
}