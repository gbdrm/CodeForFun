using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CodeForFun.Data.Models
{
    public class User : IdentityUser<long>
    {
        public virtual ICollection<BlogPost>? BlogPosts { get; set; }
        public virtual ICollection<Idea>? Ideas { get; set; }

        public string? Bio { get; set; }
    }
}
