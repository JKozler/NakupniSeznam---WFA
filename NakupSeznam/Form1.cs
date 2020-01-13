using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NakupSeznam
{
    public partial class Form1 : Form
    {
        int i = 0;
        int pointXText = 30;
        int pointXBtn = 450;
        int pointXCheck = 340;
        int pointYText = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddClick_Click(object sender, EventArgs e)
        {
            i++;
            TextBox a = new TextBox();
            CheckBox ch = new CheckBox();
            Button btn = new Button();
            btn.Text = "Smazat";
            btn.Name = "Delete" + i;
            btn.Location = new Point(pointXBtn, pointYText);
            a.Location = new Point(pointXText, pointYText);
            ch.Location = new Point(pointXCheck, pointYText);
            panel2.Controls.Add(btn);
            panel2.Controls.Add(ch);
            panel2.Controls.Add(a);
            panel2.Show();
            pointYText += 25;
           
        }
    }
}
