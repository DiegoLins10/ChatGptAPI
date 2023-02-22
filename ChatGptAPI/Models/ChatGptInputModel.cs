using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatGptAPI.Models
{
    public class ChatGptInputModel
    {
        public string model { get; set; }
        public string prompt { get; set; }
        public int max_tokens { get; set; }
        public int temperature { get; set; }
    }
}
