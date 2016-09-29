using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.TemplatePlugin
{
    public unsafe class BasicProcessor : IRealProcessor
    {
        #region Constructor

        public BasicProcessor(ISharpControl control, FrontEndControl frontEndControl)
        {
            // frontEndControl can be used to access the display control
        }

        #endregion

        #region IRealProcessor implementation

        public void Process(float* buffer, int length)
        {
            // This is the hookup point which gets executed upon data arrival
        }

        internal void Stop()
        {
            //throw new NotImplementedException();
        }

        public double SampleRate { get; set; }
        public bool Enabled { get; set; }

        #endregion
    }
}

