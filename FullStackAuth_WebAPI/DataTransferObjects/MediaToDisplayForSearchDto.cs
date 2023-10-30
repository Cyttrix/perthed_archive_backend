using System.Text.Json;

namespace FullStackAuth_WebAPI.DataTransferObjects
   
{
    public class MediaToDisplayForSearchDto
    {
        public string id {  get; set; }

        public string name { get; set; }

        public string thumbnail { get; set; }

        public string[] genres {  get; set; }

        public string type { get; set; }

        public string year { get; set; }
    }
}
