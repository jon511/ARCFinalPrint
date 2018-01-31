using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARCFinalPrint
{
    public partial class Form2 : Form
    {
        public string enteredAccessCode = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteredAccessCode = textBox1.Text;
            this.Close();
        }
    }
}
