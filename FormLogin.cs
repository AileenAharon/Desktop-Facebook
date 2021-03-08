using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
	public partial class FormLogin : OpeningGeneralForm
	{
		private LoginResult m_LoginResult;
		
		public FormLogin()
		{
			InitializeComponent();
			FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
		}

		public void LoginAndInit()
		{
			string appID = "706413963321809";
			if (m_LoginResult == null)
			{
				try
				{
					m_LoginResult = FacebookService.Login(
						appID,
						"public_profile",
						"email",
						"publish_to_groups",
						"user_birthday",
						"user_age_range",
						"user_gender",
						"user_link",
						"user_tagged_places",
						"user_videos",
						"publish_to_groups",
						"groups_access_member_info",
						"user_friends",
						"user_events",
						"user_likes",
						"user_location",
						"user_photos",
						"user_posts",
						"user_hometown");

					if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
					{
						ActiveUser.CurrentActiveUser = m_LoginResult.LoggedInUser;
						eFormType formType = eFormType.FormProfile;
						this.Hide();
						OnFormOpen(formType, new ArrayList());
					}
					else
					{
						MessageBox.Show(m_LoginResult.ErrorMessage);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			LoginAndInit();
			this.Hide();
		}
	}
}
