using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class Moments : IEnumerable<string>
    {
        private List<string> m_UserMoments;

        public Moments()
        {
            m_UserMoments = new List<string>();
        }

        public void Initialization()
        {
            m_UserMoments.Clear();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string moment in m_UserMoments)
            {
                yield return moment;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddMoment(string i_Moment)
        {
            m_UserMoments.Add(i_Moment);
        }
    }
}
