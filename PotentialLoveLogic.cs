using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class PotentialLoveLogic
    {
		private string m_MatchGender;
		private int m_MinAge;
		private int m_MaxAge;
		private bool m_FromSameCity;
		private bool m_FromSameCollege;

		public PotentialLoveLogic(string i_MatchGender, int i_MinAge, int i_MaxAge, bool i_FromSameCity, bool i_FromSameCollege)
		{
			m_MatchGender = i_MatchGender;
			m_MinAge = i_MinAge;
			m_MaxAge = i_MaxAge;
			m_FromSameCity = i_FromSameCity;
			m_FromSameCollege = i_FromSameCollege;
		}

		internal bool CheckIfFriendIsMatch(User i_LoggedInUser, User i_Friend)
		{
			int ageOfFriend = GetAgeFromBirthday(i_Friend.Birthday);
			bool theFriendIsMatch = false;
			 Page FriendLastCollege = i_Friend.Educations[0].School;
			 Page UserLastCollege = i_LoggedInUser.Educations[0].School;
			if ((i_Friend.RelationshipStatus != User.eRelationshipStatus.InARelationship) && (i_Friend.RelationshipStatus != User.eRelationshipStatus.Married))
			{
				if (i_Friend.Gender.Value.ToString().Equals(m_MatchGender) && (ageOfFriend >= m_MinAge && ageOfFriend <= m_MaxAge))
				{
					if (m_FromSameCity)
					{
						if (i_Friend.Location.Name.Equals(i_LoggedInUser.Location.Name))
						{
										if (m_FromSameCollege)
										{
											if (FriendLastCollege.Equals(UserLastCollege))
											{
												theFriendIsMatch = true;
											}
										}
							else
							{
								theFriendIsMatch = true;
							}
						}
					}
					else
					{
						if (m_FromSameCollege)
						{
								if (FriendLastCollege.Equals(UserLastCollege))
								{
									theFriendIsMatch = true;
								}
						}
						else
						{
							theFriendIsMatch = true;
						}
					}
				}
			}

			return theFriendIsMatch;
		}

		internal int GetAgeFromBirthday(string i_FriendBirthday)
		{
			string yearBirthday = i_FriendBirthday.Substring(i_FriendBirthday.Length - 4);
			int age = DateTime.Now.Year - int.Parse(yearBirthday);
			return age;
		}
	}
}
