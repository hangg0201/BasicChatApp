using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class video : UserControl
    {

        bool clicked = false;
        public video()
        {
            InitializeComponent();
        }

        public void content(string s)
        {
            playerVideo.URL = s;
            playerVideo.Ctlcontrols.stop();
        }

        private void playerVideo_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (!clicked)
            {
                clicked = true;
                playerVideo.Ctlcontrols.play();
            }else
            {
                playerVideo.Ctlcontrols.pause();
                clicked = false;
            }
        }
    }
}
