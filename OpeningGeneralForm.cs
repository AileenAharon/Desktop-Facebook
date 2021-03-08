using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public partial class OpeningGeneralForm : Form
    {
		public event Action<eFormType, ArrayList> OpenForm;

		protected virtual void OnFormOpen(eFormType i_FormType, ArrayList i_Arguments)
		{
			if (OpenForm != null)
			{
				OpenForm.Invoke(i_FormType, i_Arguments); // call everyone who listen - in the factory FormMatchLove_formOpen is listening
			}
		}
	}
}
