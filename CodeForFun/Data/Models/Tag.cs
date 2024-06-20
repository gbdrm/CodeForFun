using System.ComponentModel.DataAnnotations;

namespace CodeForFun.Data.Models
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public ICollection<BlogPost>? BlogPosts { get; set; }
    }
}