using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace FullStackAuth_WebAPI.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MediaTitle { get; set; }
        [Required]
        public string CoverImg { get; set; }
        [Required]
        public List<string> Genre { get; set; }
        [Required]
        public string Runtime { get; set; }
        [Required]
        public string Synopsis { get; set; }
        [Required]
        public string TypeOfMedia { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int Episodes { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Trailer {  get; set; }
        [AllowNull]
        public int Progress { get; set; }
        [AllowNull]
        public string DateCompleted {  get; set; }
        [AllowNull]
        public int Score { get; set; }
        [AllowNull]
        public int Note { get; set; }
        [ForeignKey("User")]
        public string UserId {  get; set; }
        public User User { get; set; }
    }
}
