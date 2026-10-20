namespace baitest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }   else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }    
        }
    }
}
