using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public partial class FormMatchLove : OpeningGeneralForm
    {
        private const int k_MinAge = 16;
        private const int k_MaxAge = 85;

        public FormMatchLove()
        {
            InitializeComponent();
            initialControls();
        }

        private void initialControls()
        {
            buttonBackToProfile.Text = ActiveUser.CurrentActiveUser.FirstName;
            this.panelDoubleComboBox.ComboBoxFromAge.DataSource = Enumerable.Range(k_MinAge, k_MaxAge).ToList();
            this.panelDoubleComboBox.ComboBoxToAge.DataSource = Enumerable.Range(k_MinAge, k_MaxAge).ToList();
            this.panelDoubleComboBox.ComboBoxFromAge.SelectedIndexChanged += new System.EventHandler(this.panelDoubleComboBox_SelectedIndexChanged);
        }

        private void buttonSearchLove_Click(object sender, EventArgs e)
        {
            string genderType = string.Empty;
            int selectedMinAge = 0;
            int selectedMaxAge = 0;
            bool fromSameCity = false;
            bool fromSameCollege = false;

            if (checkIfAgeRangeValid())
            {
                selectedMaxAge = int.Parse(this.panelDoubleComboBox.ComboBoxToAge.Text);
                selectedMinAge = int.Parse(this.panelDoubleComboBox.ComboBoxFromAge.Text);

                foreach (RadioButton radioButton in groupBoxGender.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked == true)
                    {
                        genderType = radioButton.Text;
                    }
                }

                if (radioButtonYes.Checked == true)
                {
                    fromSameCity = true;
                }

                if (radioButtonYesCollege.Checked == true)
                {
                    fromSameCollege = true;
                }

                ArrayList userPreferences = new ArrayList()
                {
                    genderType,
                    selectedMinAge,
                    selectedMaxAge,
                    fromSameCity,
                    fromSameCollege,
                    this
                };
                eFormType formType = eFormType.FormPotentialLove;
                this.Hide();
                OnFormOpen(formType, userPreferences);
            }
        }

        private bool checkIfAgeRangeValid()
        {
            bool isAgeRangeValid = false;
            if ((this.panelDoubleComboBox.ComboBoxFromAge.SelectedIndex == -1) && (this.panelDoubleComboBox.ComboBoxToAge.SelectedIndex == -1))
            {
                MessageBox.Show("No age range is selected");
            }
            else if (this.panelDoubleComboBox.ComboBoxFromAge.SelectedIndex == -1)
            {
                MessageBox.Show("No age from is selected");
            }
            else
            {
                isAgeRangeValid = true;
            }

            return isAgeRangeValid;
        }

        private void buttonBackToProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            eFormType formType = eFormType.FormProfile;
            OnFormOpen(formType, new ArrayList());
        }

        private void panelDoubleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = panelDoubleComboBox.ComboBoxFromAge.SelectedIndex;
            this.panelDoubleComboBox.ComboBoxFromAge.SelectedItem.ToString();
            int selectedValue = int.Parse(this.panelDoubleComboBox.ComboBoxFromAge.Items[selectedIndex].ToString());
            this.panelDoubleComboBox.ComboBoxToAge.DataSource = Enumerable.Range(selectedValue, k_MaxAge - selectedValue + 1).ToList();
        }
    }
}