using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class FormFactory
    {
        private static FormProfile s_FormProfile;
        private static FormMatchLove s_FormMatchLove;
        private static FormPotentialLove s_FormPotentialLove;

        public static FormLogin FormLogin { get; set; }

        public static void Create(eFormType i_FormType, ArrayList i_Arguments)
        {
            switch (i_FormType)
            {
                case eFormType.FormLogin:
                    {
                        FormLogin = new FormLogin();
                        FormLogin.OpenForm += GeneralForm_formOpen;
                        break;
                    }

                case eFormType.FormProfile:
                    {
                        if(s_FormProfile == null)
                        {
                            s_FormProfile = new FormProfile();
                            s_FormProfile.OpenForm += GeneralForm_formOpen;
                        }

                        s_FormProfile.Show();
                        break;
                    }

                case eFormType.FormMatchLove:
                    {
                        if(s_FormMatchLove == null)
                        {
                            s_FormMatchLove = new FormMatchLove();
                            s_FormMatchLove.OpenForm += GeneralForm_formOpen;
                        }

                        s_FormMatchLove.Show();

                        break;
                    }

                case eFormType.FormPotentialLove:
                    {
                        if(s_FormPotentialLove == null)
                        {
                            s_FormPotentialLove = new FormPotentialLove(i_Arguments);
                            s_FormPotentialLove.OpenForm += GeneralForm_formOpen;
                        }

                        s_FormPotentialLove.Show();
                        break;
                    }
            }
        }

        internal static void GeneralForm_formOpen(eFormType i_FormType, ArrayList i_Arguments)
        {
            Create(i_FormType, i_Arguments);
        }
    }
}
