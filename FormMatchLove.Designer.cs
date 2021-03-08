using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public partial class FormMatchLove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatchLove));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSubHeader = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxSameCity = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.groupBoxFromSameCollege = new System.Windows.Forms.GroupBox();
            this.radioButtonNoCollege = new System.Windows.Forms.RadioButton();
            this.radioButtonYesCollege = new System.Windows.Forms.RadioButton();
            this.buttonSearchLove = new System.Windows.Forms.Button();
            this.buttonBackToProfile = new System.Windows.Forms.Button();
            this.panelDoubleComboBox = new A21_Ex03_Dana_208992321_Aileen_205834161.PanelForAgeRangeWithComboBoxes();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxSameCity.SuspendLayout();
            this.groupBoxFromSameCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Crimson;
            this.labelHeader.Font = new System.Drawing.Font("Bradley Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.labelHeader.Location = new System.Drawing.Point(278, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(352, 50);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "It\'s time to love <3";
            // 
            // labelSubHeader
            // 
            this.labelSubHeader.AutoSize = true;
            this.labelSubHeader.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelSubHeader.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelSubHeader.ForeColor = System.Drawing.Color.Black;
            this.labelSubHeader.Location = new System.Drawing.Point(12, 98);
            this.labelSubHeader.Name = "labelSubHeader";
            this.labelSubHeader.Size = new System.Drawing.Size(365, 34);
            this.labelSubHeader.TabIndex = 1;
            this.labelSubHeader.Text = "Describe us your true love...";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBoxGender.ForeColor = System.Drawing.Color.Black;
            this.groupBoxGender.Location = new System.Drawing.Point(12, 167);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(155, 100);
            this.groupBoxGender.TabIndex = 10;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Interested in:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 57);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(79, 28);
            this.radioButtonMale.TabIndex = 11;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 25);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(96, 28);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxSameCity
            // 
            this.groupBoxSameCity.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxSameCity.Controls.Add(this.radioButtonNo);
            this.groupBoxSameCity.Controls.Add(this.radioButtonYes);
            this.groupBoxSameCity.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBoxSameCity.ForeColor = System.Drawing.Color.Black;
            this.groupBoxSameCity.Location = new System.Drawing.Point(449, 167);
            this.groupBoxSameCity.Name = "groupBoxSameCity";
            this.groupBoxSameCity.Size = new System.Drawing.Size(199, 100);
            this.groupBoxSameCity.TabIndex = 13;
            this.groupBoxSameCity.TabStop = false;
            this.groupBoxSameCity.Text = "From your city?";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNo.Location = new System.Drawing.Point(6, 57);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(132, 28);
            this.radioButtonNo.TabIndex = 11;
            this.radioButtonNo.Text = "Not matter";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 25);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(67, 28);
            this.radioButtonYes.TabIndex = 10;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxFromSameCollege
            // 
            this.groupBoxFromSameCollege.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxFromSameCollege.Controls.Add(this.radioButtonNoCollege);
            this.groupBoxFromSameCollege.Controls.Add(this.radioButtonYesCollege);
            this.groupBoxFromSameCollege.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBoxFromSameCollege.ForeColor = System.Drawing.Color.Black;
            this.groupBoxFromSameCollege.Location = new System.Drawing.Point(685, 167);
            this.groupBoxFromSameCollege.Name = "groupBoxFromSameCollege";
            this.groupBoxFromSameCollege.Size = new System.Drawing.Size(209, 100);
            this.groupBoxFromSameCollege.TabIndex = 14;
            this.groupBoxFromSameCollege.TabStop = false;
            this.groupBoxFromSameCollege.Text = "From your college?";
            // 
            // radioButtonNoCollege
            // 
            this.radioButtonNoCollege.AutoSize = true;
            this.radioButtonNoCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNoCollege.Location = new System.Drawing.Point(6, 57);
            this.radioButtonNoCollege.Name = "radioButtonNoCollege";
            this.radioButtonNoCollege.Size = new System.Drawing.Size(132, 28);
            this.radioButtonNoCollege.TabIndex = 11;
            this.radioButtonNoCollege.Text = "Not matter";
            this.radioButtonNoCollege.UseVisualStyleBackColor = true;
            // 
            // radioButtonYesCollege
            // 
            this.radioButtonYesCollege.AutoSize = true;
            this.radioButtonYesCollege.Checked = true;
            this.radioButtonYesCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYesCollege.Location = new System.Drawing.Point(6, 25);
            this.radioButtonYesCollege.Name = "radioButtonYesCollege";
            this.radioButtonYesCollege.Size = new System.Drawing.Size(67, 28);
            this.radioButtonYesCollege.TabIndex = 10;
            this.radioButtonYesCollege.TabStop = true;
            this.radioButtonYesCollege.Text = "Yes";
            this.radioButtonYesCollege.UseVisualStyleBackColor = true;
            // 
            // buttonSearchLove
            // 
            this.buttonSearchLove.BackColor = System.Drawing.Color.Crimson;
            this.buttonSearchLove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchLove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonSearchLove.FlatAppearance.BorderSize = 3;
            this.buttonSearchLove.Font = new System.Drawing.Font("Bradley Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            this.buttonSearchLove.Location = new System.Drawing.Point(332, 336);
            this.buttonSearchLove.Name = "buttonSearchLove";
            this.buttonSearchLove.Size = new System.Drawing.Size(251, 94);
            this.buttonSearchLove.TabIndex = 15;
            this.buttonSearchLove.Text = "Search love";
            this.buttonSearchLove.UseVisualStyleBackColor = false;
            this.buttonSearchLove.Click += new System.EventHandler(this.buttonSearchLove_Click);
            // 
            // buttonBackToProfile
            // 
            this.buttonBackToProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToProfile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonBackToProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonBackToProfile.Location = new System.Drawing.Point(789, 20);
            this.buttonBackToProfile.Name = "buttonBackToProfile";
            this.buttonBackToProfile.Size = new System.Drawing.Size(105, 53);
            this.buttonBackToProfile.TabIndex = 17;
            this.buttonBackToProfile.Text = "button1";
            this.buttonBackToProfile.UseVisualStyleBackColor = true;
            this.buttonBackToProfile.Click += new System.EventHandler(this.buttonBackToProfile_Click);
            // 
            // panelDoubleComboBox
            // 
            this.panelDoubleComboBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelDoubleComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelDoubleComboBox.Location = new System.Drawing.Point(208, 167);
            this.panelDoubleComboBox.Name = "panelDoubleComboBox";
            this.panelDoubleComboBox.Size = new System.Drawing.Size(200, 100);
            this.panelDoubleComboBox.TabIndex = 18;
            // 
            // FormMatchLove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 584);
            this.ControlBox = false;
            this.Controls.Add(this.panelDoubleComboBox);
            this.Controls.Add(this.buttonBackToProfile);
            this.Controls.Add(this.buttonSearchLove);
            this.Controls.Add(this.groupBoxFromSameCollege);
            this.Controls.Add(this.groupBoxSameCity);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.labelSubHeader);
            this.Controls.Add(this.labelHeader);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatchLove";
            this.Text = "The new FB";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxSameCity.ResumeLayout(false);
            this.groupBoxSameCity.PerformLayout();
            this.groupBoxFromSameCollege.ResumeLayout(false);
            this.groupBoxFromSameCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSubHeader;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private GroupBox groupBoxSameCity;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private GroupBox groupBoxFromSameCollege;
        private RadioButton radioButtonNoCollege;
        private RadioButton radioButtonYesCollege;
        private Button buttonSearchLove;
        private Button buttonBackToProfile;
        private PanelForAgeRangeWithComboBoxes panelDoubleComboBox;
    }
}