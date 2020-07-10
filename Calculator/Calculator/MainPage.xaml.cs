using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        int num1;
        int num2;
        int result;
        bool divideActive = false;
        bool multiplyActive = false;
        bool minusActive = false;
        bool plusActive = false;
        bool newEntry = false;
        bool operatorActive = false;

        private void ac_Clicked(object sender, EventArgs e)
        {
            lab.Text = "0";
            int num1;
            int num2;
            divideActive = false;
            multiplyActive = false;
            minusActive = false;
            plusActive = false;
            newEntry = false;
            operatorActive = false;
        }

        private void divide_Clicked(object sender, EventArgs e)
        {
            if (operatorActive)
            {
                equalsCheck();
                divideActive = true;
            }
            num1 = Int32.Parse(lab.Text);
            divideActive = true;
            newEntry = true;
            operatorActive = true;
        }

        private void seven_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "7";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "7";
            }
            else
            {
                lab.Text = lab.Text + "7";
            }
        }

        private void eight_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "8";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "8";
            }
            else
            {
                lab.Text = lab.Text + "8";
            }
        }

        private void nine_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "9";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "9";
            }
            else
            {
                lab.Text = lab.Text + "9";
            }
        }

        private void multiply_Clicked(object sender, EventArgs e)
        {
            if (operatorActive)
            {
                equalsCheck();
                multiplyActive = true;
            }
            num1 = Int32.Parse(lab.Text);
            newEntry = true;
            multiplyActive = true;
            operatorActive = true;
        }

        private void four_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "4";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "4";
            }
            else
            {
                lab.Text = lab.Text + "4";
            }
        }

        private void five_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "5";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "5";
            }
            else
            {
                lab.Text = lab.Text + "5";
            }
        }

        private void six_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "6";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "6";
            }
            else
            {
                lab.Text = lab.Text + "6";
            }
        }

        private void minus_Clicked(object sender, EventArgs e)
        {
            if (operatorActive)
            {
                equalsCheck();
                minusActive = true;
            }
            num1 = Int32.Parse(lab.Text);
            newEntry = true;
            minusActive = true;
            operatorActive = true;
        }

        private void one_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "1";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "1";
            }
            else
            {
                lab.Text = lab.Text + "1";
            }
        }

        private void two_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "2";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "2";
            }
            else
            {
                lab.Text = lab.Text + "2";
            }
        }

        private void three_Clicked(object sender, EventArgs e)
        {
            if (newEntry)
            {
                lab.Text = "3";
                newEntry = false;
            }
            else if (lab.Text == "0")
            {
                lab.Text = "3";
            }
            else
            {
                lab.Text = lab.Text + "3";
            }
        }

        private void plus_Clicked(object sender, EventArgs e)
        {
            if (operatorActive)
            {
                equalsCheck();
                plusActive = true;
            }
            num1 = Int32.Parse(lab.Text);
            newEntry = true;
            plusActive = true;
            operatorActive = true;
        }

        private void zero_Clicked(object sender, EventArgs e)
        {
            if (lab.Text == "0")
            {
                lab.Text = "0";
            }
            else if (newEntry)
            {
                lab.Text = "0";
                newEntry = false;
            }
            else
            {
                lab.Text = lab.Text + "0";
            }
        }

        private void point_Clicked(object sender, EventArgs e)
        {
            lab.Text = lab.Text + ".";
        }

        private void equals_Clicked(object sender, EventArgs e)
        {
            num2 = Int32.Parse(lab.Text);
            if (divideActive)
            {
                if (num2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = num1 / num2;
                    divideActive = false;
                }
            }
            else if (multiplyActive)
            {
                result = num1 * num2;
                multiplyActive = false;
            }
            else if (minusActive)
            {
                result = num1 - num2;
                minusActive = false;
            }
            else if (plusActive)
            {
                result = num1 + num2;
                plusActive = false;
            }
            else
            {
                lab.Text = lab.Text;
            }
            lab.Text = result.ToString();
            operatorActive = false;
            //newEntry = false;
            num1 = result;
        }

        public void equalsCheck()
        {
            num2 = Int32.Parse(lab.Text);
            if (divideActive)
            {
                if (num2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = num1 / num2;
                    divideActive = false;
                }
            }
            else if (multiplyActive)
            {
                result = num1 * num2;
                multiplyActive = false;
            }
            else if (minusActive)
            {
                result = num1 - num2;
                minusActive = false;
            }
            else if (plusActive)
            {
                result = num1 + num2;
                plusActive = false;
            }
            else
            {
                lab.Text = lab.Text;
            }
            lab.Text = result.ToString();
            //newEntry = false;
            num1 = result;
            num2 = 0;
        }
    }
}
