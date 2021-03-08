using System;
using System.Linq;
using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public partial class FormProfile
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label labelEditPost;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControlFormProfile = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.panelEditPost = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelSearchLove = new System.Windows.Forms.Panel();
            this.labelMatchLove = new System.Windows.Forms.Label();
            this.buttonMatchLove = new System.Windows.Forms.Button();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.labelDescriptionSelectedAlbum = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelAlboms = new System.Windows.Forms.Label();
            this.panelAddPost = new System.Windows.Forms.Panel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxAddPost = new System.Windows.Forms.TextBox();
            this.pictureBoxAddPost = new System.Windows.Forms.PictureBox();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.labelFriendsCount = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelIntro = new System.Windows.Forms.Label();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.pictureBoxBD = new System.Windows.Forms.PictureBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.pictureBoxGender = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tabPagTopMoments = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonApplyMomenets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddMoment = new System.Windows.Forms.TextBox();
            this.listBoxAddMoment = new System.Windows.Forms.ListBox();
            this.buttonAddMoment = new System.Windows.Forms.Button();
            this.panelPhotoDetails = new System.Windows.Forms.Panel();
            this.labelUploadDate = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelCountLikes = new System.Windows.Forms.Label();
            this.pictureBoxLike = new System.Windows.Forms.PictureBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelCountComments = new System.Windows.Forms.Label();
            this.comboBoxChooseAlbum = new System.Windows.Forms.ComboBox();
            this.buttonCreateCollage = new System.Windows.Forms.Button();
            this.panelTopPhotos = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto3 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            labelEditPost = new System.Windows.Forms.Label();
            this.tabControlFormProfile.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.panelEditPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelSearchLove.SuspendLayout();
            this.panelAlbums.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.panelAddPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPost)).BeginInit();
            this.panelPosts.SuspendLayout();
            this.panelFriends.SuspendLayout();
            this.panelPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelIntro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).BeginInit();
            this.tabPagTopMoments.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPhotoDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).BeginInit();
            this.panelTopPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel.Location = new System.Drawing.Point(3, 44);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel.Location = new System.Drawing.Point(3, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // labelEditPost
            // 
            labelEditPost.AutoSize = true;
            labelEditPost.BackColor = System.Drawing.Color.Transparent;
            labelEditPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelEditPost.Location = new System.Drawing.Point(3, 13);
            labelEditPost.Name = "labelEditPost";
            labelEditPost.Size = new System.Drawing.Size(125, 20);
            labelEditPost.TabIndex = 3;
            labelEditPost.Text = "Edit your post:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControlFormProfile
            // 
            this.tabControlFormProfile.Controls.Add(this.tabPageProfile);
            this.tabControlFormProfile.Controls.Add(this.tabPagTopMoments);
            this.tabControlFormProfile.Location = new System.Drawing.Point(-1, -3);
            this.tabControlFormProfile.Name = "tabControlFormProfile";
            this.tabControlFormProfile.SelectedIndex = 0;
            this.tabControlFormProfile.Size = new System.Drawing.Size(1104, 731);
            this.tabControlFormProfile.TabIndex = 21;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.AutoScroll = true;
            this.tabPageProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageProfile.BackgroundImage")));
            this.tabPageProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageProfile.Controls.Add(this.panelEditPost);
            this.tabPageProfile.Controls.Add(this.buttonLogOut);
            this.tabPageProfile.Controls.Add(this.panelSearchLove);
            this.tabPageProfile.Controls.Add(this.panelAlbums);
            this.tabPageProfile.Controls.Add(this.panelAddPost);
            this.tabPageProfile.Controls.Add(this.panelPosts);
            this.tabPageProfile.Controls.Add(this.panelFriends);
            this.tabPageProfile.Controls.Add(this.panelPhotos);
            this.tabPageProfile.Controls.Add(this.panelIntro);
            this.tabPageProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 29);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1096, 698);
            this.tabPageProfile.TabIndex = 1;
            this.tabPageProfile.Text = "Profile";
            // 
            // panelEditPost
            // 
            this.panelEditPost.BackColor = System.Drawing.Color.Transparent;
            this.panelEditPost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEditPost.Controls.Add(labelEditPost);
            this.panelEditPost.Controls.Add(this.messageTextBox);
            this.panelEditPost.Location = new System.Drawing.Point(780, 486);
            this.panelEditPost.Name = "panelEditPost";
            this.panelEditPost.Size = new System.Drawing.Size(276, 137);
            this.panelEditPost.TabIndex = 29;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(7, 41);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(262, 86);
            this.messageTextBox.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.AutoSize = true;
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(6, 15);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(174, 36);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelSearchLove
            // 
            this.panelSearchLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSearchLove.BackgroundImage")));
            this.panelSearchLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSearchLove.Controls.Add(this.labelMatchLove);
            this.panelSearchLove.Controls.Add(this.buttonMatchLove);
            this.panelSearchLove.Location = new System.Drawing.Point(555, 482);
            this.panelSearchLove.Name = "panelSearchLove";
            this.panelSearchLove.Size = new System.Drawing.Size(202, 141);
            this.panelSearchLove.TabIndex = 28;
            // 
            // labelMatchLove
            // 
            this.labelMatchLove.AutoSize = true;
            this.labelMatchLove.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelMatchLove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMatchLove.ForeColor = System.Drawing.Color.Black;
            this.labelMatchLove.Location = new System.Drawing.Point(5, 37);
            this.labelMatchLove.Name = "labelMatchLove";
            this.labelMatchLove.Size = new System.Drawing.Size(192, 29);
            this.labelMatchLove.TabIndex = 18;
            this.labelMatchLove.Text = "Are you single?";
            // 
            // buttonMatchLove
            // 
            this.buttonMatchLove.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonMatchLove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMatchLove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMatchLove.ForeColor = System.Drawing.Color.Black;
            this.buttonMatchLove.Location = new System.Drawing.Point(12, 73);
            this.buttonMatchLove.Name = "buttonMatchLove";
            this.buttonMatchLove.Size = new System.Drawing.Size(178, 37);
            this.buttonMatchLove.TabIndex = 19;
            this.buttonMatchLove.Text = "Click here ;)";
            this.buttonMatchLove.UseVisualStyleBackColor = false;
            this.buttonMatchLove.Click += new System.EventHandler(this.buttonMatchLove_Click);
            // 
            // panelAlbums
            // 
            this.panelAlbums.BackColor = System.Drawing.Color.Transparent;
            this.panelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAlbums.Controls.Add(this.panel1);
            this.panelAlbums.Controls.Add(this.labelDescriptionSelectedAlbum);
            this.panelAlbums.Controls.Add(this.listBoxAlbums);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbum);
            this.panelAlbums.Controls.Add(this.labelAlboms);
            this.panelAlbums.Location = new System.Drawing.Point(293, 82);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(464, 386);
            this.panelAlbums.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(158, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 128);
            this.panel1.TabIndex = 29;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 44);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(158, 72);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(114, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nameTextBox.Size = new System.Drawing.Size(158, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // labelDescriptionSelectedAlbum
            // 
            this.labelDescriptionSelectedAlbum.AutoSize = true;
            this.labelDescriptionSelectedAlbum.Location = new System.Drawing.Point(6, 350);
            this.labelDescriptionSelectedAlbum.Name = "labelDescriptionSelectedAlbum";
            this.labelDescriptionSelectedAlbum.Size = new System.Drawing.Size(0, 20);
            this.labelDescriptionSelectedAlbum.TabIndex = 18;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBoxAlbums.ForeColor = System.Drawing.Color.Black;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.HorizontalScrollbar = true;
            this.listBoxAlbums.ItemHeight = 24;
            this.listBoxAlbums.Location = new System.Drawing.Point(1, 56);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(274, 148);
            this.listBoxAlbums.TabIndex = 17;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(3, 210);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(141, 128);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 16;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelAlboms
            // 
            this.labelAlboms.AutoSize = true;
            this.labelAlboms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlboms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAlboms.Location = new System.Drawing.Point(3, 7);
            this.labelAlboms.Name = "labelAlboms";
            this.labelAlboms.Size = new System.Drawing.Size(131, 37);
            this.labelAlboms.TabIndex = 15;
            this.labelAlboms.Text = "Albums";
            // 
            // panelAddPost
            // 
            this.panelAddPost.Controls.Add(this.buttonPost);
            this.panelAddPost.Controls.Add(this.textBoxAddPost);
            this.panelAddPost.Controls.Add(this.pictureBoxAddPost);
            this.panelAddPost.Location = new System.Drawing.Point(532, 15);
            this.panelAddPost.Name = "panelAddPost";
            this.panelAddPost.Size = new System.Drawing.Size(529, 56);
            this.panelAddPost.TabIndex = 26;
            // 
            // buttonPost
            // 
            this.buttonPost.AutoSize = true;
            this.buttonPost.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonPost.ForeColor = System.Drawing.Color.Black;
            this.buttonPost.Location = new System.Drawing.Point(438, 8);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(89, 36);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxAddPost
            // 
            this.textBoxAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAddPost.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddPost.Location = new System.Drawing.Point(61, 8);
            this.textBoxAddPost.Name = "textBoxAddPost";
            this.textBoxAddPost.Size = new System.Drawing.Size(358, 35);
            this.textBoxAddPost.TabIndex = 3;
            this.textBoxAddPost.Text = "What\'s on your mind? ";
            this.textBoxAddPost.TextChanged += new System.EventHandler(this.textBoxAddPost_Click);
            // 
            // pictureBoxAddPost
            // 
            this.pictureBoxAddPost.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxAddPost.Location = new System.Drawing.Point(5, 3);
            this.pictureBoxAddPost.Name = "pictureBoxAddPost";
            this.pictureBoxAddPost.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxAddPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddPost.TabIndex = 2;
            this.pictureBoxAddPost.TabStop = false;
            // 
            // panelPosts
            // 
            this.panelPosts.BackColor = System.Drawing.Color.Transparent;
            this.panelPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPosts.Controls.Add(this.labelPosts);
            this.panelPosts.Controls.Add(this.listBoxPosts);
            this.panelPosts.Location = new System.Drawing.Point(775, 82);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(286, 386);
            this.panelPosts.TabIndex = 25;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosts.Location = new System.Drawing.Point(3, 7);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(102, 37);
            this.labelPosts.TabIndex = 15;
            this.labelPosts.Text = "Posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(3, 56);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(276, 292);
            this.listBoxPosts.TabIndex = 13;
            // 
            // panelFriends
            // 
            this.panelFriends.BackColor = System.Drawing.Color.Transparent;
            this.panelFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFriends.Controls.Add(this.labelFriendsCount);
            this.panelFriends.Controls.Add(this.labelFriends);
            this.panelFriends.Controls.Add(this.listBoxFriends);
            this.panelFriends.Location = new System.Drawing.Point(293, 482);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(256, 141);
            this.panelFriends.TabIndex = 24;
            // 
            // labelFriendsCount
            // 
            this.labelFriendsCount.AutoSize = true;
            this.labelFriendsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFriendsCount.Location = new System.Drawing.Point(3, 39);
            this.labelFriendsCount.Name = "labelFriendsCount";
            this.labelFriendsCount.Size = new System.Drawing.Size(64, 25);
            this.labelFriendsCount.TabIndex = 16;
            this.labelFriendsCount.Text = "label1";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(1, 2);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(131, 37);
            this.labelFriends.TabIndex = 15;
            this.labelFriends.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(5, 67);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(241, 64);
            this.listBoxFriends.TabIndex = 13;
            // 
            // panelPhotos
            // 
            this.panelPhotos.BackColor = System.Drawing.Color.Transparent;
            this.panelPhotos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPhotos.BackgroundImage")));
            this.panelPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPhotos.Controls.Add(this.labelLastName);
            this.panelPhotos.Controls.Add(this.labelFirstName);
            this.panelPhotos.Controls.Add(this.pictureBoxProfile);
            this.panelPhotos.Location = new System.Drawing.Point(11, 82);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(234, 263);
            this.panelPhotos.TabIndex = 23;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastName.Location = new System.Drawing.Point(109, 3);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(106, 37);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "label1";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstName.Location = new System.Drawing.Point(1, 3);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(106, 37);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "label1";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxProfile.Location = new System.Drawing.Point(13, 45);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 211);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIntro.Controls.Add(this.pictureBoxEmail);
            this.panelIntro.Controls.Add(this.labelLocation);
            this.panelIntro.Controls.Add(this.labelIntro);
            this.panelIntro.Controls.Add(this.pictureBoxLocation);
            this.panelIntro.Controls.Add(this.pictureBoxBD);
            this.panelIntro.Controls.Add(this.labelGender);
            this.panelIntro.Controls.Add(this.labelBD);
            this.panelIntro.Controls.Add(this.pictureBoxGender);
            this.panelIntro.Controls.Add(this.labelEmail);
            this.panelIntro.Location = new System.Drawing.Point(7, 366);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(271, 257);
            this.panelIntro.TabIndex = 22;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmail.Image")));
            this.pictureBoxEmail.Location = new System.Drawing.Point(3, 102);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(37, 41);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 5;
            this.pictureBoxEmail.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelLocation.Location = new System.Drawing.Point(47, 209);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(64, 25);
            this.labelLocation.TabIndex = 10;
            this.labelLocation.Text = "label1";
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelIntro.ForeColor = System.Drawing.Color.Black;
            this.labelIntro.Location = new System.Drawing.Point(6, 7);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(86, 37);
            this.labelIntro.TabIndex = 2;
            this.labelIntro.Text = "Intro";
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocation.Image")));
            this.pictureBoxLocation.Location = new System.Drawing.Point(4, 202);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(37, 41);
            this.pictureBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocation.TabIndex = 9;
            this.pictureBoxLocation.TabStop = false;
            // 
            // pictureBoxBD
            // 
            this.pictureBoxBD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBD.Image")));
            this.pictureBoxBD.Location = new System.Drawing.Point(3, 54);
            this.pictureBoxBD.Name = "pictureBoxBD";
            this.pictureBoxBD.Size = new System.Drawing.Size(37, 41);
            this.pictureBoxBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBD.TabIndex = 3;
            this.pictureBoxBD.TabStop = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelGender.Location = new System.Drawing.Point(47, 162);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 25);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "label1";
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBD.Location = new System.Drawing.Point(48, 63);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(64, 25);
            this.labelBD.TabIndex = 4;
            this.labelBD.Text = "label1";
            // 
            // pictureBoxGender
            // 
            this.pictureBoxGender.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGender.Image")));
            this.pictureBoxGender.Location = new System.Drawing.Point(4, 153);
            this.pictureBoxGender.Name = "pictureBoxGender";
            this.pictureBoxGender.Size = new System.Drawing.Size(37, 41);
            this.pictureBoxGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGender.TabIndex = 7;
            this.pictureBoxGender.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmail.Location = new System.Drawing.Point(47, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "label1";
            // 
            // tabPagTopMoments
            // 
            this.tabPagTopMoments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagTopMoments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagTopMoments.BackgroundImage")));
            this.tabPagTopMoments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagTopMoments.Controls.Add(this.panel2);
            this.tabPagTopMoments.Controls.Add(this.panelPhotoDetails);
            this.tabPagTopMoments.Controls.Add(this.comboBoxChooseAlbum);
            this.tabPagTopMoments.Controls.Add(this.buttonCreateCollage);
            this.tabPagTopMoments.Controls.Add(this.panelTopPhotos);
            this.tabPagTopMoments.Controls.Add(this.labelHeader);
            this.tabPagTopMoments.Location = new System.Drawing.Point(4, 29);
            this.tabPagTopMoments.Name = "tabPagTopMoments";
            this.tabPagTopMoments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagTopMoments.Size = new System.Drawing.Size(1096, 698);
            this.tabPagTopMoments.TabIndex = 2;
            this.tabPagTopMoments.Text = "My Top Moments";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonApplyMomenets);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxAddMoment);
            this.panel2.Controls.Add(this.listBoxAddMoment);
            this.panel2.Controls.Add(this.buttonAddMoment);
            this.panel2.Location = new System.Drawing.Point(720, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 400);
            this.panel2.TabIndex = 17;
            // 
            // buttonApplyMomenets
            // 
            this.buttonApplyMomenets.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyMomenets.Location = new System.Drawing.Point(90, 123);
            this.buttonApplyMomenets.Name = "buttonApplyMomenets";
            this.buttonApplyMomenets.Size = new System.Drawing.Size(121, 41);
            this.buttonApplyMomenets.TabIndex = 18;
            this.buttonApplyMomenets.Text = "Apply all";
            this.buttonApplyMomenets.UseVisualStyleBackColor = true;
            this.buttonApplyMomenets.Click += new System.EventHandler(this.buttonApplyMomenets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add some moments";
            // 
            // textBoxAddMoment
            // 
            this.textBoxAddMoment.Location = new System.Drawing.Point(85, 69);
            this.textBoxAddMoment.Name = "textBoxAddMoment";
            this.textBoxAddMoment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxAddMoment.Size = new System.Drawing.Size(191, 26);
            this.textBoxAddMoment.TabIndex = 14;
            this.textBoxAddMoment.Text = "Write about a moment...";
            this.textBoxAddMoment.TextChanged += new System.EventHandler(this.textBoxAddMoment_TextChanged);
            // 
            // listBoxAddMoment
            // 
            this.listBoxAddMoment.FormattingEnabled = true;
            this.listBoxAddMoment.HorizontalScrollbar = true;
            this.listBoxAddMoment.ItemHeight = 20;
            this.listBoxAddMoment.Location = new System.Drawing.Point(11, 170);
            this.listBoxAddMoment.Name = "listBoxAddMoment";
            this.listBoxAddMoment.Size = new System.Drawing.Size(263, 204);
            this.listBoxAddMoment.TabIndex = 16;
            // 
            // buttonAddMoment
            // 
            this.buttonAddMoment.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMoment.Location = new System.Drawing.Point(11, 66);
            this.buttonAddMoment.Name = "buttonAddMoment";
            this.buttonAddMoment.Size = new System.Drawing.Size(67, 32);
            this.buttonAddMoment.TabIndex = 15;
            this.buttonAddMoment.Text = "Add";
            this.buttonAddMoment.UseVisualStyleBackColor = true;
            this.buttonAddMoment.Click += new System.EventHandler(this.buttonAddMoment_Click);
            // 
            // panelPhotoDetails
            // 
            this.panelPhotoDetails.Controls.Add(this.labelUploadDate);
            this.panelPhotoDetails.Controls.Add(this.listBoxComments);
            this.panelPhotoDetails.Controls.Add(this.labelCountLikes);
            this.panelPhotoDetails.Controls.Add(this.pictureBoxLike);
            this.panelPhotoDetails.Controls.Add(this.labelComments);
            this.panelPhotoDetails.Controls.Add(this.labelCountComments);
            this.panelPhotoDetails.Location = new System.Drawing.Point(445, 97);
            this.panelPhotoDetails.Name = "panelPhotoDetails";
            this.panelPhotoDetails.Size = new System.Drawing.Size(255, 319);
            this.panelPhotoDetails.TabIndex = 13;
            this.panelPhotoDetails.Visible = false;
            // 
            // labelUploadDate
            // 
            this.labelUploadDate.AutoSize = true;
            this.labelUploadDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelUploadDate.Location = new System.Drawing.Point(3, 7);
            this.labelUploadDate.Name = "labelUploadDate";
            this.labelUploadDate.Size = new System.Drawing.Size(64, 24);
            this.labelUploadDate.TabIndex = 8;
            this.labelUploadDate.Text = "label1";
            // 
            // listBoxComments
            // 
            this.listBoxComments.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.HorizontalScrollbar = true;
            this.listBoxComments.ItemHeight = 24;
            this.listBoxComments.Location = new System.Drawing.Point(3, 129);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(241, 172);
            this.listBoxComments.TabIndex = 7;
            // 
            // labelCountLikes
            // 
            this.labelCountLikes.AutoSize = true;
            this.labelCountLikes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelCountLikes.Location = new System.Drawing.Point(43, 51);
            this.labelCountLikes.Name = "labelCountLikes";
            this.labelCountLikes.Size = new System.Drawing.Size(64, 24);
            this.labelCountLikes.TabIndex = 6;
            this.labelCountLikes.Text = "label1";
            // 
            // pictureBoxLike
            // 
            this.pictureBoxLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLike.BackgroundImage")));
            this.pictureBoxLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLike.Location = new System.Drawing.Point(7, 45);
            this.pictureBoxLike.Name = "pictureBoxLike";
            this.pictureBoxLike.Size = new System.Drawing.Size(36, 38);
            this.pictureBoxLike.TabIndex = 5;
            this.pictureBoxLike.TabStop = false;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelComments.Location = new System.Drawing.Point(64, 95);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(105, 24);
            this.labelComments.TabIndex = 4;
            this.labelComments.Text = "Comments";
            // 
            // labelCountComments
            // 
            this.labelCountComments.AutoSize = true;
            this.labelCountComments.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelCountComments.Location = new System.Drawing.Point(3, 95);
            this.labelCountComments.Name = "labelCountComments";
            this.labelCountComments.Size = new System.Drawing.Size(64, 24);
            this.labelCountComments.TabIndex = 3;
            this.labelCountComments.Text = "label1";
            // 
            // comboBoxChooseAlbum
            // 
            this.comboBoxChooseAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxChooseAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseAlbum.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxChooseAlbum.FormattingEnabled = true;
            this.comboBoxChooseAlbum.Location = new System.Drawing.Point(22, 37);
            this.comboBoxChooseAlbum.Name = "comboBoxChooseAlbum";
            this.comboBoxChooseAlbum.Size = new System.Drawing.Size(314, 32);
            this.comboBoxChooseAlbum.TabIndex = 12;
            this.comboBoxChooseAlbum.Text = "Choose";
            // 
            // buttonCreateCollage
            // 
            this.buttonCreateCollage.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateCollage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateCollage.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCollage.Location = new System.Drawing.Point(19, 545);
            this.buttonCreateCollage.Name = "buttonCreateCollage";
            this.buttonCreateCollage.Size = new System.Drawing.Size(155, 59);
            this.buttonCreateCollage.TabIndex = 7;
            this.buttonCreateCollage.Text = "Create collage";
            this.buttonCreateCollage.UseVisualStyleBackColor = false;
            this.buttonCreateCollage.Click += new System.EventHandler(this.buttonCreateCollage_Click);
            // 
            // panelTopPhotos
            // 
            this.panelTopPhotos.BackColor = System.Drawing.Color.Transparent;
            this.panelTopPhotos.Controls.Add(this.pictureBoxPhoto1);
            this.panelTopPhotos.Controls.Add(this.pictureBoxPhoto2);
            this.panelTopPhotos.Controls.Add(this.pictureBoxPhoto4);
            this.panelTopPhotos.Controls.Add(this.pictureBoxPhoto3);
            this.panelTopPhotos.Location = new System.Drawing.Point(19, 97);
            this.panelTopPhotos.Name = "panelTopPhotos";
            this.panelTopPhotos.Size = new System.Drawing.Size(420, 442);
            this.panelTopPhotos.TabIndex = 6;
            // 
            // pictureBoxPhoto1
            // 
            this.pictureBoxPhoto1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto1.Enabled = false;
            this.pictureBoxPhoto1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPhoto1.Name = "pictureBoxPhoto1";
            this.pictureBoxPhoto1.Size = new System.Drawing.Size(200, 210);
            this.pictureBoxPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto1.TabIndex = 5;
            this.pictureBoxPhoto1.TabStop = false;
            this.pictureBoxPhoto1.Click += new System.EventHandler(this.pictureBoxPhoto1_Click);
            // 
            // pictureBoxPhoto2
            // 
            this.pictureBoxPhoto2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto2.Enabled = false;
            this.pictureBoxPhoto2.Location = new System.Drawing.Point(207, 3);
            this.pictureBoxPhoto2.Name = "pictureBoxPhoto2";
            this.pictureBoxPhoto2.Size = new System.Drawing.Size(200, 210);
            this.pictureBoxPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto2.TabIndex = 2;
            this.pictureBoxPhoto2.TabStop = false;
            this.pictureBoxPhoto2.Click += new System.EventHandler(this.pictureBoxPhoto2_Click);
            // 
            // pictureBoxPhoto4
            // 
            this.pictureBoxPhoto4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto4.Enabled = false;
            this.pictureBoxPhoto4.Location = new System.Drawing.Point(207, 218);
            this.pictureBoxPhoto4.Name = "pictureBoxPhoto4";
            this.pictureBoxPhoto4.Size = new System.Drawing.Size(200, 210);
            this.pictureBoxPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto4.TabIndex = 4;
            this.pictureBoxPhoto4.TabStop = false;
            this.pictureBoxPhoto4.Click += new System.EventHandler(this.pictureBoxPhoto4_Click);
            // 
            // pictureBoxPhoto3
            // 
            this.pictureBoxPhoto3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto3.Enabled = false;
            this.pictureBoxPhoto3.Location = new System.Drawing.Point(3, 218);
            this.pictureBoxPhoto3.Name = "pictureBoxPhoto3";
            this.pictureBoxPhoto3.Size = new System.Drawing.Size(200, 210);
            this.pictureBoxPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto3.TabIndex = 3;
            this.pictureBoxPhoto3.TabStop = false;
            this.pictureBoxPhoto3.Click += new System.EventHandler(this.pictureBoxPhoto3_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeader.Font = new System.Drawing.Font("Bradley Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.Black;
            this.labelHeader.Location = new System.Drawing.Point(401, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(328, 50);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "My Top Moments";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 728);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlFormProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfile";
            this.Text = "The new FB";
            this.tabControlFormProfile.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.panelEditPost.ResumeLayout(false);
            this.panelEditPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelSearchLove.ResumeLayout(false);
            this.panelSearchLove.PerformLayout();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.panelAddPost.ResumeLayout(false);
            this.panelAddPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPost)).EndInit();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.panelFriends.ResumeLayout(false);
            this.panelFriends.PerformLayout();
            this.panelPhotos.ResumeLayout(false);
            this.panelPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).EndInit();
            this.tabPagTopMoments.ResumeLayout(false);
            this.tabPagTopMoments.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPhotoDetails.ResumeLayout(false);
            this.panelPhotoDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).EndInit();
            this.panelTopPhotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private TabControl tabControlFormProfile;
        private TabPage tabPageProfile;
        private Panel panelSearchLove;
        private Label labelMatchLove;
        private Button buttonMatchLove;
        private Panel panelAlbums;
        private PictureBox pictureBoxAlbum;
        private Label labelAlboms;
        private Panel panelAddPost;
        private Button buttonPost;
        private TextBox textBoxAddPost;
        private PictureBox pictureBoxAddPost;
        private Panel panelPosts;
        private Label labelPosts;
        private ListBox listBoxPosts;
        private Panel panelFriends;
        private Label labelFriendsCount;
        private Label labelFriends;
        private ListBox listBoxFriends;
        private Panel panelPhotos;
        private Label labelLastName;
        private Label labelFirstName;
        private PictureBox pictureBoxProfile;
        private Panel panelIntro;
        private PictureBox pictureBoxEmail;
        private Label labelLocation;
        private Label labelIntro;
        private PictureBox pictureBoxLocation;
        private PictureBox pictureBoxBD;
        private Label labelGender;
        private Label labelBD;
        private PictureBox pictureBoxGender;
        private Label labelEmail;
        private TabPage tabPagTopMoments;
        private Label labelHeader;
        private PictureBox pictureBoxPhoto1;
        private PictureBox pictureBoxPhoto4;
        private PictureBox pictureBoxPhoto3;
        private PictureBox pictureBoxPhoto2;
        private Panel panelTopPhotos;
        private Button buttonCreateCollage;
        private ListBox listBoxAlbums;
        private ComboBox comboBoxChooseAlbum;
        private Panel panelPhotoDetails;
        private ListBox listBoxComments;
        private Label labelCountLikes;
        private PictureBox pictureBoxLike;
        private Label labelComments;
        private Label labelCountComments;
        private Label labelUploadDate;
        private Button buttonLogOut;
        private BindingSource albumBindingSource;
        private Panel panel1;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private Label labelDescriptionSelectedAlbum;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        private Panel panelEditPost;
        private BindingSource postBindingSource;
        private TextBox messageTextBox;
        private Panel panel2;
        private Label label1;
        private TextBox textBoxAddMoment;
        private ListBox listBoxAddMoment;
        private Button buttonAddMoment;
        private Button buttonApplyMomenets;
    }
}