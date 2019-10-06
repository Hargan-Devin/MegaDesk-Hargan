using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hargan
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void widthBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(widthBox.Text, out errorMsg))
            {
                e.Cancel = true;
                widthBox.Select(0, widthBox.Text.Length);
            }

            this.errorProvider1.SetError(widthBox, errorMsg);
        }

        private void widthBox_Validated(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(widthBox, "");
        }

        public bool ValidWidth(string width, out string errorMessage)
        {
            int value = Convert.ToInt32(widthBox.Text);
            try
            {
                value = Convert.ToInt32(widthBox.Text);
            }

            catch (Exception n)
            {
                errorMessage = "Please enter an integer.";
                return false;
            }

            if (value > Desk.MaxWidth)
            {
                errorMessage = "This width is too high.";
                return false;
            }
            else
            {
                if (value < Desk.MinWidth)
                {
                    errorMessage = "This width is too low.";
                    return false;
                }
                else
                {
                    errorMessage = "";
                    return true;
                }
            }

        }


        private void SurfaceBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            
            this.Hide();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DepthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depthBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void depthBox_KeyDown(object sender , System.Windows.Forms.KeyEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depthBox.Text, out errorMsg))
            {
                depthBox.Select(0, depthBox.Text.Length);
            }

            this.errorProvider2.SetError(depthBox, errorMsg);
            errorProvider2.SetError(depthBox, "");

        }

        private void depthBox_Validated(object sender, System.EventArgs e)
        {
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            char value = Convert.ToChar(depthBox.Text);

            if (!char.IsDigit(value))
            {
                errorMessage = "Please enter an integer.";
                return false;
            }

            if (value > Desk.MaxDepth)
            {
                    errorMessage = "This depth is too high.";
                    return false;
            }

            else
            {
                    if (value < Desk.MinDepth)
                    {
                        errorMessage = "This depth is too low.";
                        return false;
                    }
                    else
                    {
                        errorMessage = "";
                        return true;
                    }
            }
        }
        }
    }


