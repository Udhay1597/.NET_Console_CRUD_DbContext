using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApplication.Models
{
    public class Doctor
    {
        [Key]
        public int DocId { get; set; }

        public string DocName { get; set; }
    }
}
