using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroep01.Model.Events;

namespace ProjectGroep01.Model.People
{
    class User
    {
        #region datamembers
        private int userid;
        private string firstname;
        private string lastname;
        private string username;
        private string password;
        private DateTime dateOfBirth;
        private bool male;
        private string email;
        private List<ITEvent> events;
        #endregion

        #region properties
        public int Userid
        {       
            get
            {
                return userid;
            }
            private set
            {
                userid = value;
            }
        }
        public string Firstname
        {        
            get
            {
                return firstname;
            }
            private set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            private set
            {
                lastname = value;
            }
        }
        public string Username
        {
            get { return username; }
            private set { username = value; }
        }
        public string Password
        {
            get { return password; }
            private set { password = value; }
        }
        public DateTime DateOfBirth
        {      
            get
            {
                return dateOfBirth;
            }
            private set
            {
                dateOfBirth = value;
            }
        }
        public bool Male
        {    
            get
            {
                return male;
            }
            private set
            {
                male = value;
            }
        }
        public string Email
        {   
            get
            {
                return email;
            }
            private set
            {
                email = value;
            }
        }
        public List<ITEvent> Events
        {
            get
            {
                return events;
            }
            private set
            {
                events = value;
            }
        }
        #endregion

        #region constructors
        public User(string firstname, string lastname, string username, string password, DateTime dateOfBirth, bool male, string email, List<ITEvent> events)
        {
            Userid = Users.UserInstantion.CalculateNewUserid();
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            DateOfBirth = dateOfBirth;
            Male = male;
            Email = email;
            Events = events;
        }
        public User(string firstname, string lastname, string username, string password, DateTime dateOfBirth, bool male, string email)
            : this(firstname, lastname, username, password, dateOfBirth, male, email, new List<ITEvent>())
        {
        }
        #endregion

        #region overrides
        public override string ToString()
        {
            return String.Format("{0:d2} - {1} {2}", Userid, Lastname, Firstname);
        }
        #endregion
    }
}
