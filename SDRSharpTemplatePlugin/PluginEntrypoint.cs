using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SDRSharp.Radio;
using SDRSharp.Common;

namespace SDRSharp.TemplatePlugin
{
    public class PluginEntrypoint : ISharpPlugin
    {
        #region Members

        private SettingsControl _settingsControl;
        private BasicProcessor _basicProcessor;
        private FrontEndControl _frontEndControl;

        #endregion

        #region ISharpPlugin implementation

        public void Close()
        {
            _basicProcessor.Stop();
        }

        public string DisplayName
        {
            get { return "Basic Plugin"; }
        }

        public UserControl Gui
        {
            get
            { return _settingsControl; }
        }

        public bool HasGui
        {
            get { return true; }
        }

        public void Initialize(ISharpControl control)
        {
            _frontEndControl = new FrontEndControl(control);
            _basicProcessor = new BasicProcessor(control, _frontEndControl);
            _settingsControl = new SettingsControl(control, _frontEndControl, _basicProcessor);

            control.RegisterStreamHook(_basicProcessor, SDRSharp.Radio.ProcessorType.FilteredAudioOutput);
            control.RegisterFrontControl(_frontEndControl, PluginPosition.Bottom);

            _basicProcessor.Enabled = true;
        }

        #endregion
    }
}
