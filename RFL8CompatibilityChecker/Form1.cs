using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFL8CompatibilityChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Environment.MachineName != "Lenovo")
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    Definitely();
                } else
                {
                    Maybe();
                }
            } else
            {
                NotCompatible();
            }
            
        }

        private void NotCompatible()
        {
            string title = "Sorry!";
            string message = "Your pc is not eligible for rfl8apps and games, if you think if this is not yoga device, please contact us at (rfl8team.github.io)";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            label1.Text = "Not eligible for RFL8Apps and Games";
            label1.ForeColor = Color.Red;
        }

        private void Maybe()
        {
            string title = "Uh...";
            string message = "Your pc should be able to run RFL8Apps and Games but we don't recommend it because Windows installed in your computer is not 64 bits";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            label1.Text = "Some rfl8Apps and Games may not run";
            label1.ForeColor = Color.Yellow;
        }

        private void Definitely()
        {
            string title = "Congratulations!";
            string message = "Your pc is able to run RFL8Apps and Games with no problem!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            label1.Text = "Eligible for rfl8Apps and Games";
            label1.ForeColor = Color.Blue;
        }
    }
}
