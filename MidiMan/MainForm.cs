/*
Copyright 2020 Google Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using NAudio.CoreAudioApi;
using System.Windows.Forms;

namespace MidiMan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Connect to MPD218.
            // If you want to use another MIDI controller and don't know its name,
            // you can call InputDevice.GetAll() see get all available devices.
            var device = InputDevice.GetByName("MPD218");
            device.EventReceived += Device_EventReceived;
            device.StartEventsListening();

        }

        private void Device_EventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            if (e.Event.EventType == MidiEventType.ControlChange)
            {
                ControlChangeEvent evt = (ControlChangeEvent)e.Event;
                // ControlNumber 3 corresponds to the first knob
                if (evt.Channel == 0 && evt.ControlNumber == 3)
                {
                    this.progressBarVolume.Value = evt.ControlValue * 100 / 127;
                    var volume = -65.25f * (1 - (evt.ControlValue / 127.0f));
                    var audioDevice = new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                    audioDevice.AudioEndpointVolume.MasterVolumeLevel = volume;
                }
            }
        }
    }
}
