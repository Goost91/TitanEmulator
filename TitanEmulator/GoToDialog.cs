using System;
using System.Windows.Forms;

namespace TitanEmulator {
    public partial class GoToDialog : Form {
        public GoToDialog() {
            InitializeComponent();
        }

        public int getByteIndex() {
            return (int)numByte.Value - 1;
        }

        private void btnGo_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }
    }
}
