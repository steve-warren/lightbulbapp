using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        LightBulb light = new LightBulb();
        LightSwitch[] switches = new LightSwitch[1];

        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(400, 600);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            light.StateChanged += Bulb_StateChanged;

            for (var i = 0; i < switches.Length; i ++)
                switches[i] = NewLightSwitch();

            TurnLightOnOrOff();
        }

        private LightSwitch NewLightSwitch()
        {
            var toggleSwitch = new ToggleSwitch();
            toggleSwitch.OnContent = "Up";
            toggleSwitch.OffContent = "Down";
            switchPanel.Children.Add(toggleSwitch);
            toggleSwitch.HorizontalAlignment = HorizontalAlignment.Center;
            toggleSwitch.Toggled += SwitchChanged;

            return new LightSwitch(toggleSwitch);
        }

        private void Bulb_StateChanged(object sender, LightBulbState e)
        {
            if (light.State == LightBulbState.On)
            {
                lightOff.Opacity = 0;
                lightOn.Opacity = 1;
            }

            else if (light.State == LightBulbState.Off)
            {
                lightOff.Opacity = 1;
                lightOn.Opacity = 0;
            }
        }

        private bool Xor(bool a, bool b)
        {
            return a != b;
        }

        public bool Xnor(bool a, bool b)
        {
            return a == b;
        }

        private void SwitchChanged(object sender, RoutedEventArgs e) => TurnLightOnOrOff();
        
        private void TurnLightOnOrOff()
        {
            
        }
    }
}
