using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FullStackAuth_WebAPI.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        //[Required]
        //public DateTime TimeCreated { get; set; }
        //[AllowNull]
        //public int LikeCounter { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }

        public string userName {  get; set; }
        
        public User User { get; set; }
        [ForeignKey("Media")]
        public int MediaId {  get; set; }

        public string MediaTitle {  get; set; }

        public string CoverImg { get; set; }

        public Media Media { get; set; }
        
    }
}
