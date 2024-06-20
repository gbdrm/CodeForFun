using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeForFun.Data.Models
{
    public class Idea
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(5000)]
        [MinLength(10)]
        public required string Description { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public required User Author { get; set; }

        public IdeaStatus Status { get; set; }
    }

    public enum IdeaStatus
    {
        Open = 0,
        OnReview = 1,
        Done = 2,
        Canceled = 3
    }
}