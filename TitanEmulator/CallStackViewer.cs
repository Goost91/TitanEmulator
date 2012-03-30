using System;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEmulator
{
    public partial class CallStackViewer : Form {
        public CallStackViewer() {
            InitializeComponent();
            TopMost = true;
        }

        public void update(MachineState ms) {
            reset();
            int i = 0;
            foreach (int value in ms.callStack) {
                string[] row = { i.ToString(), value.ToString() };
                dataGridView1.Rows.Add(row);
                ++i;
            }
        }

        private void StackViewer_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = this.Size - new Size(8,13);
        }

        private void StackViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        public void reset() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void StackViewer_SizeChanged(object sender, EventArgs e) {
            switch(WindowState)
            {
                case FormWindowState.Normal:
                case FormWindowState.Maximized:
                    TopMost = true;
                    break;
                case FormWindowState.Minimized:
                    TopMost = false;
                    break;
            }
        }

    }
}