using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.Enums;

namespace BotInstagram
{
    public partial class frmEdiotProfile : Form
    {
        public frmEdiotProfile()
        {
            InitializeComponent();
        }

        private async void frmEdiotProfile_Load(object sender, EventArgs e)
        {
            var editProfile = await ctx.api.AccountProcessor.GetRequestForEditProfileAsync();
            if (editProfile.Succeeded)
            {
                txtBio.Text = editProfile.Value.Biography;
                txtEmail.Text = editProfile.Value.Email;
                txtMobile.Text = editProfile.Value.PhoneNumber;
                txtName.Text = editProfile.Value.FullName;
                txtSite.Text = editProfile.Value.ExternalUrl;
                txtUserName.Text = editProfile.Value.Username;
                if (editProfile.Value.Gender == InstaGenderType.Male)
                    rbMale.Checked = true;
                else
                {
                    rbFemale.Checked = true;
                }
            }
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var edit = await ctx.api.AccountProcessor
                .EditProfileAsync(txtName.Text, txtBio.Text,
                    txtSite.Text, txtEmail.Text, txtMobile.Text,
                    (rbMale.Checked) ? InstaGenderType.Male : InstaGenderType.Female,
                    txtUserName.Text);
            if (edit.Succeeded)
            {
                MessageBox.Show("با موفقیت انجام شد");
                this.Close();
            }
        }
    }
}
