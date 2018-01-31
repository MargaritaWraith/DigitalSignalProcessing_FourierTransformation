using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPF;

namespace GUI
{
    public partial class MainForm : Form
    {
        private DigitalSignal f_Signal;
        private DigitalSpectrum f_Spectrum;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл сигнала";
            dialog.RestoreDirectory = true;
            dialog.Filter = "Text(*.txt)|*.txt";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file_name = dialog.FileName;
                var s = DigitalSignal.LoadFromFile(file_name);
                f_Signal = s;
                dtLabel.Text = string.Format("dt={0} seconds", s.dt.ToString());
                SignalList.Items.Clear();
                for (int i = 0; i < s.Length; i++)
                {
                    SignalList.Items.Add(s[i]);
                }

            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            if (f_Signal == null && f_Spectrum == null)
            {
                MessageBox.Show("No signal loaded", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (f_Signal != null)
            {
                var Spectrum = f_Signal.GetSpectrum();
                dfLabel.Text = string.Format("df={0} Hz", Spectrum.df.ToString());
                SpectrumList.Items.Clear();
                for (int i = 0; i < Spectrum.Length; i++)
                {
                    SpectrumList.Items.Add(Spectrum[i]);
                }
            }
            if (f_Spectrum != null)
            {
                var Signal = f_Spectrum.GetSignal();
                dtLabel.Text = string.Format("dt={0} s", Signal.dt.ToString());
                SignalList.Items.Clear();
                for (int i = 0; i < Signal.Length; i++)
                {
                    SignalList.Items.Add(Signal[i]);
                }
            }


        }

        private void signalFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл сигнала";
            dialog.RestoreDirectory = true;
            dialog.Filter = "Text(*.txt)|*.txt";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file_name = dialog.FileName;
                var s = DigitalSignal.LoadFromFile(file_name);
                f_Signal = s;
                dtLabel.Text = string.Format("dt={0} s", s.dt.ToString());
                SignalList.Items.Clear();
                for (int i = 0; i < s.Length; i++)
                {
                    SignalList.Items.Add(s[i]);
                }

            }
        }

        private void spectrumFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл спектра";
            dialog.RestoreDirectory = true;
            dialog.Filter = "Text(*.txt)|*.txt";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file_name = dialog.FileName;
                var S = DigitalSpectrum.LoadFromFile(file_name);
                f_Spectrum = S;
                dfLabel.Text = string.Format("df={0} Hz", S.df.ToString());
                SpectrumList.Items.Clear();
                for (int i = 0; i < S.Length; i++)
                {
                    SpectrumList.Items.Add(S[i]);
                }
            }
        }
    }
}
