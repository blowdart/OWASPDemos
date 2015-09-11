using System;
using System.Collections.Generic;

namespace OWASPDemos.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string From { get; set; }

        public string To { get; set; }
    }

    public class MessagesContext : IDisposable
    {
        private static List<Message> _messages =
            new List<Message>
            {
                new Message { Id = 1, Title = "Annual Performance Review", Content = "Your shirts are loud and offensive, no pay rise.", From = "scottgu@microsoft.com", To = "barryd@idunno.org"  },
                new Message { Id = 2, Title = "Annual Performance Review", Content = "Well done for not strangling Barry. Have some more money.", From = "scottgu@microsoft.com", To = "barrysboss@microsoft.com"  },
            };

        public IList<Message> Messages
        {
            get { return _messages; }
        }

        public void Dispose()
        {
            ;
        }
    }
}
