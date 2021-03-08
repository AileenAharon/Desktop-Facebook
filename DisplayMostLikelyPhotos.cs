using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class DisplayMostLikelyPhotos
    {
		private ICurrentIndex CurrentIndex { get; set; }

		private Panel PanelTopPhotos { get; set; }

		private ProfileLogic ProfileLogic { get; set; }

		public DisplayMostLikelyPhotos(ProfileLogic i_ProfileLogic, Panel i_panelTopPhotos, ICurrentIndex i_CurrentIndex)
		{
			CurrentIndex = i_CurrentIndex;
			PanelTopPhotos = i_panelTopPhotos;
			ProfileLogic = i_ProfileLogic;
		}

		internal void displayPhoto()
		{
			int i = CurrentIndex.getIndex();
			PictureBox pb = (PictureBox)PanelTopPhotos.Controls[i];
			pb.Invoke(new Action(() => pb.LoadAsync(ProfileLogic.UserMostLikelyPhotos[i].PictureNormalURL)));
		}
	}
}
