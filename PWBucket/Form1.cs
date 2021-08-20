using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWBucket
{
    public partial class Form1 : Form
    {
        Color farbe;
        string ph = "Bitte Password eingeben";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            farbe = TBPasswordInput.ForeColor;
            TBPasswordInput.GotFocus += RemoveText;
            TBPasswordInput.LostFocus += AddText;
            TBPasswordInput.Text = ph;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void RemoveText(object sender, EventArgs e)
        {
            TBPasswordInput.ForeColor = farbe;
            TBPasswordInput.PasswordChar = '*';
            if (TBPasswordInput.Text == ph)
                TBPasswordInput.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TBPasswordInput.Text))
            {
                TBPasswordInput.ForeColor = Color.Gray;
                TBPasswordInput.Text = ph;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            var mainWindow = new MainWindow();
            mainWindow.Show();
            loginForm.Hide();
        }
    }
}
