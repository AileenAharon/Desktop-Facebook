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
	public partial class FormPotentialLove : OpeningGeneralForm
	{
		private const int k_NumberOfArguments = 5;
		private readonly PotentialLoveLogic r_PotentialLoveLogic;
		private readonly FormMatchLove r_FormMatchLove;

		public FormPotentialLove(ArrayList i_UserPreferences)
		{
			InitializeComponent();
			r_PotentialLoveLogic = initialPotentialLoveLogicField(i_UserPreferences);
			r_FormMatchLove = (FormMatchLove)i_UserPreferences[k_NumberOfArguments];
			buttonBackToProfile.Text = ActiveUser.CurrentActiveUser.FirstName;
			fetchUserMatches();
		}

		private PotentialLoveLogic initialPotentialLoveLogicField(ArrayList i_UserPreferences)
		{
			string matchGender = i_UserPreferences[0].ToString();
			int minAge = (int)i_UserPreferences[1];
			int maxAge = (int)i_UserPreferences[2];
			bool fromSameCity = (bool)i_UserPreferences[3];
			bool fromSameCollege = (bool)i_UserPreferences[4];
			return new PotentialLoveLogic(matchGender, minAge, maxAge, fromSameCity, fromSameCollege);
		}

		private void fetchUserMatches()
		{
			listBoxMatches.Items.Clear();
			listBoxMatches.DisplayMember = "Name";

			foreach (User friend in ActiveUser.CurrentActiveUser.Friends)
			{
				if (r_PotentialLoveLogic.CheckIfFriendIsMatch(ActiveUser.CurrentActiveUser, friend) == true)
				{
					listBoxMatches.Items.Add(friend);
				}
			}

			if (listBoxMatches.Items.Count == 0)
			{
				MessageBox.Show("No matches to retrieve :(");
			}
			else
			{
				r_FormMatchLove.Hide();
				this.Show();
			}
		}

		private void displaySelectedMatch()
		{
			int ageSelectedFriend = 0;
			User selectedMatch;
			if (listBoxMatches.SelectedItems.Count == 1)
			{
				selectedMatch = listBoxMatches.SelectedItem as User;
				if (selectedMatch.PictureNormalURL != null)
				{
					pictureBoxMatch.LoadAsync(selectedMatch.PictureNormalURL);
				}
				else
				{
					pictureBoxMatch.Image = pictureBoxMatch.ErrorImage;
				}

				ageSelectedFriend = r_PotentialLoveLogic.GetAgeFromBirthday(selectedMatch.Birthday);
				this.labelAge.Text = ageSelectedFriend.ToString();
				this.labelEmail.Text = selectedMatch.Email;
				this.labelAge.Visible = true;
				this.labelEmail.Visible = true;
			}
		}

		private void buttonBackToProfile_Click(object sender, EventArgs e)
		{
			buttonBackToProfile.Text = ActiveUser.CurrentActiveUser.FirstName;
			this.Hide();
			eFormType formType = eFormType.FormProfile;
			OnFormOpen(formType, new ArrayList());
		}

		private void buttonDefineAgain_Click(object sender, EventArgs e)
		{
			this.Hide();
			r_FormMatchLove.Show();
		}

		private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
		{
			displaySelectedMatch();
		}
    }
}