using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
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
        //[Required, DefaultValue("")]
        //public string CoverImg { get; set; }
        //[Required, DefaultValue("")]
        //public string Genre { get; set; }
        //[Required, DefaultValue("")]
        
        //public string Runtime { get; set; }
        //[Required, DefaultValue("")]
        //blic string Synopsis { get; set; }
        [Required]
        public string TypeOfMedia { get; set; }
        //[Required, DefaultValue(2012)]
        //[DefaultValue(2012)]
        //public int Year { get; set; }
        //[Required, DefaultValue(1)]
        [Required]
        public int Episodes { get; set; }
        //[Required, DefaultValue("")]
        [Required]
        public string Status { get; set; }
        //[Required, DefaultValue("")]
        //public string Trailer {  get; set; }
        [AllowNull]
        public int Progress { get; set; }
        [AllowNull]
        public string DateCompleted {  get; set; }
        [AllowNull]
        public int Score { get; set; }
        [AllowNull]
        public string Note { get; set; }
        [ForeignKey("User")]
        public string UserId {  get; set; }
        public User User { get; set; }
    }
}
