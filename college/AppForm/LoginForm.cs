using college.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college.AppForm
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            HideBackButton();
            SetTitle("Вход");
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo(new ProductListForm(), this);
        }
    }
}
