using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Apresentacao
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_sobre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void PbxFace_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/cadfacilsistemas");
        }

        private void PbxTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/MarcioItu");
        }

        private void PbxLinkdin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/marciosousaads/");
        }

        private void PbxInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/cadfacilsistemas/");
        }

        private void PbxBlog_Click(object sender, EventArgs e)
        {
            Process.Start("https://cadfacilsistemas.blogspot.com/");
        }
    }
}
