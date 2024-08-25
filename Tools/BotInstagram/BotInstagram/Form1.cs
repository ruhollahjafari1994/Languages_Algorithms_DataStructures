using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.Classes.Models;

namespace BotInstagram
{
    public partial class frmMain : Form
    {
        private  static UserSessionData user;
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            user = new UserSessionData();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            ctx.api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                .Build();

            var loginRequest = await ctx.api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                gbLogin.Enabled = false;
                gbCommand.Enabled = true;
                pcImage.Load(ctx.api.GetLoggedUser().LoggedInUser.ProfilePicUrl);

            }
            else
            {
                MessageBox.Show("Login Failed .... \n "+loginRequest.Info.Message);
            }

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            (new frmEdiotProfile()).ShowDialog();
        }

        private async void btnDeletePic_Click(object sender, EventArgs e)
        {
            var result = await ctx.api.AccountProcessor.RemoveProfilePictureAsync();
            if (result.Succeeded)
            {
                pcImage.Image = null;
            }
        }

        private async void btnNewPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op=new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                byte[] picByte = System.IO.File.ReadAllBytes(op.FileName);
                var result = ctx.api.AccountProcessor.ChangeProfilePictureAsync(picByte).Result;
                if (result.Succeeded)
                {
                    pcImage.ImageLocation = op.FileName;
                }
            }
        }

        private async void btnFollowers_Click(object sender, EventArgs e)
        {
            var followers = await ctx.api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(1));
            foreach (var follower in followers.Value)
            {
                dgvFollowers.Rows.Add(follower.UserName, follower.FullName);
            }
        }

        private async void btnFollowing_Click(object sender, EventArgs e)
        {
            var currentusername =await ctx.api.UserProcessor.GetCurrentUserAsync();
            var follwings = await ctx.api.UserProcessor.GetUserFollowingAsync(currentusername.Value.UserName, PaginationParameters.MaxPagesToLoad(1));
            foreach (var follower in follwings.Value)
            {
                dgvFollowing.Rows.Add(follower.UserName, follower.FullName);
            }
        }

        private async void btnUserFollow_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtUser_UserName.Text);
            var follow =await ctx.api.UserProcessor.FollowUserAsync(user.Value.Pk);
            if (follow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnUnFollow_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtUser_UserName.Text);
            var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
            if (unfollow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnBlockUsers_Click(object sender, EventArgs e)
        {
            lstBlockUsers.Items.Clear();
            var users = await ctx.api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(1));
            foreach (var user in users.Value.BlockedList)
            {
                lstBlockUsers.Items.Add(user.UserName);
            }
        }

        private async void btnBlock_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtUser_UserName.Text);
            var block = ctx.api.UserProcessor.BlockUserAsync(user.Value.Pk);

            btnBlockUsers.PerformClick();
        }

        private async void btnUnBlock_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtUser_UserName.Text);
            var block = ctx.api.UserProcessor.UnBlockUserAsync(user.Value.Pk);

            btnBlockUsers.PerformClick();
        }

        private void lstBlockUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUser_UserName.Text = lstBlockUsers.SelectedItem.ToString();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(txtDirectUserName.Text);
            var direct = await ctx.api.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(),
                null, txtMessage.Text);
            if (direct.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
        }

        private async void btnSendImage_Click(object sender, EventArgs e)
        {
            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
            
            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == txtDirectUserName.Text).ThreadId;
          
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var imageUp = new InstaImage()
            {
                Uri = op.FileName
            };

            var image = await ctx.api.MessagingProcessor.SendDirectPhotoAsync(imageUp, threadId);
            if (image.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
            else
            {
                MessageBox.Show(image.Info.Message);
            }
        }

        private async void btnVideo_Click(object sender, EventArgs e)
        {
            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));

            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == txtDirectUserName.Text).ThreadId;

            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var videoUp = new InstaVideo()
            {
                Uri = op.FileName
            };

            var videoUpload = new InstaVideoUpload()
            {
                Video = videoUp
            };

            var directVideo = await ctx.api.MessagingProcessor.SendDirectVideoAsync(videoUpload, threadId);
            if (directVideo.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
            else
            {
                MessageBox.Show(directVideo.Info.Message);
            }
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            (new frmActivity()).ShowDialog();
        }

        private void btnShoPost_Click(object sender, EventArgs e)
        {
            frmShowPost frm=new frmShowPost(){
                UserName = txtUserNameForPosts.Text.Trim()
            };
            frm.ShowDialog();
        }

        private async void btnStoryPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog op=new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                var image = new InstaImage()
                {
                    Uri = op.FileName
                };
                var res = await ctx.api
                    .StoryProcessor.UploadStoryPhotoAsync(image, "TopLearn.Com");
                if (res.Succeeded)
                {
                    MessageBox.Show("Phopto Sended ....");
                }
            }
        }

        private async void btnStoryVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "select video";
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage=new OpenFileDialog();
            opImage.Title = "Select Image";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;

            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo(videoUri,0,0),
                VideoThumbnail = new InstaImage(imageUri,0,0)
            };
            var res = await ctx.api
                .StoryProcessor.UploadStoryVideoAsync(video, "TopLearn.Com");

            if (res.Succeeded)
            {
                MessageBox.Show("Phopto Sended ....");
            }
        }

        private async void btnSentImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string imagePath = op.FileName;

            var media = new InstaImageUpload()
            {
                Height = 1080,
                Width = 1080,
                Uri = imagePath
            };
            media.UserTags.Add(new InstaUserTagUpload()
            {
                Username = "iman_madaeny",
                X = 0.5,
                Y = 0.5
            });
            var res = await ctx.api.MediaProcessor
                .UploadPhotoAsync(media, txtCaption.Text);
            if (res.Succeeded)
            {
                txtCaption.Text = "";
                MessageBox.Show("Done .");
            }
        }

        private async void btnSendVideo_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "select video";
            string formats = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                             " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";

            op.Filter = formats;
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Image";
            opImage.Filter= "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;

            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo(videoUri, 0, 0),
                VideoThumbnail = new InstaImage(imageUri, 0, 0)
            };
            video.UserTags.Add(new InstaUserTagUpload()
            {
                Username = "iman_madaeny"
            });
            var res = await ctx.api.MediaProcessor
                .UploadVideoAsync(video, txtCaption.Text);
            if (res.Succeeded)
            {
                MessageBox.Show("Done");
            }
        }
    }
}
