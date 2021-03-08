using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
	public class ProfileLogic
	{
		private const int k_CountOfPhotosInCollage = 4;
		private Photo[] m_UserMostLikelyPhotos = new Photo[k_CountOfPhotosInCollage];

		internal bool CheckIfNoFriendsToUser(User i_LoggedInUser)
		{
			return i_LoggedInUser.Friends.Count == 0;
		}

		internal bool CheckIfNoPostsToUser(User i_LoggedInUser)
		{
			return i_LoggedInUser.Posts.Count == 0;
		}

		internal bool CheckIfNoAlbumsToUser(User i_LoggedInUser)
		{
			return i_LoggedInUser.Albums.Count == 0;
		}

		internal bool CheckIfUserIsNotSingle(User i_LoggedInUser)
		{
			return (i_LoggedInUser.RelationshipStatus == User.eRelationshipStatus.InARelationship) || (i_LoggedInUser.RelationshipStatus == User.eRelationshipStatus.Married);
		}

		public Photo[] UserMostLikelyPhotos
		{
			get { return m_UserMostLikelyPhotos; }
		}

		internal void FindMostLikelyPhotos(User i_LoggedInUser, int i_IndexOfSelectedAlbum)
		{
			int indexOfLessLikelyPhotoFromArray = 0;
			int valueOfLessLikelyPhotoFromArray = 0;
			for (int i = 0; i < k_CountOfPhotosInCollage; i++)
			{
				m_UserMostLikelyPhotos[i] = i_LoggedInUser.Albums[i_IndexOfSelectedAlbum].Photos[i];
			}

			indexOfLessLikelyPhotoFromArray = FindLessLikelyPhotoFromArray();
			valueOfLessLikelyPhotoFromArray = m_UserMostLikelyPhotos[indexOfLessLikelyPhotoFromArray].LikedBy.Count;
			foreach (Photo photo in i_LoggedInUser.Albums[i_IndexOfSelectedAlbum].Photos)
			{
				if (photo.LikedBy.Count > valueOfLessLikelyPhotoFromArray)
				{
					m_UserMostLikelyPhotos[indexOfLessLikelyPhotoFromArray] = photo;
					indexOfLessLikelyPhotoFromArray = FindLessLikelyPhotoFromArray();
					valueOfLessLikelyPhotoFromArray = m_UserMostLikelyPhotos[indexOfLessLikelyPhotoFromArray].LikedBy.Count;
				}
			}
		}

		internal int FindLessLikelyPhotoFromArray()
		{
			int valueOfLessLikelyPhotoFromArray = m_UserMostLikelyPhotos[0].LikedBy.Count;
			int indexOfLessLikelyPhotoFromArray = 0;
			foreach (Photo photo in m_UserMostLikelyPhotos)
			{
				if (photo.LikedBy.Count <= valueOfLessLikelyPhotoFromArray)
				{
					valueOfLessLikelyPhotoFromArray = photo.LikedBy.Count;
					indexOfLessLikelyPhotoFromArray = Array.IndexOf(m_UserMostLikelyPhotos, photo);
				}
			}

			return indexOfLessLikelyPhotoFromArray;
		}

		internal void InitializationArray()
		{
			int indexOfcurrentPhoto = 0;
			foreach (Photo photo in m_UserMostLikelyPhotos)
			{
				indexOfcurrentPhoto = Array.IndexOf(m_UserMostLikelyPhotos, photo);
				m_UserMostLikelyPhotos[indexOfcurrentPhoto] = null;
			}
		}

		internal bool CheckIfNoPhotosInSelectedAlbum(AlbumProxy i_SelectedAlbum)
		{
			return i_SelectedAlbum.Album.Photos.Count == 0;
		}

		internal bool CheckValidNumberOfPhotosInSelectedAlbum(AlbumProxy i_SelectedAlbum)
		{
			return i_SelectedAlbum.Album.Photos.Count < k_CountOfPhotosInCollage;
		}
	}
}
