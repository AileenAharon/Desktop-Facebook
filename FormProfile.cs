using System.Threading;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
	public partial class FormProfile : OpeningGeneralForm
	{
		private const string k_DefultOfTextBoxAddPost = "What's on your mind?";
		private const string k_TextBoxMomentDefult = "Write about a moment...";
		private readonly ProfileLogic r_ProfileLogic = new ProfileLogic();
		private bool m_FirstClickTextBoxAddPost = true;
		private bool m_FirstClickTextBoxMoment = true;
		private Moments m_Moments = new Moments();

		public FormProfile()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			populateUIFacebookData();
			populateUITopMoments();
		}

		private void populateUIFacebookData()
		{
			new Thread(fetchUserProfile).Start();
			new Thread(fetchUserIntro).Start();
			new Thread(fetchUserPosts).Start();
			new Thread(fetchUserFriends).Start();
			new Thread(fetchUserAlbums).Start();
		}

		private void populateUITopMoments()
		{
			fetchUserAlbumsForTopMoments();
		}

		private void fetchUserProfile()
		{
			labelFirstName.Invoke(new Action(() => this.labelFirstName.Text = ActiveUser.CurrentActiveUser.FirstName));
			labelLastName.Invoke(new Action(() => this.labelLastName.Text = ActiveUser.CurrentActiveUser.LastName));
			pictureBoxProfile.Invoke(new Action(() => this.pictureBoxProfile.LoadAsync(ActiveUser.CurrentActiveUser.PictureNormalURL)));
		}

		private void fetchUserIntro()
		{
			labelBD.Invoke(new Action(() => this.labelBD.Text = ActiveUser.CurrentActiveUser.Birthday.ToString()));
			labelEmail.Invoke(new Action(() => this.labelEmail.Text = ActiveUser.CurrentActiveUser.Email));
			labelGender.Invoke(new Action(() => this.labelGender.Text = ActiveUser.CurrentActiveUser.Gender.ToString()));
			labelLocation.Invoke(new Action(() => this.labelLocation.Text = ActiveUser.CurrentActiveUser.Location.Name));
		}

		private void fetchUserFriends()
		{
			labelFriendsCount.Invoke(new Action(() => this.labelFriendsCount.Text = ActiveUser.CurrentActiveUser.Friends.Count.ToString()));
			listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
			listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
			foreach (User friend in ActiveUser.CurrentActiveUser.Friends)
			{
				listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
			}

			if (r_ProfileLogic.CheckIfNoFriendsToUser(ActiveUser.CurrentActiveUser))
			{
				MessageBox.Show("No Friends to retrieve :(");
			}
		}

		private void fetchUserPosts()
		{
			pictureBoxAddPost.Invoke(new Action(() => this.pictureBoxAddPost.LoadAsync(ActiveUser.CurrentActiveUser.PictureNormalURL)));

			if (r_ProfileLogic.CheckIfNoPostsToUser(ActiveUser.CurrentActiveUser))
			{
				MessageBox.Show("No Posts to retrieve :(");
			}

			listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = ActiveUser.CurrentActiveUser.Posts));
		}

		private void buttonPost_Click(object sender, EventArgs e)
		{
			addPost();
		}

		private void addPost()
		{
			if (!string.IsNullOrEmpty(textBoxAddPost.Text))
			{
				try
				{
					Status postedStatus = ActiveUser.CurrentActiveUser.PostStatus(textBoxAddPost.Text);
					MessageBox.Show("Status Posted!" + postedStatus.ToString());
					listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(postedStatus.Message)));
					m_FirstClickTextBoxAddPost = true;
					this.textBoxAddPost.Text = k_DefultOfTextBoxAddPost;
				}
				catch (Exception)
				{
					MessageBox.Show("Unable to upload post, Exception caught", "Error");
				}
			}
			else
			{
				MessageBox.Show("Please fill in your post status", "Missing Details");
			}
		}

		private void textBoxAddPost_Click(object sender, EventArgs e)
		{
			if (m_FirstClickTextBoxAddPost)
			{
				this.textBoxAddPost.Text = string.Empty;
				m_FirstClickTextBoxAddPost = false;
			}
		}

		private void fetchUserAlbums()
		{
			if (r_ProfileLogic.CheckIfNoAlbumsToUser(ActiveUser.CurrentActiveUser))
			{
				MessageBox.Show("No Albums to retrieve :(");
			}

			listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = ActiveUser.CurrentActiveUser.Albums));
		}

		private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
		{
			displaySelectedAlbum();
		}

		private void displaySelectedAlbum()
		{
			try
			{
				if (listBoxAlbums.SelectedItems.Count == 1)
				{
					Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
					this.labelDescriptionSelectedAlbum.Text = selectedAlbum.Description;
					if (selectedAlbum.PictureAlbumURL != null)
					{
						pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
					}
					else
					{
						pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonMatchLove_Click(object sender, EventArgs e)
		{
			if (r_ProfileLogic.CheckIfUserIsNotSingle(ActiveUser.CurrentActiveUser))
			{
				MessageBox.Show("You are in a relationship!" + Environment.NewLine + "It's not cool!");
			}
			else
			{
				eFormType formType = eFormType.FormMatchLove;
				this.Hide();
				OnFormOpen(formType, new ArrayList());
			}
		}

		private void fetchUserAlbumsForTopMoments()
		{
			comboBoxChooseAlbum.Items.Clear();
			foreach (Album album in ActiveUser.CurrentActiveUser.Albums)
			{
				comboBoxChooseAlbum.Items.Add(new AlbumProxy { Album = album });
			}

			if (r_ProfileLogic.CheckIfNoAlbumsToUser(ActiveUser.CurrentActiveUser))
			{
				MessageBox.Show("No Albums to retrieve :(");
			}
		}

		private void displayMostLikelyPhotos()
		{
			int indexOfSelectedAlbum = this.comboBoxChooseAlbum.SelectedIndex;
			r_ProfileLogic.FindMostLikelyPhotos(ActiveUser.CurrentActiveUser, indexOfSelectedAlbum);
			DisplayMostLikelyPhotos displayMostLikelyPhotos = new DisplayMostLikelyPhotos(r_ProfileLogic, panelTopPhotos, new FirstPhoto());
			new Thread(displayMostLikelyPhotos.displayPhoto).Start();

			displayMostLikelyPhotos = new DisplayMostLikelyPhotos(r_ProfileLogic, panelTopPhotos, new SecondPhoto());
			new Thread(displayMostLikelyPhotos.displayPhoto).Start();

			displayMostLikelyPhotos = new DisplayMostLikelyPhotos(r_ProfileLogic, panelTopPhotos, new ThirdPhoto());
			new Thread(displayMostLikelyPhotos.displayPhoto).Start();

			displayMostLikelyPhotos = new DisplayMostLikelyPhotos(r_ProfileLogic, panelTopPhotos, new FourthPhoto());
			new Thread(displayMostLikelyPhotos.displayPhoto).Start();
		}

		private void buttonCreateCollage_Click(object sender, EventArgs e)
		{
			AlbumProxy selectedAlbum = this.comboBoxChooseAlbum.SelectedItem as AlbumProxy;
			if (r_ProfileLogic.CheckIfNoPhotosInSelectedAlbum(selectedAlbum))
			{
				MessageBox.Show("The selected album is empty" + Environment.NewLine + "Choose another album");
			}
			else if (r_ProfileLogic.CheckValidNumberOfPhotosInSelectedAlbum(selectedAlbum))
			{
				MessageBox.Show("There are less than 4 photos in the album" + Environment.NewLine + "Choose another album");
			}
			else
			{
				r_ProfileLogic.InitializationArray();
				displayMostLikelyPhotos();
			}

			foreach (PictureBox pb in this.panelTopPhotos.Controls)
			{
				pb.Enabled = true;
			}
		}

		private void fetchPictureDetails(int i_indexOfPhoto)
		{
			this.panelPhotoDetails.Visible = true;
			Photo selectedPhoto = r_ProfileLogic.UserMostLikelyPhotos[i_indexOfPhoto];

			listBoxComments.Items.Clear();

			foreach (Comment comment in selectedPhoto.Comments)
			{
				listBoxComments.Items.Add(comment.Message);
			}

			this.labelCountComments.Text = selectedPhoto.Comments.Count.ToString();
			this.labelCountLikes.Text = selectedPhoto.LikedBy.Count.ToString();
			this.labelUploadDate.Text = selectedPhoto.CreatedTime.ToString();
		}

		private void pictureBoxPhoto1_Click(object sender, EventArgs e)
		{
			fetchPictureDetails(0);
		}

		private void pictureBoxPhoto2_Click(object sender, EventArgs e)
		{
			fetchPictureDetails(1);
		}

		private void pictureBoxPhoto3_Click(object sender, EventArgs e)
		{
			fetchPictureDetails(2);
		}

		private void pictureBoxPhoto4_Click(object sender, EventArgs e)
		{
			fetchPictureDetails(3);
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			string message = "Are you sure you want to log out?";
			string caption = "WARNING";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult shouldLogout = MessageBox.Show(message, caption, buttons);
			if (shouldLogout == DialogResult.Yes)
			{
				try
				{
					FacebookWrapper.FacebookService.Logout(new Action(this.Close));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void buttonAddMoment_Click(object sender, EventArgs e)
		{
			m_Moments.AddMoment(this.textBoxAddMoment.Text);
			textBoxAddMoment.Text = k_TextBoxMomentDefult;
			m_FirstClickTextBoxMoment = true;
		}

		private void buttonApplyMomenets_Click(object sender, EventArgs e)
		{
			foreach (string moment in m_Moments)
			{
				listBoxAddMoment.Items.Add(moment);
			}

			m_Moments.Initialization();
		}

		private void textBoxAddMoment_TextChanged(object sender, EventArgs e)
		{
			if (m_FirstClickTextBoxMoment)
			{
				this.textBoxAddMoment.Text = string.Empty;
				m_FirstClickTextBoxMoment = false;
			}
		}
	}
}
