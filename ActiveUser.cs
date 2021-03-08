using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class ActiveUser
    {
        private static readonly object sr_UserLockObject = new object();
        private static User s_CurrentActiveUser = null;

        public static User CurrentActiveUser
        {
            get
            {
                return s_CurrentActiveUser;
            }

            set
            {
                if (s_CurrentActiveUser == null)
                {
                    lock (sr_UserLockObject)
                    {
                        if (s_CurrentActiveUser == null)
                        {
                            s_CurrentActiveUser = value;
                        }
                    }
                }
                else
                {
                    throw new Exception("Don't create more than one instance of me!");
                }
            }
        }
    }
}
