using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btBai01_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai01 bai01 = new Bai01();
            bai01.Show();
        }

        private void btBai02_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai02 bai02 = new Bai02();
            bai02.Show();
        }

        private void btBai03_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai03 bai03 = new Bai03();
            bai03.Show();
        }

        private void btBai04_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 bai04 = new Bai04();
            bai04.Show();

        }
    }
}
