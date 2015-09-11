using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSWAPDemoWebForms.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Views { get; set; }

        public DateTime CreatedOn { get; set; }

    }

    public class MessagesContext : IDisposable
    {
        private static List<Message> _messages =
            new List<Message>
            {
                new Message { Id = 1, Title = "@blowdart is so dreamy", Views = 54612, CreatedOn = new DateTime(2015, 6, 8) },
                new Message { Id = 2, Title = "What is the poster of #1 drinking? I need some",  Views = 9, CreatedOn = new DateTime(2015, 6, 9)},
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