using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartEndNumb
{
    public partial class Form1 : Form
    {
        int endNum, startNum;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void valueButton_Click(object sender, EventArgs e)
        {

            startNum = Convert.ToInt16(startNumInput.Text);
            endNum = Convert.ToInt16(endNumInput.Text);

            while (startNum <= endNum)
            {
                //numbers display
                outputLabel.Text += startNum + " ";

                startNum++;
            }
        }
    }
}
