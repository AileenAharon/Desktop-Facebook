using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public class AlbumProxy
    {
        public Album Album { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1} photos)", Album.Name, Album.Photos.Count);
        }
    }
}
