namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class MediaForDetailsPageDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string[] genres { get; set; }
        public int runtime { get; set; }
        //Synopsis prop
        public string recordType { get; set; }
        public string year { get; set; }
        public string[] trailers { get; set; }
    }
}
