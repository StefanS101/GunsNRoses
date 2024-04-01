using System;

namespace GunsNRoses.Model
{
    [Serializable]
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RtfUrl { get; set; }//referenca na rtf datoteku
        public string ImageUrl { get; set; }
        public string CreationTime { get; set; }
    }
}
