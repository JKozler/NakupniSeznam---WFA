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
        List<Item> list = new List<Item>();
        int i = 0;
        int pointYADD = 75;
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
            a.Name = "Text" + i;
            a.Width = 250;
            CheckBox ch = new CheckBox();
            ch.Name = "Check" + i;
            Button btn = new Button();
            btn.Text = "Smazat";
            btn.Name = Convert.ToString(i);
            string s = btn.Name;
            btn.Location = new Point(pointXBtn, pointYText);
            btn.Click += new EventHandler(DynamicButton_Click);
            a.Location = new Point(pointXText, pointYText);
            ch.Location = new Point(pointXCheck, pointYText);
            panel2.Controls.Add(btn);
            panel2.Controls.Add(ch);
            panel2.Controls.Add(a);
            panel2.Show();
            pointYText += 25;
            pointYADD += 25;
            Item item = new Item(btn, a, ch);
            list.Add(item);
            AddClick.Location = new Point(35, pointYADD);
        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = 0;
            panel2.Controls.Remove(btn);
            for (int y = 0; y < list.Count; y++)
            {
                if (list[y].Btn.Name == btn.Name)
                {
                    panel2.Controls.Remove(list[y].Btn);
                    panel2.Controls.Remove(list[y].Check);
                    panel2.Controls.Remove(list[y].Text);
                    x = y;
                }
            }
            for (int y = x; y < list.Count; y++)
            {
                list[y].Btn.Location = new Point(list[y].Btn.Location.X, list[y].Btn.Location.Y - 25);
                list[y].Text.Location = new Point(list[y].Text.Location.X, list[y].Text.Location.Y - 25);
                list[y].Check.Location = new Point(list[y].Check.Location.X, list[y].Check.Location.Y - 25);
            }
            pointYText -= 25;
            pointYADD -= 25;
            AddClick.Location = new Point(35, pointYADD);
        }
    }
    class Item
    {
        public TextBox Text { get; set; }
        public CheckBox Check { get; set; }
        public Button Btn { get; set; }
        public Item(Button Btn, TextBox Text, CheckBox Check)
        {
            this.Check = Check;
            this.Btn = Btn;
            this.Text = Text;
        }
    }
}
