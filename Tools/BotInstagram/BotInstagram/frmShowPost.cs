using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;

namespace BotInstagram
{
    public partial class frmShowPost : Form
    {
        public string UserName;
        public frmShowPost()
        {
            InitializeComponent();
        }

        private async void frmShowPost_Load(object sender, EventArgs e)
        {
            this.Text = UserName;
            var userMedias = await ctx.api.UserProcessor
                .GetUserMediaAsync(username: UserName, PaginationParameters.MaxPagesToLoad(1));
            string html = "";
            if (userMedias.Succeeded)
            {
                foreach (var item in userMedias.Value)
                {
                    html += $"<div style='width:100%'>";
                    if (item.Images.Any())
                    {
                      html+=  $"<img src='{item.Images?[0].Uri}' style='width:100%'/>";
                    }
                    else if (item.Carousel.Any())
                    {
                        html += $"<img src='{item.Carousel[0].Images[0].Uri}' style='width:100%'/>";

                    }

                    html += $"<p><span>Like : {item.LikesCount}</span>" +
                            $"<span>Comment : {item.CommentsCount}</span>" +
                            $"</p>" +
                            $"<p>{item.Caption?.Text}</p>" +
                            $"</div>";
                }

                webBrowser1.DocumentText = html;
            }
        }
    }
}
