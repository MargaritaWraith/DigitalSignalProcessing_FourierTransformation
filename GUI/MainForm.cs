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
            if (f_Signal == null)
            {
                MessageBox.Show("No signal loaded", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Spectrum = f_Signal.GetSpectrum();
            dfLabel.Text = string.Format("df={0} Hz", Spectrum.df.ToString());
            SpectrList.Items.Clear();
            for (int i = 0; i < Spectrum.Length; i++)
            {
                SpectrList.Items.Add(Spectrum[i]);
            }
        }
    }
}
