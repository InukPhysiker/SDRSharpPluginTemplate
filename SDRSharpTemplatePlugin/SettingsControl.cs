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
    public partial class SettingsControl : UserControl
    {
        private ISharpControl _settingsControl;
        private BasicProcessor _basicProcessor;
        private FrontEndControl _frontEndControl;

        public SettingsControl(ISharpControl settingsControl, FrontEndControl frontEndControl, BasicProcessor basicProcessor)
        {
            InitializeComponent();
            _settingsControl = settingsControl;
            _basicProcessor = basicProcessor;
            _frontEndControl = frontEndControl;
        }

        private void enableFrontEndControlcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _frontEndControl.Visible = enableFrontEndControlcheckBox.Checked;
        }
    }
}
