using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApplication.Models
{
    public class Nurse
    {
        [Key]
        public int NurseId { get; set; }
        public string NurseName { get; set; }

    }
}
