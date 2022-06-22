using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingCat
{
    public class SettingsModel
    {
        public SettingsModel()
        {

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemeberMe { get; set; }
        public bool AutoLogin { get; set; } = false;
        public bool AppTopMost { get; set; } = false;

    }
}
