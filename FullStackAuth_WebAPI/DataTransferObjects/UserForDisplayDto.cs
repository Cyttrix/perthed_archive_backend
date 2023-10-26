using System.ComponentModel.DataAnnotations;

namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class UserForDisplayDto
    {
        //DTO used when displaying User linked with FK
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
