using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_GUI
{
    public partial class calculatorgui : Form
    {
        // decleration in  all methods
        // num is where in all declared inside in all operative methods, it will be stored in the variable num and be headed
        // to the arthmetic operation
        // ans is where the answer will be displayed 
        double ans, num;
        //int calculate is where the user can choose either the 4 after pressing operation buttons 
        int calculate;

        public calculatorgui()
        {
            InitializeComponent();
        }

        public void arthmetic_operation()
        {
            switch (calculate)
            {
                case 1://addition
                    ans = num + Double.Parse(calculatebox.Text);
                    calculatebox.Text = Convert.ToString(ans);
                    break;

                case 2://subtraction
                    ans = num - Double.Parse(calculatebox.Text);
                    calculatebox.Text = Convert.ToString(ans);
                    break;

                case 3://multiplication
                    ans = num * Double.Parse(calculatebox.Text);
                    calculatebox.Text = Convert.ToString(ans);
                    break;

                case 4://division
                    ans = num / Double.Parse(calculatebox.Text);
                    calculatebox.Text = Convert.ToString(ans);
                    break;
            }

        }
        //program will display 0 if user wants to calculate using 0 - 9 

        private void no_0_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 0;
        }

        private void no_1_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 1;
        }

        private void no_2_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 2;
        }

        private void no_3_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 3;
        }

        private void no_4_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 4;
        }

        private void no_5_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 5;
        }

        private void no_6_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 6;
        }

        private void no_7_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 7;
        }

        private void no_8_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 8;
        }

        private void no_9_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + 9;
        }

        //program is a double declaration but user can place a decimal point 
        private void decimalpoint_Click(object sender, EventArgs e)
        {
            calculatebox.Text = calculatebox.Text + ".";
        }

        //program will allow the user to remove a single numerical value 
        private void backspace_Click(object sender, EventArgs e)
        {
            //length is where the calculatebox.text will be based on its length
            int length = Convert.ToInt32(calculatebox.Text.Length);

            String store;
            if (length > 0)
            {
                //using of Stringbuilder since it is needed by the keyword remove
                StringBuilder back = new StringBuilder(calculatebox.Text);
                back.Remove(back.Length - 1, 1);
                store = back.ToString();
                calculatebox.Text = store;
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            //program will add the numbers. the num with numeric contents will be transfered to the arthmetic operation
            //for calculation
            num = Double.Parse(calculatebox.Text);
            calculate = 1;
            calculatebox.Text = "";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            //program will subtract the numbers. the num with numeric contents will be transfered to the arthmetic operation
            //for calculation
            num = Double.Parse(calculatebox.Text);
            calculate = 2;
            calculatebox.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            //program will multiply the numbers. the num with numeric contents will be transfered to the arthmetic operation
            //for calculation
            num = Double.Parse(calculatebox.Text);
            calculate = 3;
            calculatebox.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            //program will divide the numbers. the num with numeric contents will be transfered to the arthmetic operation
            //for calculation
            num = Double.Parse(calculatebox.Text);
            calculate = 4;
            calculatebox.Text = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            //program will display the results after computation 
            arthmetic_operation(); 
        }
    }
}
