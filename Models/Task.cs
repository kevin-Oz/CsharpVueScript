using System.ComponentModel.DataAnnotations;

namespace csharpVue.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public bool status { get; set; }
    }
} 