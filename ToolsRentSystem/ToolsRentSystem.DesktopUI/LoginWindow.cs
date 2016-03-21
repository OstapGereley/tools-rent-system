using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsRentSystem.Repositories;

namespace ToolsRentSystem.DesktopUI
{
    public partial class LoginWindow : Form
    {
        public bool correctLogin;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbLogin.Text) && !String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                var login = tbLogin.Text;
                var password = tbPassword.Text;

                //creating hash
                var bytePassword = new UTF8Encoding().GetBytes(password);
                var md5Res = ((HashAlgorithm) CryptoConfig.CreateFromName("MD5")).ComputeHash(bytePassword);
                var resPassword = BitConverter.ToString(md5Res).Replace("-", String.Empty).ToLower();

                var operatorRepo = new SqlOperatorRepository(Globals.connectionString);

                //checking autorization
                correctLogin = operatorRepo.CheckLoginOperator(login, resPassword, out Globals.currentOperatorId);
            }
        }
    }
}
