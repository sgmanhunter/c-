using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Database;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;

namespace ProjectGroep01.Controller
{
    class ControllerMain
    {
        private static ControllerMain controllerInstantion = new ControllerMain();
        private bool isLoggedIn;
        private int userid;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public static ControllerMain ControllerInstantion
        {
            get { return controllerInstantion; }
            set { controllerInstantion = value; }
        }

        public void GrpBoxPicker(GroupBox g1, GroupBox g2)
        {
            if (isLoggedIn)
            {
                g1.Visible = true;
                g2.Visible = false;
            }
            else
            {
                g1.Visible = false;
                g2.Visible = true;
            }
        }
        private void Reset(TextBox t1, TextBox t2)
        {
            t1.Text = "";
            t2.Text = "";
        }

        public void ClickLogin(TextBox tuser, TextBox tpas, ErrorProvider ep, GroupBox glogged, GroupBox glog)
        {
            string username = tuser.Text.ToLower();
            string password = tpas.Text;
            bool ok = false;
            int index = 1;
            for (int i = 0; i < Users.UserInstantion.Count; i++)
            {
                if (Users.UserInstantion[i].Username == username)
                {
                    ok = true;
                    index = i;
                    ep.SetError(tuser, "");
                    break;
                }
                else
                    ep.SetError(tuser, "Gebruikersnaam bestaat niet");
            }
            if (ok && Users.UserInstantion[index].Password == password)
            {
                IsLoggedIn = true;
                ep.SetError(tpas, "");
                Userid = Users.UserInstantion[index].Userid;
            }
            else
                ep.SetError(tpas, "Uw wachtwoord klopt niet");
            GrpBoxPicker(glogged, glog);
            Reset(tuser, tpas);
        }
    }
}
