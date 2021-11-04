using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:
 * Date:
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;

            // INPUT
            num = Convert.ToInt32(xInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            xOutputLabel.Text = String.Format("The square is {0}", Square(num));

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            xOutputLabel.Text += String.Format("\nThe cube is {0}", Cube(num));
            // text = text + moreText ; text += moreText

            // OUTPUT
            // set the output to visible
            xOutputLabel.Visible = true;

            // turn the Go button off
            xGoButton.Enabled = false;
            xResetButton.Enabled = true;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            xInputTextBox.Clear();
            xOutputLabel.Text = "";

            // turn the output to invisible
            xOutputLabel.Visible = false;

            // turn the Go button back on
            xGoButton.Enabled = true;
            xResetButton.Enabled = false;
        }

    }
}
