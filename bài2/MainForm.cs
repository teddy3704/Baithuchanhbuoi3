using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông Báo");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("Bạn chọn giới tính Nữ ", "Thông Báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if(rdDO.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                    txtHopMau.BackColor= Color.Blue;

        }
    }
}
