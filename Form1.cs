using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldwin_Asg4_Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //NOTE FOR ANDY:
        //The tags are to help both myself and anyone else who might be reading/editing my code.
        //It is an old habit I picked up during my high school classes where we wrote code
        //as if we were going to be working with other people, so notes like these were neccessary.
        //Sometimes my code might seem like absolute chaos but I have a system I promise!
        //PS: please excuse my horrible spelling, just be glad you don't have to read my handwriting.
        //END OF NOTE

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int sumOfBits = 0;
            String hexValue = "";
            labelResultsDecimal.Text = "";
            labelResultsHex.Text = "";

            //decimal conversion start
            if (checkBoxBinary1.Checked == true)
                sumOfBits = sumOfBits + 1;
            if (checkBoxBinary2.Checked == true)
                sumOfBits = sumOfBits + 2;
            if (checkBoxBinary3.Checked == true)
                sumOfBits = sumOfBits + 4;
            if (checkBoxBinary4.Checked == true)
                sumOfBits = sumOfBits + 8;
            if (checkBoxBinary5.Checked == true)
                sumOfBits = sumOfBits + 16;
            if (checkBoxBinary6.Checked == true)
                sumOfBits = sumOfBits + 32;
            if (checkBoxBinary7.Checked == true)
                sumOfBits = sumOfBits + 64;
            if (checkBoxBinary8.Checked == true)
                sumOfBits = sumOfBits + 128;
            //decimal conversion end

            //hex conversion start
            hexValue = sumOfBits.ToString("X");
            //hex conversion end

            //label assignment start
            labelResultsDecimal.Text = sumOfBits.ToString();
            labelResultsHex.Text = hexValue;

            if (radioButtonHex.Checked == true)
                labelResultsDecimal.Text = "";
            if (radioButtonDecimal.Checked == true)
                labelResultsHex.Text = "";
            //label assignment end
        }//end convert button

        private void buttonClear_Click(object sender, EventArgs e)
        {
            checkBoxBinary8.Checked = false;
            checkBoxBinary7.Checked = false;
            checkBoxBinary6.Checked = false;
            checkBoxBinary5.Checked = false;
            checkBoxBinary4.Checked = false;
            checkBoxBinary3.Checked = false;
            checkBoxBinary2.Checked = false;
            checkBoxBinary1.Checked = false;
            labelResultsDecimal.Text = "";
            labelResultsHex.Text = "";
        }//end clear button

        private void listBoxTestValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTestValueAsString = "";

            // Check if something is selected
            if (listBoxTestValues.SelectedIndex > -1)
            {
                // Get selected text
                selectedTestValueAsString = listBoxTestValues.SelectedItem.ToString();

                checkBoxBinary8.Checked = false;
                checkBoxBinary7.Checked = false;
                checkBoxBinary6.Checked = false;
                checkBoxBinary5.Checked = false;
                checkBoxBinary4.Checked = false;
                checkBoxBinary3.Checked = false;
                checkBoxBinary2.Checked = false;
                checkBoxBinary1.Checked = false;

                switch (selectedTestValueAsString)
                {
                    case "1":
                        checkBoxBinary1.Checked = true;
                        break;

                    case "2":
                        checkBoxBinary2.Checked = true;
                        break;

                    case "4":
                        checkBoxBinary3.Checked = true;
                        break;

                    case "8":
                        checkBoxBinary4.Checked = true;
                        break;

                    case "16":
                        checkBoxBinary5.Checked = true;
                        break;

                    case "32":
                        checkBoxBinary6.Checked = true;
                        break;

                    case "64":
                        checkBoxBinary7.Checked = true;
                        break;

                    case "128":
                        checkBoxBinary8.Checked = true;
                        break;

                    case "255":
                        checkBoxBinary8.Checked = true;
                        checkBoxBinary7.Checked = true;
                        checkBoxBinary6.Checked = true;
                        checkBoxBinary5.Checked = true;
                        checkBoxBinary4.Checked = true;
                        checkBoxBinary3.Checked = true;
                        checkBoxBinary2.Checked = true;
                        checkBoxBinary1.Checked = true;
                        break;
                }//end switch
            }//end check if selected
        }//end test values method
    }
}
