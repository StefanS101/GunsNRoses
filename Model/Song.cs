using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunsNRoses.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RtfUrl { get; set; }//referenca na rtf datoteku
        public string ImageUrl { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
