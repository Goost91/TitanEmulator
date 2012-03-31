using System;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEmulator {
    public partial class CallStackViewer : Form {
        private MachineState ms;
        private int updateCounter = 0;
        public CallStackViewer() {
            InitializeComponent();
            TopMost = true;
        }

        public void update(MachineState ms) {
            if(!timer1.Enabled && Visible) timer1.Start();
            if (updateCounter++ >= 15) {
                reset();
                int i = 0;
                foreach (int value in ms.callStack) {
                    string[] row = { string.Format("{0:X}", i).PadLeft(4, '0'), string.Format("{0:X}", value).PadLeft(4, '0') };
                    dataGridView1.Rows.Add(row);

                    ++i;
                    updateCounter = 0;

                }
            }
        }

        private void StackViewer_Resize(object sender, EventArgs e) {
            //dataGridView1.Size = this.Size - new Size(8, 13);
        }

        private void StackViewer_FormClosing(object sender, FormClosingEventArgs e) {
            Hide();
            e.Cancel = true;
        }

        public void reset() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void StackViewer_SizeChanged(object sender, EventArgs e) {
            switch (WindowState) {
                case FormWindowState.Normal:
                case FormWindowState.Maximized:
                    TopMost = true;
                    break;
                case FormWindowState.Minimized:
                    TopMost = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            update(ms);
        }

        public void setMachineState(MachineState machineState) {
            ms = machineState;
            timer1.Start();
        }
    }
}