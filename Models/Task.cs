using System.ComponentModel.DataAnnotations;

namespace csharpVue.Models
{
    public class Task
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public bool status { get; set; }
    }
} 