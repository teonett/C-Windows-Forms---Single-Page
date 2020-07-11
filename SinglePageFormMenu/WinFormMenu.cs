using System;
using System.Windows.Forms;

namespace SinglePageFormMenu
{
    public partial class WinFormMenu : Form
    {
        public WinFormMenu()
        {
            InitializeComponent();

            SidePanel.Height = btHome.Height;
            SidePanel.Top = btHome.Top;

            principalControl1.BringToFront();
            btLoadCalabreza.BringToFront();
            BtEgg.BringToFront();
            btMortadela.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btHome.Height;
            SidePanel.Top = btHome.Top;

            principalControl1.BringToFront();
            btLoadCalabreza.BringToFront();
            BtEgg.BringToFront();
            btMortadela.BringToFront();
        }

        private void btFranchise_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btFranchise.Height;
            SidePanel.Top = btFranchise.Top;
            menuEnderecoControl1.BringToFront();
        }

        private void btLoadCalabreza_Click(object sender, EventArgs e)
        {
            calabrezaControl1.BringToFront();
            
        }

        private void BtEgg_Click(object sender, EventArgs e)
        {
            eggControl1.BringToFront();
        }

        private void btMortadela_Click(object sender, EventArgs e)
        {
            mortadelaControl1.BringToFront();
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btPayment.Height;
            SidePanel.Top = btPayment.Top;
            menuPagamentoControl1.BringToFront();
        }

        private void btContacts_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btContacts.Height;
            SidePanel.Top = btContacts.Top;
            menuContatoControl1.BringToFront();
        }

        private void btDelivery_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btDelivery.Height;
            SidePanel.Top = btDelivery.Top;
            deliveryControl1.BringToFront();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btNutrition_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btNutrition.Height;
            SidePanel.Top = btNutrition.Top;
            menuNutritionControl1.BringToFront();
        }

        private void btFacebook_Click(object sender, EventArgs e)
        {
            emConstrucaoControl1.BringToFront();
        }

        private void btTwitter_Click(object sender, EventArgs e)
        {
            emConstrucaoControl1.BringToFront();
        }

        private void btInstagram_Click(object sender, EventArgs e)
        {
            emConstrucaoControl1.BringToFront();
        }
    }
}
