using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEx.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Required Field")]
        public int ? Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

    }
}
