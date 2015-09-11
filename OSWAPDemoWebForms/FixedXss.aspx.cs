using OSWAPDemoWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSWAPDemoWebForms
{
    public partial class FixedXss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("SecretInformation", "likeOMGMegan");
            HttpContext.Current.Response.Cookies.Add(cookie);

            using (var dbContext = new MessagesContext())
            {
                foreach (var message in dbContext.Messages.OrderByDescending(m => m.CreatedOn))
                {
                    MessagesList.Rows.Add(CreateMessageRow(message));
                }
            }
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MessagesContext())
            {
                int id = 0;
                if (dbContext.Messages.Count != 0)
                {
                    id = dbContext.Messages.OrderByDescending(i => i.Id).First().Id++;
                }

                var message = new Message
                {
                    Id = id,
                    Title = MessageTitle.Text,
                    Views = 0,
                    CreatedOn = DateTime.Now
                };

                dbContext.Messages.Add(message);
                MessagesList.Rows.AddAt(1, CreateMessageRow(message));
            }
        }

        private TableRow CreateMessageRow(Message message)
        {
            var row = new TableRow();
            var titleCell = new TableCell
            {
                Text = HttpUtility.HtmlEncode(message.Title)
            };
            var viewsCell = new TableCell
            {
                Text = HttpUtility.HtmlEncode(message.Views.ToString())
            };
            var createdOnCell = new TableCell
            {
                Text = HttpUtility.HtmlEncode(message.CreatedOn.ToShortDateString())
            };
            row.Cells.Add(titleCell);
            row.Cells.Add(viewsCell);
            row.Cells.Add(createdOnCell);

            return row;
        }
    }
}