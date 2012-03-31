using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TitanEmulator.instructions;

namespace TitanEmulator {
    public partial class Form1 : Form {
        Interpreter interpreter = new Interpreter();
        StackViewer sv;
        CallStackViewer csv;
        public Form1() {
            InitializeComponent();
            interpreter.loadAssembly();
            textBox1.Text = interpreter.assemblyString;
            sv = new StackViewer();
            csv = new CallStackViewer();
            UpdateRegisterViews();
            openFileDialog1.Filter = "Titan Assemblies (*.hex)|*.hex";
        }


        private void timer1_Tick(object sender, EventArgs e) {
            doCycle();
        }

        private void doCycle() {
            if (interpreter.programCounter > interpreter.assembly.Length - 1) {
                timer1.Stop();
                return;
            }
            // fetch instruction
            interpreter.fetchNextInstruction(); 
            UpdateRegisterViews();
            // decode instruction
            Instruction ins = interpreter.decodeInstruction();
            UpdateRegisterViews();
            // execute instruction
            interpreter.executeInstruction(ins);
            UpdateRegisterViews();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!textBox1.Text.Equals(""))
                interpreter.loadAssembly(textBox1.Text);
            doCycle();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!textBox1.Text.Equals(""))
                interpreter.loadAssembly(textBox1.Text);
            if (button1.Text.Equals("Run")) {
                timer1.Start();
                button1.Text = "Stop";
            } else if(button1.Text.Equals("Stop")) {
                timer1.Stop();
                button1.Text = "Run";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            interpreter.reset();
            timer1.Stop();
            sv.reset();
            csv.reset();
            UpdateRegisterViews();
        }

        private void UpdateRegisterViews() {
            tbR0.Text = interpreter.ms.registers[0].value.ToString();
            tbR1.Text = interpreter.ms.registers[1].value.ToString();
            tbR2.Text = interpreter.ms.registers[2].value.ToString();
            tbR3.Text = interpreter.ms.registers[3].value.ToString();
            tbR4.Text = interpreter.ms.registers[4].value.ToString();
            tbR5.Text = interpreter.ms.registers[5].value.ToString();
            tbR6.Text = interpreter.ms.registers[6].value.ToString();
            tbR7.Text = interpreter.ms.registers[7].value.ToString();
            tbR8.Text = interpreter.ms.registers[8].value.ToString();
            tbR9.Text = interpreter.ms.registers[9].value.ToString();
            tbRA.Text = interpreter.ms.registers[10].value.ToString();
            tbRB.Text = interpreter.ms.registers[11].value.ToString();
            tbRC.Text = interpreter.ms.registers[12].value.ToString();
            tbRD.Text = interpreter.ms.registers[13].value.ToString();
            tbRE.Text = interpreter.ms.registers[14].value.ToString();
            tbRF.Text = interpreter.ms.registers[15].value.ToString();
            tbPC.Text = (interpreter.programCounter).ToString();
            tbC.Text = (interpreter.ms.flags["C"]).ToString();
            tbS.Text = (interpreter.ms.flags["S"]).ToString();
            tbZ.Text = (interpreter.ms.flags["Z"]).ToString();
            stackHeightLbl.Text = string.Format("Stack height: {0}", interpreter.ms.stack.Count);
            callStackLbl.Text = string.Format("Call stack height: {0}", interpreter.ms.callStack.Count);
            currentInstructionLbl.Text = string.Format("Current Instruction: {0}", interpreter.currentInstruction.name);
            sv.update(interpreter.ms);
            csv.update(interpreter.ms);
        }

        private void stackViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sv.Show();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e) {
            
        }

        private void menuStrip1_SizeChanged(object sender, EventArgs e) {
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                System.IO.Stream fileStream = openFileDialog1.OpenFile();
                string result = "";
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream)) {
                    // Read the first line from the file and write it the textbox.
                    while (!reader.EndOfStream) {
                        char inChar = (char) reader.Read();
                        if (isValidAssemblyChar(inChar))
                            result += inChar;
                    }
                }
                textBox1.Text = result;
                fileStream.Close();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            csv.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
         /*   char[] validKeys = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', ' ' };
            if (!validKeys.Contains((char)e.KeyValue)) {
                e.Handled = true;
            }*/
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!isValidAssemblyChar(e.KeyChar))
                e.Handled = true;
        }


        public static bool isValidAssemblyChar(char c) {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || c == ' ';
        }


    }
}
