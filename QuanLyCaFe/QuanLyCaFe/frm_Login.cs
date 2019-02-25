using QuanLyCaFe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = tbx_TenDangNhap.Text;
            string password = tbx_PassWord.Text;
            if (Login(username, password))
            {
                frm_Table_Manager table = new frm_Table_Manager();
                this.Hide();
                table.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private bool Login(string username, string password)
        {

            return AccountDAO.Instance.Login(username, password);
        }
    }
}
