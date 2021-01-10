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
using System.Collections.Specialized;
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

        private enum KeyboardModifier
        {
            Unknown = -1,
            None = 1,
            Alt = 2,
            Ctrl = 4
        }

        private class ButtonPress
        {
            public Button Button { get; private set; }
            public bool Pressed { get; private set; }
            public KeyboardModifier KeyboardModifier { get; private set; }

            public ButtonPress(Button button, bool pressed, KeyboardModifier keyboardModifier)
            {
                this.Button = button;
                this.Pressed = pressed;
                this.KeyboardModifier = keyboardModifier;
            }
        }

        private Joystick _joystick = null;
        private Keyboard _keyboard = null;
        private List<TextBox> _commandTextBoxes = new List<TextBox>();
        private KeyboardModifier _selectedModifier = KeyboardModifier.Unknown;
        private Dictionary<KeyboardModifier, List<String>> _commands = new Dictionary<KeyboardModifier, List<string>>();

        private void SaveCommandsToSettings(KeyboardModifier modifier, StringCollection commands)
        {
            commands.Clear();
            foreach (string command in _commands[modifier])
            {
                commands.Add(command);
            }
        }
        private void LoadCommandsFromSettings(KeyboardModifier modifier, StringCollection commands)
        {
            _commands[modifier] = new List<string>();
            if (commands == null)
            {
                return;
            }
            foreach (string command in commands)
            {
                _commands[modifier].Add(command);
            }
        }

        private void SaveCommandsToSelectedModifier()
        {
            if (_selectedModifier == KeyboardModifier.Unknown)
            {
                return;
            }
            _commands[_selectedModifier].Clear();
            foreach (var commandTextBox in _commandTextBoxes)
            {
                _commands[_selectedModifier].Add(commandTextBox.Text);
            }
        }
        private void SetCommandsBasedOnSelectedModifier()
        {
            int commandIndex = 0;
            foreach (string command in _commands[_selectedModifier])
            {
                _commandTextBoxes[commandIndex++].Text = command;
            }
        }

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

            LoadCommandsFromSettings(KeyboardModifier.None, Properties.Settings.Default.Commands);
            LoadCommandsFromSettings(KeyboardModifier.Alt, Properties.Settings.Default.AltCommands);
            LoadCommandsFromSettings(KeyboardModifier.Ctrl, Properties.Settings.Default.CtrlCommands);

            KeyboardModifier modifier = (KeyboardModifier)Properties.Settings.Default.SelectedKeyboardModifier;
            switch (modifier)
            {
                case KeyboardModifier.None:
                    this.radioButtonNone.Checked = true;
                    break;

                case KeyboardModifier.Alt:
                    this.radioButtonAlt.Checked = true;
                    break;

                case KeyboardModifier.Ctrl:
                    this.radioButtonCtrl.Checked = true;
                    break;

                default:
                    this.radioButtonNone.Checked = true;
                    modifier = KeyboardModifier.None;
                    break;
            }

            _selectedModifier = modifier;
            SetCommandsBasedOnSelectedModifier();

            InitializeJoystick();
        }

        KeyboardModifier GetSelectedKeyboardModifier()
        {
            if (this.radioButtonNone.Checked)
            {
                return KeyboardModifier.None;
            }

            if (this.radioButtonAlt.Checked)
            {
                return KeyboardModifier.Alt;
            }

            if (this.radioButtonCtrl.Checked)
            {
                return KeyboardModifier.Ctrl;
            }

            return KeyboardModifier.Unknown;
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
                        KeyboardModifier modifier = KeyboardModifier.None;
                        var keyboardState = _keyboard.GetCurrentState();
                        // Note: it's possible that both Ctrl and Alt are pressed but we won't support this for now.
                        // The enum does have provisions for that because Alt and Ctrl can be combined.
                        if (keyboardState.IsPressed(Key.LeftControl) || keyboardState.IsPressed(Key.RightControl))
                        {
                            modifier = KeyboardModifier.Ctrl;
                        }
                        else if (keyboardState.IsPressed(Key.LeftAlt) || keyboardState.IsPressed(Key.RightAlt))
                        {
                            modifier = KeyboardModifier.Alt;
                        }
                        this.backgroundWorker.ReportProgress(0, new ButtonPress(button, datum.Value == 128, modifier));
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
                var commands = _commands[buttonPress.KeyboardModifier];
                string command = commands[(int)buttonPress.Button];
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
            _keyboard = new Keyboard(directInput);
            _keyboard.Acquire();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.Commands == null)
            {
                Properties.Settings.Default.Commands = new StringCollection();
            }
            if (Properties.Settings.Default.AltCommands == null)
            {
                Properties.Settings.Default.AltCommands = new StringCollection();
            }
            if (Properties.Settings.Default.CtrlCommands == null)
            {
                Properties.Settings.Default.CtrlCommands = new StringCollection();
            }

            SaveCommandsToSettings(KeyboardModifier.None, Properties.Settings.Default.Commands);
            SaveCommandsToSettings(KeyboardModifier.Alt, Properties.Settings.Default.AltCommands);
            SaveCommandsToSettings(KeyboardModifier.Ctrl, Properties.Settings.Default.CtrlCommands);

            Properties.Settings.Default.SelectedKeyboardModifier = (int)GetSelectedKeyboardModifier();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            SaveCommandsToSelectedModifier();
            _selectedModifier = KeyboardModifier.None;
            SetCommandsBasedOnSelectedModifier();
        }

        private void radioButtonCtrl_CheckedChanged(object sender, EventArgs e)
        {
            SaveCommandsToSelectedModifier();
            _selectedModifier = KeyboardModifier.Ctrl;
            SetCommandsBasedOnSelectedModifier();
        }

        private void radioButtonAlt_CheckedChanged(object sender, EventArgs e)
        {
            SaveCommandsToSelectedModifier();
            _selectedModifier = KeyboardModifier.Alt;
            SetCommandsBasedOnSelectedModifier();
        }
    }
}
