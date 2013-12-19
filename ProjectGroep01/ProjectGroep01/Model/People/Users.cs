using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroep01.Model.Events;

namespace ProjectGroep01.Model.People
{
    class Users:List<User>
    {
        #region datamembers
        private static Users userInstantion = new Users();
        private int currentUserid;
        #endregion

        #region properties
        public static Users UserInstantion
        {
            get { return userInstantion; }
            private set { userInstantion = value; }
        }
        #endregion

        #region constructor
        private Users()
        {
            currentUserid = 0;
        }
        #endregion

        #region methods
        public int CalculateNewUserid()
        {
            currentUserid++;
            return currentUserid;
        }
        #endregion

    }
}
