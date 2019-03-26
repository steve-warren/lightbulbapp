using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class LightSwitch
    {
        public LightSwitch(ToggleSwitch toggleSwitch)
        {
            this.UISwitch = toggleSwitch;
        }

        public ToggleSwitch UISwitch { get; }

        public void Up()
        {
            UISwitch.IsOn = true;
        }

        public void Down()
        {
            UISwitch.IsOn = false;
        }

        public bool IsUp()
        {
            return UISwitch.IsOn;
        }

        public bool IsDown()
        {
            return !UISwitch.IsOn;
        }
    }

    enum ToggleSwitchPosition
    {
        Down,
        Up
    }
}
