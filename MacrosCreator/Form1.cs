using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using System.Xml.Serialization;
using KeyboardHook;

namespace MacrosCreator
{
    public partial class MainForm : Form
    {
        const string safePath = "safe.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Macros>));

        List<Macros> Macroses = new List<Macros>(0);
        LowLevelKeyboardListener Listener;
        bool MacrosesActive;

        public MainForm()
        {
            InitializeComponent();

            notifyIcon1.Visible = false;

            LoadMacroses();
            AddMacroses();

            MacrosesActive = false;

            LastRecordedKeys = new List<Key>(0);
            LastActivationKey = default(Key);

            StopMacrosesButton.Enabled = false;

            Listener = new LowLevelKeyboardListener();
            Listener.OnKeyPressed += Listener_OnKeyPressed;
            Listener.HookKeyboard();
        }

        private void Listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if (MacrosesActive)
            {
                foreach (string s in ListOfMacroses.CheckedItems.OfType<string>())
                {
                    for (int x = 0; x < Macroses.Count; x++)
                        if (Macroses[x].Name == s)
                            Macroses[x].RunMacros(e.KeyPressed);
                }
            }
        }

        void LoadMacroses()
        {
            try
            {
                using (FileStream fs = new FileStream(safePath, FileMode.Open))
                {
                    Macroses = (List<Macros>)serializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден");
            }
        }

        void SafeMacroses()
        {
            using (FileStream fs = new FileStream(safePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Macroses);
            }
        }

        void AddMacroses()
        {
            foreach (var m in Macroses)
                ListOfMacroses.Items.Add(m.Name);
        }

        private void CreateMacrosButton_Click(object sender, EventArgs e)
        {
            if (MacrosNameTextBox.Text == "") { MessageBox.Show("Введите название макроса"); return; }
            if (RepeatTimeTextBox.Text == "") { MessageBox.Show("Введите время повтора"); return; }
            int RepeatTime;
            try { RepeatTime = Convert.ToInt32(RepeatTimeTextBox.Text); }
            catch { MessageBox.Show("Вводите нормальные числа"); return; }
            if (LastRecordedKeys.Count == 0) { MessageBox.Show("Запишите макрос"); return; }
            if (LastActivationKey == default(Key)) { MessageBox.Show("Задайте клавишу активации"); return; }

            Macroses.Add(new Macros(MacrosNameTextBox.Text, LastRecordedKeys, LastActivationKey, RepeatTime));
            Listener.OnKeyPressed -= RecordingHandler;
            ListOfMacroses.Items.Add(MacrosNameTextBox.Text);

            LastRecordedKeys = new List<Key>(0);
            LastActivationKey = default(Key);

            MessageBox.Show(Macroses[Macroses.Count - 1].ToString());
        }

        List<Key> LastRecordedKeys;
        private void StartRecordingButton_Click(object sender, EventArgs e)
        {
            Listener.OnKeyPressed += RecordingHandler;

            StartRecordingButton.Enabled = false;
            DeleteSelected.Enabled = false;
            MacrosNameTextBox.Enabled = false;
            InfoButton.Enabled = false;
            SetActivationKeyButton.Enabled = false;
            CreateMacrosButton.Enabled = false;
            RunMacrosesButton.Enabled = false;
            StopMacrosesButton.Enabled = false;
            RepeatTimeTextBox.Enabled = false;
            ListOfMacroses.Enabled = false;
        }

        private void RecordingHandler(object sender, KeyPressedArgs e)
        {
            LastRecordedKeys.Add(e.KeyPressed);
        }

        private void StopRecordingButton_Click(object sender, EventArgs e)
        {
            Listener.OnKeyPressed -= RecordingHandler;

            StartRecordingButton.Enabled = true;
            DeleteSelected.Enabled = true;
            MacrosNameTextBox.Enabled = true;
            InfoButton.Enabled = true;
            SetActivationKeyButton.Enabled = true;
            CreateMacrosButton.Enabled = true;
            RunMacrosesButton.Enabled = true;
            StopMacrosesButton.Enabled = true;
            RepeatTimeTextBox.Enabled = true;
            ListOfMacroses.Enabled = true;
        }

        Key LastActivationKey;
        private void SetActivationKeyButton_Click(object sender, EventArgs e)
        {
            Listener.OnKeyPressed += SetActivationKeyHandler;
        }

        private void SetActivationKeyHandler(object sender, KeyPressedArgs e)
        {
            LastActivationKey = e.KeyPressed;
            Listener.OnKeyPressed -= SetActivationKeyHandler;
        }

        private void RunMacrosesButton_Click(object sender, EventArgs e)
        {
            MacrosesActive = true;
            RunMacrosesButton.Enabled = false;
            StopMacrosesButton.Enabled = true;
        }

        private void StopMacrosesButton_Click(object sender, EventArgs e)
        {
            MacrosesActive = false;
            RunMacrosesButton.Enabled = true;
            StopMacrosesButton.Enabled = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = "Приложение свернуто";
                notifyIcon1.ShowBalloonTip(500);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SafeMacroses();
            Listener.UnHookKeyboard();
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ListOfMacroses.Items.Count; x++)
            {
                if (ListOfMacroses.GetSelected(x))
                {
                    ListOfMacroses.Items.RemoveAt(x);
                    Macroses.RemoveAt(x);
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < Macroses.Count; x++)
                sb.Append(Macroses[x].ToString() + "\n================================\n");
            MessageBox.Show(sb.ToString(), "Информация о макросах");
        }
    }

    [Serializable]
    public struct Macros
    {
        public string Name;
        public string[] Keys;
        public Key ActivationKey;
        public int Repeat;

        public Macros(string name, List<Key> keys, Key activationKey, int repeat)
        {
            Name = name;
            Keys = GetNormKeys(keys);
            ActivationKey = activationKey;
            Repeat = repeat;
        }

        public void RunMacros(Key key)
        {
            if (ActivationKey == key)
            {
                SendKeys.SendWait(Sum(Keys, ""));
                System.Threading.Thread.Sleep(Repeat);
            }
        }

        public static string[] GetNormKeys(List<Key> keys)
        {
            string[] normKeys = new string[keys.Count];
            for (int x = 0; x < normKeys.Length; x++)
                normKeys[x] = ToNormKey(keys[x]);
            return normKeys;
        }

        static KeyConverter converter = new KeyConverter();

        public static string ToNormKey(Key key)
        {
            switch (key)
            {
                case Key.N: return "n";
                case Key.B: return "b";
                case Key.V: return "v";
                case Key.C: return "c";
                case Key.X: return "x";
                case Key.Z: return "z";
                case Key.L: return "l";
                case Key.K: return "k";
                case Key.J: return "j";
                case Key.H: return "h";
                case Key.G: return "g";
                case Key.F: return "f";
                case Key.D: return "d";
                case Key.S: return "s";
                case Key.A: return "a";
                case Key.P: return "p";
                case Key.O: return "o";
                case Key.I: return "i";
                case Key.U: return "u";
                case Key.Y: return "y";
                case Key.T: return "t";
                case Key.R: return "r";
                case Key.E: return "e";
                case Key.W: return "w";
                case Key.Q: return "q";
                case Key.M: return "m";
                case Key.F16: return "{F16}";
                case Key.F15: return "{F15}";
                case Key.F14: return "{F14}";
                case Key.F13: return "{F13}";
                case Key.F12: return "{F12}";
                case Key.F11: return "{F11}";
                case Key.F10: return "{F10}";
                case Key.F9: return "{F9}";
                case Key.F8: return "{F8}";
                case Key.F7: return "{F7}";
                case Key.F6: return "{F6}";
                case Key.F5: return "{F5}";
                case Key.F4: return "{F4}";
                case Key.F3: return "{F3}";
                case Key.F2: return "{F2}";
                case Key.F1: return "{F1}";
                case Key.NumPad9: return "9";
                case Key.NumPad8: return "8";
                case Key.NumPad7: return "7";
                case Key.NumPad6: return "6";
                case Key.NumPad5: return "5";
                case Key.NumPad4: return "4";
                case Key.NumPad3: return "3";
                case Key.NumPad2: return "2";
                case Key.NumPad1: return "1";
                case Key.NumPad0: return "0";
                case Key.Space: return "{SPACE}";
                case Key.Enter: return "{ENTER}";
                case Key.LeftShift: return "+";
                case Key.LeftCtrl: return "^";
                case Key.LeftAlt: return "%";
                case Key.D9: return "9";
                case Key.D8: return "8";
                case Key.D7: return "7";
                case Key.D6: return "6";
                case Key.D5: return "5";
                case Key.D4: return "4";
                case Key.D3: return "3";
                case Key.D2: return "2";
                case Key.D1: return "1";
                case Key.D0: return "0";
                case Key.Up: return "{UP}";
                case Key.Down: return "{DOWN}";
                case Key.Left: return "{LEFT}";
                case Key.Right: return "{RIGHT}";
                case Key.Tab: return "{TAB}";
                case Key.Escape: return "{ESC}";
                case Key.CapsLock: return "{CAPSLOCK}";
            }

            return key.ToString();
        }

        public override string ToString()
        {
            return "Имя: " + Name + "\nМакрос: " + Sum(Keys, " ") + "\nКлавиша активации: " + ActivationKey.ToString() + "\nПовтор раз в: " + Repeat + " мс";
        }

        string Sum<T>(T[] list, string r)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < list.Length; x++)
                sb.Append(list[x].ToString() + r);
            return sb.ToString();
        }
    }
}
