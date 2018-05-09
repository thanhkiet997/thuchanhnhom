using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thanh công");
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thanh công");
        }

        private void btnnap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giao diện nạp tiền");
        }
    }
}
