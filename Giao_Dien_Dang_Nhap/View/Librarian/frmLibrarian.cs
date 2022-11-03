using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Dang_Nhap
{
    public partial class frmLibrarian : Form
    {
        public frmLibrarian()
        {
            InitializeComponent();
        }

        private void frmLibrarian_Load(object sender, EventArgs e)
        {
            label1.Parent = guna2PictureBox2;
            label1.BackColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

 
      
    }
}
