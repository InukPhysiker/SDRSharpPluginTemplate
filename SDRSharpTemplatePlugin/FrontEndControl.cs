using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.TemplatePlugin
{
    public partial class FrontEndControl : UserControl
    {
        public FrontEndControl(ISharpControl _settingsControl)
        {
            InitializeComponent();
            this.Visible = false;
        }
    }
}
