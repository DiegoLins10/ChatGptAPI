using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatGptAPI.Models
{
    public class ChatGptInputModel
    {
        public ChatGptInputModel(string prompt)
        {
            this.prompt = $"Correct this phrase: {prompt}";
            temperature = 0.2m;
            max_tokens = 100;
            model = "text-davinci-003";
        }

        public string model { get; set; }
        public string prompt { get; set; }
        public int max_tokens { get; set; }
        public decimal temperature { get; set; }
    }
}
