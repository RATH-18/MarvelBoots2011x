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
    public partial class ParentForm : Form
    {
        public int EntityId { get; set; } = -1;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)

        {

            Application.Exit();

        }

        public void HideBackButton()

        {

            backButton.Visible = false;
        }

        public void SetTitle(string title)

        {

            this.Text = "\"Чудо Обувь\": " + title;

            this.titleLabel.Text = title;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }
    }
}
