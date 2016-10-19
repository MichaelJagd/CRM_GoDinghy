using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;

namespace CRM_GoDinghy
{
    public class settingClass
    {
        private static string theme;
        private static string style;
        private static bool fullScreen;

        public string Theme 
        {
            get { return theme; }
            set { theme = value; }
        }

        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        public bool FullScreen
        {
            get { return fullScreen; }
            set { fullScreen = value; }
        }
    }
}
