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
        private DynamicByteProvider dbp;
        GoToDialog goToForm = new GoToDialog();

        public MemoryViewer() {
            InitializeComponent();

        }

        public void setMachineState(MachineState ms) {
            dbp = new DynamicByteProvider(ms.memory);
            hexBox1.ByteProvider = dbp;
        }

        private void MemoryViewer_FormClosing(object sender, FormClosingEventArgs e) {
            Hide();
            e.Cancel = true;
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e) {
            if (goToForm.ShowDialog() != DialogResult.OK) return;
            hexBox1.SelectionStart = goToForm.getByteIndex();
            hexBox1.SelectionLength = 1;
            hexBox1.Focus();
        }
    }
}
