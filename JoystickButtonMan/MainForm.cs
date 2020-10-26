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
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace JoystickButtonMan
{
    public partial class MainForm : Form
    {
        public bool _visibleForm;
        public bool _allowExit = false;

        private enum Button
        {
            Unknown = -1,
            White = 0,
            Yellow = 1,
            Green = 2,
            Blue = 3,
            Orange = 4,
            Red = 5
        }

        private class ButtonPress
        {
            public Button Button { get; private set; }
            public bool Pressed { get; private set; }

            public ButtonPress(Button button, bool pressed)
            {
                this.Button = button;
                this.Pressed = pressed;
            }
        }

        private Joystick _joystick = null;
        private List<TextBox> _commandTextBoxes = new List<TextBox>();

        public MainForm(bool visibleForm)
        {
            _visibleForm = visibleForm;
            InitializeComponent();
            _commandTextBoxes.Add(textBoxWhite);
            _commandTextBoxes.Add(textBoxYellow);
            _commandTextBoxes.Add(textBoxGreen);
            _commandTextBoxes.Add(textBoxBlue);
            _commandTextBoxes.Add(textBoxOrange);
            _commandTextBoxes.Add(textBoxRed);
            if (Properties.Settings.Default.Commands != null)
            {
                int commandIndex = 0;
                foreach (string command in Properties.Settings.Default.Commands)
                {
                    _commandTextBoxes[commandIndex++].Text = command;
                }
            }
            InitializeJoystick();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(_visibleForm ? value : false);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                _joystick.Poll();
                Button button = Button.Unknown;
                foreach (var datum in _joystick.GetBufferedData())
                {
                    switch (datum.Offset)
                    {
                        case JoystickOffset.Buttons0:
                            button = Button.White;
                            break;
                        case JoystickOffset.Buttons1:
                            button = Button.Yellow;
                            break;
                        case JoystickOffset.Buttons2:
                            button = Button.Green;
                            break;
                        case JoystickOffset.Buttons3:
                            button = Button.Blue;
                            break;
                        case JoystickOffset.Buttons4:
                            button = Button.Red;
                            break;
                        case JoystickOffset.Buttons5:
                            button = Button.Orange;
                            break;
                        default:
                            break;
                    }
                    if (button != Button.Unknown)
                    {
                        this.backgroundWorker.ReportProgress(0, new ButtonPress(button, datum.Value == 128));
                    }
                }

                Thread.Sleep(20);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ButtonPress buttonPress = (ButtonPress)e.UserState;
            if (buttonPress.Pressed)
            {
                string command = _commandTextBoxes[(int)buttonPress.Button].Text;
                if (!String.IsNullOrWhiteSpace(command))
                {
                    Process.Start(command);
                }
            }
        }

        private void InitializeJoystick()
        {
            var directInput = new DirectInput();
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                if (deviceInstance.InstanceName.Replace(" ", String.Empty).Equals("GenericUSBJoystick", StringComparison.InvariantCultureIgnoreCase))
                {
                    _joystick = new Joystick(directInput, deviceInstance.InstanceGuid);
                    _joystick.Properties.BufferSize = 128;
                    _joystick.Acquire();
                    this.backgroundWorker.RunWorkerAsync();
                    break;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.Commands == null)
            {
                Properties.Settings.Default.Commands = new System.Collections.Specialized.StringCollection();
            }
            Properties.Settings.Default.Commands.Clear();
            foreach (var textbox in _commandTextBoxes)
            {
                Properties.Settings.Default.Commands.Add(textbox.Text);
            }
            Properties.Settings.Default.Save();

            if (!_allowExit)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void ToggleVisibility()
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                _visibleForm = true;
                this.Show();
                this.Focus();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleVisibility();
        }

        private void toggleVisibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleVisibility();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _allowExit = true;
            Application.Exit();
        }
    }
}
