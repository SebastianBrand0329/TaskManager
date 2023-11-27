using System.ComponentModel.DataAnnotations;

namespace TaskManager.Shared.Entities
{
    public class MyTask
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]    
        public string? Description { get; set; }

        public DateTime Date { get; set; }

        public bool IsComplete { get; set; }
    }
}
