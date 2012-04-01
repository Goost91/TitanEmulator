using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace TitanEmulator {
    public partial class MemoryViewer : Form {
        private MachineState ms;
        private Be.Windows.Forms.DynamicByteProvider dbp;
        GoToDialog goToForm = new GoToDialog();
        public MemoryViewer() {
            InitializeComponent();
            //hexEditBox1.InitializeComponent();
            //linkedBox1.InitializeComponent();
            //hexEditBox1.LinkDisplay(linkedBox1);
            timer1.Start();
            
        }

        public void setMachineState(MachineState ms) {
            this.ms = ms;
            //if (dbp == null) {
                dbp = new DynamicByteProvider(ms.memory);
                hexBox1.ByteProvider = dbp;
            //}

            //hexEditBox1.LoadData(ms.memory);
            if (!timer1.Enabled && Visible) timer1.Start();
        }

        private void MemoryViewer_FormClosing(object sender, FormClosingEventArgs e) {
            Hide();
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (ms != null && Visible && ms.running) {

                //hexEditBox1.LoadData(ms.memory);
            }
        }

        private void hexEditBox1_SelectionChanged(object sender, EventArgs e) {
            // int start = hexEditBox1.SelectionStart;
            //int length = hexEditBox1.SelectionLength;
            // linkedBox1.Select(start, length);
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e) {
            if(goToForm.ShowDialog() == DialogResult.OK) {
                hexBox1.SelectionStart = goToForm.getByteIndex();
                hexBox1.SelectionLength = 1;
                hexBox1.Focus();
            }
        }
    }
}
