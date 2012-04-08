using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitanEmulator {
    public partial class StackViewer : Form {
        private MachineState ms;
        private int updateCounter;

        public StackViewer() {
            InitializeComponent();
            TopMost = true;
        }

        public void update(MachineState ms) {
            if (updateCounter++ < 15) return;
            if (!timer1.Enabled && Visible) timer1.Start();
            
            reset(ms);
        }

        private void StackViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        public void reset(MachineState ms)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (int value in ms.stack) {
                object[] row = { string.Format("{0:X}", i).PadLeft(4, '0'), string.Format("{0:X}", value).PadLeft(4, '0') };
                dataGridView1.Rows.Add(row);

                ++i;
                updateCounter = 0;
            }
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

        public void setMachineState(MachineState machineState) {
            ms = machineState;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            update(ms);
        }

    }
}
