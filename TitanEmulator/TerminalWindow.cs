using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitanEmulator {
    public partial class TerminalWindow : Form {
        private MachineState ms;

        public TerminalWindow() {
            InitializeComponent();
            textBox1.ForeColor = Color.FromArgb(255,0,192,0);
            textBox2.ForeColor = Color.FromArgb(255,0,192,0);
            
        }

        public void setMachineState(MachineState ms)
        {
            this.ms = ms;
            timer1.Start();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char)13)
            {
                ms.outputBuffer += "\r\n$ " + textBox2.Text;
                ms.inputBuffer += textBox2.Text;
                textBox2.Clear();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
                
                e.Handled = true;
            }
        }

        private void TerminalWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            textBox1.Text = ms.outputBuffer;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}
