namespace BotInstagram
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletePic = new System.Windows.Forms.Button();
            this.btnNewPic = new System.Windows.Forms.Button();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFollowers = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFollowing = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUnBlock = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnUnFollow = new System.Windows.Forms.Button();
            this.btnUserFollow = new System.Windows.Forms.Button();
            this.txtUser_UserName = new System.Windows.Forms.TextBox();
            this.btnBlockUsers = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstBlockUsers = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDirectUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnShoPost = new System.Windows.Forms.Button();
            this.txtUserNameForPosts = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnStoryPhoto = new System.Windows.Forms.Button();
            this.btnStoryVideo = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSendVideo = new System.Windows.Forms.Button();
            this.btnSentImage = new System.Windows.Forms.Button();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowing)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(182, 133);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "حساب کاربری";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "CorInsta123";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "course.barnamenevisan@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName or Email :";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnActivities);
            this.gbCommand.Controls.Add(this.btnEditProfile);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(747, 12);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(225, 133);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "دستورات";
            // 
            // btnActivities
            // 
            this.btnActivities.Location = new System.Drawing.Point(11, 17);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(101, 23);
            this.btnActivities.TabIndex = 1;
            this.btnActivities.Text = "رخداد های اخیر";
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(117, 18);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(101, 23);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "ویرایش پروفایل";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletePic);
            this.groupBox1.Controls.Add(this.btnNewPic);
            this.groupBox1.Controls.Add(this.pcImage);
            this.groupBox1.Location = new System.Drawing.Point(710, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر پروفایل";
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Location = new System.Drawing.Point(48, 197);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(101, 23);
            this.btnDeletePic.TabIndex = 2;
            this.btnDeletePic.Text = "حذف تصویر پروفایل";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // btnNewPic
            // 
            this.btnNewPic.Location = new System.Drawing.Point(155, 197);
            this.btnNewPic.Name = "btnNewPic";
            this.btnNewPic.Size = new System.Drawing.Size(101, 23);
            this.btnNewPic.TabIndex = 1;
            this.btnNewPic.Text = "تصویر جدید";
            this.btnNewPic.UseVisualStyleBackColor = true;
            this.btnNewPic.Click += new System.EventHandler(this.btnNewPic_Click);
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(6, 20);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(249, 171);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFollowers);
            this.groupBox2.Controls.Add(this.btnFollowers);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 580);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Followers";
            // 
            // dgvFollowers
            // 
            this.dgvFollowers.AllowUserToAddRows = false;
            this.dgvFollowers.AllowUserToDeleteRows = false;
            this.dgvFollowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName});
            this.dgvFollowers.Location = new System.Drawing.Point(7, 49);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.ReadOnly = true;
            this.dgvFollowers.Size = new System.Drawing.Size(224, 517);
            this.dgvFollowers.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // btnFollowers
            // 
            this.btnFollowers.Location = new System.Drawing.Point(7, 20);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(224, 23);
            this.btnFollowers.TabIndex = 5;
            this.btnFollowers.Text = "Show Followers";
            this.btnFollowers.UseVisualStyleBackColor = true;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFollowing);
            this.groupBox3.Controls.Add(this.btnFollowing);
            this.groupBox3.Location = new System.Drawing.Point(255, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 580);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Followers";
            // 
            // dgvFollowing
            // 
            this.dgvFollowing.AllowUserToAddRows = false;
            this.dgvFollowing.AllowUserToDeleteRows = false;
            this.dgvFollowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvFollowing.Location = new System.Drawing.Point(7, 49);
            this.dgvFollowing.Name = "dgvFollowing";
            this.dgvFollowing.ReadOnly = true;
            this.dgvFollowing.Size = new System.Drawing.Size(224, 517);
            this.dgvFollowing.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(7, 20);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(224, 23);
            this.btnFollowing.TabIndex = 5;
            this.btnFollowing.Text = "Show Followings";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUnBlock);
            this.groupBox4.Controls.Add(this.btnBlock);
            this.groupBox4.Controls.Add(this.btnUnFollow);
            this.groupBox4.Controls.Add(this.btnUserFollow);
            this.groupBox4.Controls.Add(this.txtUser_UserName);
            this.groupBox4.Location = new System.Drawing.Point(200, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 133);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Follow / Unfollow";
            // 
            // btnUnBlock
            // 
            this.btnUnBlock.Location = new System.Drawing.Point(6, 76);
            this.btnUnBlock.Name = "btnUnBlock";
            this.btnUnBlock.Size = new System.Drawing.Size(137, 23);
            this.btnUnBlock.TabIndex = 4;
            this.btnUnBlock.Text = "Un Block";
            this.btnUnBlock.UseVisualStyleBackColor = true;
            this.btnUnBlock.Click += new System.EventHandler(this.btnUnBlock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(149, 76);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(137, 23);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.Location = new System.Drawing.Point(6, 47);
            this.btnUnFollow.Name = "btnUnFollow";
            this.btnUnFollow.Size = new System.Drawing.Size(137, 23);
            this.btnUnFollow.TabIndex = 2;
            this.btnUnFollow.Text = "Un Follow";
            this.btnUnFollow.UseVisualStyleBackColor = true;
            this.btnUnFollow.Click += new System.EventHandler(this.btnUnFollow_Click);
            // 
            // btnUserFollow
            // 
            this.btnUserFollow.Location = new System.Drawing.Point(149, 47);
            this.btnUserFollow.Name = "btnUserFollow";
            this.btnUserFollow.Size = new System.Drawing.Size(137, 23);
            this.btnUserFollow.TabIndex = 1;
            this.btnUserFollow.Text = "Follow";
            this.btnUserFollow.UseVisualStyleBackColor = true;
            this.btnUserFollow.Click += new System.EventHandler(this.btnUserFollow_Click);
            // 
            // txtUser_UserName
            // 
            this.txtUser_UserName.Location = new System.Drawing.Point(6, 20);
            this.txtUser_UserName.Name = "txtUser_UserName";
            this.txtUser_UserName.Size = new System.Drawing.Size(280, 21);
            this.txtUser_UserName.TabIndex = 0;
            // 
            // btnBlockUsers
            // 
            this.btnBlockUsers.Location = new System.Drawing.Point(6, 20);
            this.btnBlockUsers.Name = "btnBlockUsers";
            this.btnBlockUsers.Size = new System.Drawing.Size(194, 23);
            this.btnBlockUsers.TabIndex = 3;
            this.btnBlockUsers.Text = "Block Users";
            this.btnBlockUsers.UseVisualStyleBackColor = true;
            this.btnBlockUsers.Click += new System.EventHandler(this.btnBlockUsers_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstBlockUsers);
            this.groupBox5.Controls.Add(this.btnBlockUsers);
            this.groupBox5.Location = new System.Drawing.Point(498, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 229);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "کاربران مسدود شده";
            // 
            // lstBlockUsers
            // 
            this.lstBlockUsers.FormattingEnabled = true;
            this.lstBlockUsers.Location = new System.Drawing.Point(6, 49);
            this.lstBlockUsers.Name = "lstBlockUsers";
            this.lstBlockUsers.Size = new System.Drawing.Size(194, 173);
            this.lstBlockUsers.TabIndex = 4;
            this.lstBlockUsers.SelectedIndexChanged += new System.EventHandler(this.lstBlockUsers_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnVideo);
            this.groupBox6.Controls.Add(this.btnSendImage);
            this.groupBox6.Controls.Add(this.btnSend);
            this.groupBox6.Controls.Add(this.txtMessage);
            this.groupBox6.Controls.Add(this.txtDirectUserName);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(498, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(474, 184);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ارسال پیام خصوصی";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(6, 141);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(144, 23);
            this.btnVideo.TabIndex = 8;
            this.btnVideo.Text = "Send Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(156, 141);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(139, 23);
            this.btnSendImage.TabIndex = 7;
            this.btnSendImage.Text = "Send Image";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(298, 141);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(167, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 57);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(459, 78);
            this.txtMessage.TabIndex = 6;
            // 
            // txtDirectUserName
            // 
            this.txtDirectUserName.Location = new System.Drawing.Point(128, 30);
            this.txtDirectUserName.Name = "txtDirectUserName";
            this.txtDirectUserName.Size = new System.Drawing.Size(280, 21);
            this.txtDirectUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام کاربری : ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnShoPost);
            this.groupBox7.Controls.Add(this.txtUserNameForPosts);
            this.groupBox7.Location = new System.Drawing.Point(501, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 54);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "نمایش پست ها";
            // 
            // btnShoPost
            // 
            this.btnShoPost.Location = new System.Drawing.Point(6, 18);
            this.btnShoPost.Name = "btnShoPost";
            this.btnShoPost.Size = new System.Drawing.Size(84, 23);
            this.btnShoPost.TabIndex = 2;
            this.btnShoPost.Text = "Show";
            this.btnShoPost.UseVisualStyleBackColor = true;
            this.btnShoPost.Click += new System.EventHandler(this.btnShoPost_Click);
            // 
            // txtUserNameForPosts
            // 
            this.txtUserNameForPosts.Location = new System.Drawing.Point(96, 20);
            this.txtUserNameForPosts.Name = "txtUserNameForPosts";
            this.txtUserNameForPosts.Size = new System.Drawing.Size(138, 21);
            this.txtUserNameForPosts.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnStoryPhoto);
            this.groupBox8.Controls.Add(this.btnStoryVideo);
            this.groupBox8.Location = new System.Drawing.Point(501, 72);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(240, 54);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Story";
            // 
            // btnStoryPhoto
            // 
            this.btnStoryPhoto.Location = new System.Drawing.Point(125, 16);
            this.btnStoryPhoto.Name = "btnStoryPhoto";
            this.btnStoryPhoto.Size = new System.Drawing.Size(109, 23);
            this.btnStoryPhoto.TabIndex = 3;
            this.btnStoryPhoto.Text = "Photo";
            this.btnStoryPhoto.UseVisualStyleBackColor = true;
            this.btnStoryPhoto.Click += new System.EventHandler(this.btnStoryPhoto_Click);
            // 
            // btnStoryVideo
            // 
            this.btnStoryVideo.Location = new System.Drawing.Point(6, 16);
            this.btnStoryVideo.Name = "btnStoryVideo";
            this.btnStoryVideo.Size = new System.Drawing.Size(113, 23);
            this.btnStoryVideo.TabIndex = 2;
            this.btnStoryVideo.Text = "Video";
            this.btnStoryVideo.UseVisualStyleBackColor = true;
            this.btnStoryVideo.Click += new System.EventHandler(this.btnStoryVideo_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSendVideo);
            this.groupBox9.Controls.Add(this.btnSentImage);
            this.groupBox9.Controls.Add(this.txtCaption);
            this.groupBox9.Location = new System.Drawing.Point(498, 590);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(474, 141);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Upload Image / Video";
            // 
            // btnSendVideo
            // 
            this.btnSendVideo.Location = new System.Drawing.Point(6, 104);
            this.btnSendVideo.Name = "btnSendVideo";
            this.btnSendVideo.Size = new System.Drawing.Size(144, 23);
            this.btnSendVideo.TabIndex = 8;
            this.btnSendVideo.Text = "Send Video";
            this.btnSendVideo.UseVisualStyleBackColor = true;
            this.btnSendVideo.Click += new System.EventHandler(this.btnSendVideo_Click);
            // 
            // btnSentImage
            // 
            this.btnSentImage.Location = new System.Drawing.Point(156, 104);
            this.btnSentImage.Name = "btnSentImage";
            this.btnSentImage.Size = new System.Drawing.Size(139, 23);
            this.btnSentImage.TabIndex = 7;
            this.btnSentImage.Text = "Send Image";
            this.btnSentImage.UseVisualStyleBackColor = true;
            this.btnSentImage.Click += new System.EventHandler(this.btnSentImage_Click);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(6, 20);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(459, 78);
            this.txtCaption.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 742);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ریات هوشمند من";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowing)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Button btnDeletePic;
        private System.Windows.Forms.Button btnNewPic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.DataGridView dgvFollowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvFollowing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUnFollow;
        private System.Windows.Forms.Button btnUserFollow;
        private System.Windows.Forms.TextBox txtUser_UserName;
        private System.Windows.Forms.Button btnBlockUsers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstBlockUsers;
        private System.Windows.Forms.Button btnUnBlock;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDirectUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnShoPost;
        private System.Windows.Forms.TextBox txtUserNameForPosts;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnStoryPhoto;
        private System.Windows.Forms.Button btnStoryVideo;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnSendVideo;
        private System.Windows.Forms.Button btnSentImage;
        private System.Windows.Forms.TextBox txtCaption;
    }
}

