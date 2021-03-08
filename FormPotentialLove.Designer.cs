namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public partial class FormPotentialLove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPotentialLove));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.pictureBoxMatch = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonBackToProfile = new System.Windows.Forms.Button();
            this.buttonDefineAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 31);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(383, 45);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Here are your matches:";
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxMatches.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 24;
            this.listBoxMatches.Location = new System.Drawing.Point(13, 94);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(310, 388);
            this.listBoxMatches.TabIndex = 1;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMatch.Location = new System.Drawing.Point(415, 128);
            this.pictureBoxMatch.Name = "pictureBoxMatch";
            this.pictureBoxMatch.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatch.TabIndex = 2;
            this.pictureBoxMatch.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(420, 353);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 24);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "label1";
            this.labelEmail.Visible = false;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelAge.Location = new System.Drawing.Point(420, 386);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(72, 24);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "label1";
            this.labelAge.Visible = false;
            // 
            // buttonBackToProfile
            // 
            this.buttonBackToProfile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonBackToProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonBackToProfile.Location = new System.Drawing.Point(569, 26);
            this.buttonBackToProfile.Name = "buttonBackToProfile";
            this.buttonBackToProfile.Size = new System.Drawing.Size(117, 50);
            this.buttonBackToProfile.TabIndex = 18;
            this.buttonBackToProfile.Text = "button1";
            this.buttonBackToProfile.UseVisualStyleBackColor = true;
            this.buttonBackToProfile.Click += new System.EventHandler(this.buttonBackToProfile_Click);
            // 
            // buttonDefineAgain
            // 
            this.buttonDefineAgain.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonDefineAgain.ForeColor = System.Drawing.Color.Black;
            this.buttonDefineAgain.Location = new System.Drawing.Point(465, 432);
            this.buttonDefineAgain.Name = "buttonDefineAgain";
            this.buttonDefineAgain.Size = new System.Drawing.Size(221, 50);
            this.buttonDefineAgain.TabIndex = 19;
            this.buttonDefineAgain.Text = "Back to resettings";
            this.buttonDefineAgain.UseVisualStyleBackColor = true;
            this.buttonDefineAgain.Click += new System.EventHandler(this.buttonDefineAgain_Click);
            // 
            // FormPotentialLove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 505);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDefineAgain);
            this.Controls.Add(this.buttonBackToProfile);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.pictureBoxMatch);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPotentialLove";
            this.Text = "The new FB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.PictureBox pictureBoxMatch;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonBackToProfile;
        private System.Windows.Forms.Button buttonDefineAgain;
    }
}