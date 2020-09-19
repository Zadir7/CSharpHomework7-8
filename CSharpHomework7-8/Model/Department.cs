using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHomework7_8.Model
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
