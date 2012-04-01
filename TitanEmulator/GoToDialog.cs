using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitanEmulator {
    public partial class GoToDialog : Form {
        public GoToDialog() {
            InitializeComponent();
        }

        public int getByteIndex() {
            return (int)numericUpDown1.Value - 1;
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            
        }
    }
}
