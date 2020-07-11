namespace SinglePageFormMenu
{
    partial class WinFormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btContacts = new System.Windows.Forms.Button();
            this.btPayment = new System.Windows.Forms.Button();
            this.btDelivery = new System.Windows.Forms.Button();
            this.btNutrition = new System.Windows.Forms.Button();
            this.btFranchise = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btInstagram = new System.Windows.Forms.Button();
            this.btTwitter = new System.Windows.Forms.Button();
            this.btFacebook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLoadCalabreza = new System.Windows.Forms.Button();
            this.BtEgg = new System.Windows.Forms.Button();
            this.btMortadela = new System.Windows.Forms.Button();
            this.deliveryControl1 = new SinglePageFormMenu.DeliveryControl();
            this.menuEnderecoControl2 = new SinglePageFormMenu.MenuEnderecoControl();
            this.menuContatoControl2 = new SinglePageFormMenu.MenuContatoControl();
            this.principalControl1 = new SinglePageFormMenu.PrincipalControl();
            this.menuPagamentoControl1 = new SinglePageFormMenu.MenuPagamentoControl();
            this.menuEnderecoControl1 = new SinglePageFormMenu.MenuEnderecoControl();
            this.menuContatoControl1 = new SinglePageFormMenu.MenuContatoControl();
            this.emConstrucaoControl1 = new SinglePageFormMenu.EmConstrucaoControl();
            this.mortadelaControl1 = new SinglePageFormMenu.MortadelaControl();
            this.eggControl1 = new SinglePageFormMenu.EggControl();
            this.calabrezaControl1 = new SinglePageFormMenu.CalabrezaControl();
            this.menuNutritionControl1 = new SinglePageFormMenu.MenuNutritionControl();
            this.emConstrucaoControl2 = new SinglePageFormMenu.EmConstrucaoControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btContacts);
            this.panel1.Controls.Add(this.btPayment);
            this.panel1.Controls.Add(this.btDelivery);
            this.panel1.Controls.Add(this.btNutrition);
            this.panel1.Controls.Add(this.btFranchise);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 549);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btContacts
            // 
            this.btContacts.FlatAppearance.BorderSize = 0;
            this.btContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContacts.ForeColor = System.Drawing.Color.White;
            this.btContacts.Image = ((System.Drawing.Image)(resources.GetObject("btContacts.Image")));
            this.btContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContacts.Location = new System.Drawing.Point(12, 439);
            this.btContacts.Name = "btContacts";
            this.btContacts.Size = new System.Drawing.Size(154, 54);
            this.btContacts.TabIndex = 26;
            this.btContacts.Text = "       Contacts";
            this.btContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btContacts.UseVisualStyleBackColor = true;
            this.btContacts.Click += new System.EventHandler(this.btContacts_Click);
            // 
            // btPayment
            // 
            this.btPayment.FlatAppearance.BorderSize = 0;
            this.btPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayment.ForeColor = System.Drawing.Color.White;
            this.btPayment.Image = ((System.Drawing.Image)(resources.GetObject("btPayment.Image")));
            this.btPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPayment.Location = new System.Drawing.Point(12, 379);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(154, 54);
            this.btPayment.TabIndex = 25;
            this.btPayment.Text = "       Payment";
            this.btPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPayment.UseVisualStyleBackColor = true;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click);
            // 
            // btDelivery
            // 
            this.btDelivery.FlatAppearance.BorderSize = 0;
            this.btDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelivery.ForeColor = System.Drawing.Color.White;
            this.btDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btDelivery.Image")));
            this.btDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelivery.Location = new System.Drawing.Point(12, 319);
            this.btDelivery.Name = "btDelivery";
            this.btDelivery.Size = new System.Drawing.Size(154, 54);
            this.btDelivery.TabIndex = 24;
            this.btDelivery.Text = "       Delivery";
            this.btDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelivery.UseVisualStyleBackColor = true;
            this.btDelivery.Click += new System.EventHandler(this.btDelivery_Click);
            // 
            // btNutrition
            // 
            this.btNutrition.FlatAppearance.BorderSize = 0;
            this.btNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNutrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNutrition.ForeColor = System.Drawing.Color.White;
            this.btNutrition.Image = ((System.Drawing.Image)(resources.GetObject("btNutrition.Image")));
            this.btNutrition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNutrition.Location = new System.Drawing.Point(12, 259);
            this.btNutrition.Name = "btNutrition";
            this.btNutrition.Size = new System.Drawing.Size(154, 54);
            this.btNutrition.TabIndex = 23;
            this.btNutrition.Text = "       Nutrition";
            this.btNutrition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNutrition.UseVisualStyleBackColor = true;
            this.btNutrition.Click += new System.EventHandler(this.btNutrition_Click);
            // 
            // btFranchise
            // 
            this.btFranchise.FlatAppearance.BorderSize = 0;
            this.btFranchise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFranchise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFranchise.ForeColor = System.Drawing.Color.White;
            this.btFranchise.Image = ((System.Drawing.Image)(resources.GetObject("btFranchise.Image")));
            this.btFranchise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFranchise.Location = new System.Drawing.Point(12, 199);
            this.btFranchise.Name = "btFranchise";
            this.btFranchise.Size = new System.Drawing.Size(154, 54);
            this.btFranchise.TabIndex = 14;
            this.btFranchise.Text = "       Franchise";
            this.btFranchise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFranchise.UseVisualStyleBackColor = true;
            this.btFranchise.Click += new System.EventHandler(this.btFranchise_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(74)))), ((int)(((byte)(161)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 139);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 13;
            // 
            // btHome
            // 
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(12, 139);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(154, 54);
            this.btHome.TabIndex = 12;
            this.btHome.Text = "       Home";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 114);
            this.label1.TabIndex = 22;
            this.label1.Text = "Your desire to eat...\r\nOur desire to see your hunger satisfied";
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(948, 28);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(42, 33);
            this.btSair.TabIndex = 17;
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btInstagram
            // 
            this.btInstagram.FlatAppearance.BorderSize = 0;
            this.btInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInstagram.ForeColor = System.Drawing.Color.White;
            this.btInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btInstagram.Image")));
            this.btInstagram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInstagram.Location = new System.Drawing.Point(894, 27);
            this.btInstagram.Name = "btInstagram";
            this.btInstagram.Size = new System.Drawing.Size(36, 34);
            this.btInstagram.TabIndex = 19;
            this.btInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInstagram.UseVisualStyleBackColor = true;
            this.btInstagram.Click += new System.EventHandler(this.btInstagram_Click);
            // 
            // btTwitter
            // 
            this.btTwitter.FlatAppearance.BorderSize = 0;
            this.btTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTwitter.ForeColor = System.Drawing.Color.White;
            this.btTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btTwitter.Image")));
            this.btTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTwitter.Location = new System.Drawing.Point(840, 27);
            this.btTwitter.Name = "btTwitter";
            this.btTwitter.Size = new System.Drawing.Size(36, 34);
            this.btTwitter.TabIndex = 20;
            this.btTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTwitter.UseVisualStyleBackColor = true;
            this.btTwitter.Click += new System.EventHandler(this.btTwitter_Click);
            // 
            // btFacebook
            // 
            this.btFacebook.FlatAppearance.BorderSize = 0;
            this.btFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacebook.ForeColor = System.Drawing.Color.White;
            this.btFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btFacebook.Image")));
            this.btFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFacebook.Location = new System.Drawing.Point(782, 27);
            this.btFacebook.Name = "btFacebook";
            this.btFacebook.Size = new System.Drawing.Size(36, 34);
            this.btFacebook.TabIndex = 21;
            this.btFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFacebook.UseVisualStyleBackColor = true;
            this.btFacebook.Click += new System.EventHandler(this.btFacebook_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(74)))), ((int)(((byte)(161)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 25);
            this.panel2.TabIndex = 23;
            // 
            // btLoadCalabreza
            // 
            this.btLoadCalabreza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btLoadCalabreza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadCalabreza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadCalabreza.ForeColor = System.Drawing.Color.White;
            this.btLoadCalabreza.Location = new System.Drawing.Point(296, 448);
            this.btLoadCalabreza.Name = "btLoadCalabreza";
            this.btLoadCalabreza.Size = new System.Drawing.Size(107, 26);
            this.btLoadCalabreza.TabIndex = 32;
            this.btLoadCalabreza.Text = "Read More";
            this.btLoadCalabreza.UseVisualStyleBackColor = false;
            this.btLoadCalabreza.Click += new System.EventHandler(this.btLoadCalabreza_Click);
            // 
            // BtEgg
            // 
            this.BtEgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.BtEgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEgg.ForeColor = System.Drawing.Color.White;
            this.BtEgg.Location = new System.Drawing.Point(563, 446);
            this.BtEgg.Name = "BtEgg";
            this.BtEgg.Size = new System.Drawing.Size(107, 26);
            this.BtEgg.TabIndex = 33;
            this.BtEgg.Text = "Read More";
            this.BtEgg.UseVisualStyleBackColor = false;
            this.BtEgg.Click += new System.EventHandler(this.BtEgg_Click);
            // 
            // btMortadela
            // 
            this.btMortadela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btMortadela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMortadela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMortadela.ForeColor = System.Drawing.Color.White;
            this.btMortadela.Location = new System.Drawing.Point(841, 448);
            this.btMortadela.Name = "btMortadela";
            this.btMortadela.Size = new System.Drawing.Size(107, 26);
            this.btMortadela.TabIndex = 34;
            this.btMortadela.Text = "Read More";
            this.btMortadela.UseVisualStyleBackColor = false;
            this.btMortadela.Click += new System.EventHandler(this.btMortadela_Click);
            // 
            // deliveryControl1
            // 
            this.deliveryControl1.Location = new System.Drawing.Point(173, 126);
            this.deliveryControl1.Name = "deliveryControl1";
            this.deliveryControl1.Size = new System.Drawing.Size(817, 423);
            this.deliveryControl1.TabIndex = 37;
            // 
            // menuEnderecoControl2
            // 
            this.menuEnderecoControl2.Location = new System.Drawing.Point(173, 126);
            this.menuEnderecoControl2.Name = "menuEnderecoControl2";
            this.menuEnderecoControl2.Size = new System.Drawing.Size(817, 423);
            this.menuEnderecoControl2.TabIndex = 36;
            // 
            // menuContatoControl2
            // 
            this.menuContatoControl2.Location = new System.Drawing.Point(173, 126);
            this.menuContatoControl2.Name = "menuContatoControl2";
            this.menuContatoControl2.Size = new System.Drawing.Size(817, 423);
            this.menuContatoControl2.TabIndex = 35;
            // 
            // principalControl1
            // 
            this.principalControl1.Location = new System.Drawing.Point(173, 126);
            this.principalControl1.Name = "principalControl1";
            this.principalControl1.Size = new System.Drawing.Size(817, 423);
            this.principalControl1.TabIndex = 31;
            // 
            // menuPagamentoControl1
            // 
            this.menuPagamentoControl1.Location = new System.Drawing.Point(173, 126);
            this.menuPagamentoControl1.Name = "menuPagamentoControl1";
            this.menuPagamentoControl1.Size = new System.Drawing.Size(817, 423);
            this.menuPagamentoControl1.TabIndex = 30;
            // 
            // menuEnderecoControl1
            // 
            this.menuEnderecoControl1.Location = new System.Drawing.Point(173, 126);
            this.menuEnderecoControl1.Name = "menuEnderecoControl1";
            this.menuEnderecoControl1.Size = new System.Drawing.Size(817, 423);
            this.menuEnderecoControl1.TabIndex = 29;
            // 
            // menuContatoControl1
            // 
            this.menuContatoControl1.Location = new System.Drawing.Point(173, 126);
            this.menuContatoControl1.Name = "menuContatoControl1";
            this.menuContatoControl1.Size = new System.Drawing.Size(817, 423);
            this.menuContatoControl1.TabIndex = 28;
            // 
            // emConstrucaoControl1
            // 
            this.emConstrucaoControl1.Location = new System.Drawing.Point(173, 126);
            this.emConstrucaoControl1.Name = "emConstrucaoControl1";
            this.emConstrucaoControl1.Size = new System.Drawing.Size(817, 423);
            this.emConstrucaoControl1.TabIndex = 27;
            // 
            // mortadelaControl1
            // 
            this.mortadelaControl1.Location = new System.Drawing.Point(173, 126);
            this.mortadelaControl1.Name = "mortadelaControl1";
            this.mortadelaControl1.Size = new System.Drawing.Size(817, 423);
            this.mortadelaControl1.TabIndex = 26;
            // 
            // eggControl1
            // 
            this.eggControl1.Location = new System.Drawing.Point(173, 126);
            this.eggControl1.Name = "eggControl1";
            this.eggControl1.Size = new System.Drawing.Size(817, 423);
            this.eggControl1.TabIndex = 25;
            // 
            // calabrezaControl1
            // 
            this.calabrezaControl1.Location = new System.Drawing.Point(173, 126);
            this.calabrezaControl1.Name = "calabrezaControl1";
            this.calabrezaControl1.Size = new System.Drawing.Size(817, 423);
            this.calabrezaControl1.TabIndex = 24;
            // 
            // menuNutritionControl1
            // 
            this.menuNutritionControl1.Location = new System.Drawing.Point(173, 126);
            this.menuNutritionControl1.Name = "menuNutritionControl1";
            this.menuNutritionControl1.Size = new System.Drawing.Size(817, 423);
            this.menuNutritionControl1.TabIndex = 38;
            // 
            // emConstrucaoControl2
            // 
            this.emConstrucaoControl2.Location = new System.Drawing.Point(173, 126);
            this.emConstrucaoControl2.Name = "emConstrucaoControl2";
            this.emConstrucaoControl2.Size = new System.Drawing.Size(817, 423);
            this.emConstrucaoControl2.TabIndex = 39;
            // 
            // WinFormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 549);
            this.Controls.Add(this.emConstrucaoControl2);
            this.Controls.Add(this.menuNutritionControl1);
            this.Controls.Add(this.deliveryControl1);
            this.Controls.Add(this.menuEnderecoControl2);
            this.Controls.Add(this.menuContatoControl2);
            this.Controls.Add(this.btMortadela);
            this.Controls.Add(this.BtEgg);
            this.Controls.Add(this.btLoadCalabreza);
            this.Controls.Add(this.principalControl1);
            this.Controls.Add(this.menuPagamentoControl1);
            this.Controls.Add(this.menuEnderecoControl1);
            this.Controls.Add(this.menuContatoControl1);
            this.Controls.Add(this.emConstrucaoControl1);
            this.Controls.Add(this.mortadelaControl1);
            this.Controls.Add(this.eggControl1);
            this.Controls.Add(this.calabrezaControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btInstagram);
            this.Controls.Add(this.btTwitter);
            this.Controls.Add(this.btFacebook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinFormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btInstagram;
        private System.Windows.Forms.Button btTwitter;
        private System.Windows.Forms.Button btFacebook;
        private System.Windows.Forms.Button btContacts;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Button btDelivery;
        private System.Windows.Forms.Button btNutrition;
        private System.Windows.Forms.Button btFranchise;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel2;
        private CalabrezaControl calabrezaControl1;
        private EggControl eggControl1;
        private MortadelaControl mortadelaControl1;
        private EmConstrucaoControl emConstrucaoControl1;
        private MenuContatoControl menuContatoControl1;
        private MenuEnderecoControl menuEnderecoControl1;
        private MenuPagamentoControl menuPagamentoControl1;
        private PrincipalControl principalControl1;
        private System.Windows.Forms.Button btLoadCalabreza;
        private System.Windows.Forms.Button BtEgg;
        private System.Windows.Forms.Button btMortadela;
        private MenuContatoControl menuContatoControl2;
        private MenuEnderecoControl menuEnderecoControl2;
        private DeliveryControl deliveryControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MenuNutritionControl menuNutritionControl1;
        private EmConstrucaoControl emConstrucaoControl2;
    }
}

