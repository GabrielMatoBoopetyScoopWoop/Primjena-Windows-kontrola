using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjena_Windows_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunAProgramButton_Click(object sender, EventArgs e)
        {
            if(ProgramiComboBox.Text == "Notepad")
                System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
            else
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
        }

        private void VisibilitiyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VisibilitiyCheckBox.Checked == true)
                groupBox1.Visible = false;
            else
                groupBox1.Visible = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ProgramDescriptionTxt.Text = "";
            ProgramNameTxt.Text = "";
        }
        bool visible1 = false;
        private void File_Click(object sender, EventArgs e)
        {
            OpenButton.Visible = !visible1;
            SaveButton.Visible = !visible1;
            ExitButton.Visible = !visible1;
            visible1 = !visible1;
        }
        bool visible2 = false;
        private void EditButton_Click(object sender, EventArgs e)
        {
            TextButton.Visible = !visible2;
            FontButton.Visible = !visible2;
            OptionsButton.Visible = !visible2;
            visible2 = !visible2;
        }
        bool visible3 = false;
        private void ViewButton_Click(object sender, EventArgs e)
        {
            MessageButton.Visible = !visible3;
            visible3 = !visible3;
        }
        bool visible4 = false;
        private void HelpButton_Click(object sender, EventArgs e)
        {
            AboutButton.Visible = !visible4;
            visible4 = !visible4;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
