using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class LightBulb
    {
        public LightBulbState State { get; private set; }

        public event EventHandler<LightBulbState> StateChanged;

        public bool IsOn() => State == LightBulbState.On;

        public bool IsOff() => State == LightBulbState.Off;

        public void On()
        {
            State = LightBulbState.On;
            StateChanged?.Invoke(this, State);
        }

        public void Off()
        {
            State = LightBulbState.Off;
            StateChanged?.Invoke(this, State);
        }
    }

    enum LightBulbState
    {
        Off,
        On
    }
}
