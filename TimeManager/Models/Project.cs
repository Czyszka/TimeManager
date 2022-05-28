using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Models
{
    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan WorkTimeSpan { get; set; }

        public override string ToString()
        {
            return $"{Name ?? "null"}";
        }

    }
}
