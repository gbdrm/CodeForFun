using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeForFun.Data.Models
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public required User Author { get; set; }

        [Required]
        public required string Title { get; set; } = string.Empty;

        [Required]
        public required string Content { get; set; } = string.Empty;

        [Required]
        public DateTime DateTimeCreated { get; set; } = DateTime.UtcNow;

        public ICollection<Tag>? Tags { get; set; }
    }
}
