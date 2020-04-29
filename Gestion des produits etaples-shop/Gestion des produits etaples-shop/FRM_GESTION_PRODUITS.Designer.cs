namespace Gestion_des_produits_etaples_shop
{
    partial class FRM_GESTION_PRODUITS
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_CREATE_PRODUITS = new System.Windows.Forms.Button();
            this.BTN_UPDATE_PRODUITS = new System.Windows.Forms.Button();
            this.BTN_DELETE_PRODUITS = new System.Windows.Forms.Button();
            this.TXT_UGS = new System.Windows.Forms.TextBox();
            this.TXT_Libelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_DESCRIPTION = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_TARIF_REGU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_TARIF_PROMO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_NOUVEAUTE = new System.Windows.Forms.TextBox();
            this.LST_PRODUITS = new System.Windows.Forms.ListView();
            this.BTN_GENRATE_CSV = new System.Windows.Forms.Button();
            this.CMB_BOUTIQUES = new System.Windows.Forms.ComboBox();
            this.LBL_CODE_BOUTIQUE = new System.Windows.Forms.Label();
            this.TXT_NBR_IMAGE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_CATEGORIES = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_MARQUES = new System.Windows.Forms.TextBox();
            this.DATA_VARIATIONS = new System.Windows.Forms.DataGridView();
            this.Tailles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Couleurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pointures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif_Regu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif_Promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.CHK_TYPE = new System.Windows.Forms.CheckBox();
            this.GRP_VARIATION = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHK_NOUVEAUTE = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_VARIATIONS)).BeginInit();
            this.GRP_VARIATION.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CREATE_PRODUITS
            // 
            this.BTN_CREATE_PRODUITS.Location = new System.Drawing.Point(166, 610);
            this.BTN_CREATE_PRODUITS.Name = "BTN_CREATE_PRODUITS";
            this.BTN_CREATE_PRODUITS.Size = new System.Drawing.Size(75, 23);
            this.BTN_CREATE_PRODUITS.TabIndex = 0;
            this.BTN_CREATE_PRODUITS.Text = "Créer";
            this.BTN_CREATE_PRODUITS.UseVisualStyleBackColor = true;
            this.BTN_CREATE_PRODUITS.Click += new System.EventHandler(this.BTN_CREATE_PRODUITS_Click);
            // 
            // BTN_UPDATE_PRODUITS
            // 
            this.BTN_UPDATE_PRODUITS.Location = new System.Drawing.Point(4, 610);
            this.BTN_UPDATE_PRODUITS.Name = "BTN_UPDATE_PRODUITS";
            this.BTN_UPDATE_PRODUITS.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPDATE_PRODUITS.TabIndex = 1;
            this.BTN_UPDATE_PRODUITS.Text = "Modifier";
            this.BTN_UPDATE_PRODUITS.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_PRODUITS.Click += new System.EventHandler(this.BTN_UPDATE_PRODUITS_Click);
            // 
            // BTN_DELETE_PRODUITS
            // 
            this.BTN_DELETE_PRODUITS.Location = new System.Drawing.Point(85, 610);
            this.BTN_DELETE_PRODUITS.Name = "BTN_DELETE_PRODUITS";
            this.BTN_DELETE_PRODUITS.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE_PRODUITS.TabIndex = 2;
            this.BTN_DELETE_PRODUITS.Text = "Supprimer";
            this.BTN_DELETE_PRODUITS.UseVisualStyleBackColor = true;
            this.BTN_DELETE_PRODUITS.Click += new System.EventHandler(this.BTN_DELETE_PRODUITS_Click);
            // 
            // TXT_UGS
            // 
            this.TXT_UGS.Location = new System.Drawing.Point(55, 403);
            this.TXT_UGS.Name = "TXT_UGS";
            this.TXT_UGS.Size = new System.Drawing.Size(276, 20);
            this.TXT_UGS.TabIndex = 3;
            // 
            // TXT_Libelle
            // 
            this.TXT_Libelle.Location = new System.Drawing.Point(53, 438);
            this.TXT_Libelle.Name = "TXT_Libelle";
            this.TXT_Libelle.Size = new System.Drawing.Size(278, 20);
            this.TXT_Libelle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UGS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libellé :";
            // 
            // TXT_DESCRIPTION
            // 
            this.TXT_DESCRIPTION.Location = new System.Drawing.Point(74, 466);
            this.TXT_DESCRIPTION.Name = "TXT_DESCRIPTION";
            this.TXT_DESCRIPTION.Size = new System.Drawing.Size(322, 96);
            this.TXT_DESCRIPTION.TabIndex = 7;
            this.TXT_DESCRIPTION.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description :";
            // 
            // TXT_TARIF_REGU
            // 
            this.TXT_TARIF_REGU.Location = new System.Drawing.Point(497, 466);
            this.TXT_TARIF_REGU.Name = "TXT_TARIF_REGU";
            this.TXT_TARIF_REGU.Size = new System.Drawing.Size(58, 20);
            this.TXT_TARIF_REGU.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tarif Régulier :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarif Promo :";
            // 
            // TXT_TARIF_PROMO
            // 
            this.TXT_TARIF_PROMO.Location = new System.Drawing.Point(497, 506);
            this.TXT_TARIF_PROMO.Name = "TXT_TARIF_PROMO";
            this.TXT_TARIF_PROMO.Size = new System.Drawing.Size(58, 20);
            this.TXT_TARIF_PROMO.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nouveauté :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // TXT_NOUVEAUTE
            // 
            this.TXT_NOUVEAUTE.Location = new System.Drawing.Point(508, 399);
            this.TXT_NOUVEAUTE.Name = "TXT_NOUVEAUTE";
            this.TXT_NOUVEAUTE.Size = new System.Drawing.Size(47, 20);
            this.TXT_NOUVEAUTE.TabIndex = 24;
            // 
            // LST_PRODUITS
            // 
            this.LST_PRODUITS.FullRowSelect = true;
            this.LST_PRODUITS.GridLines = true;
            this.LST_PRODUITS.HideSelection = false;
            this.LST_PRODUITS.Location = new System.Drawing.Point(1, 17);
            this.LST_PRODUITS.MultiSelect = false;
            this.LST_PRODUITS.Name = "LST_PRODUITS";
            this.LST_PRODUITS.Size = new System.Drawing.Size(554, 367);
            this.LST_PRODUITS.TabIndex = 25;
            this.LST_PRODUITS.UseCompatibleStateImageBehavior = false;
            this.LST_PRODUITS.View = System.Windows.Forms.View.Details;
            this.LST_PRODUITS.SelectedIndexChanged += new System.EventHandler(this.LST_PRODUITS_SelectedIndexChanged);
            // 
            // BTN_GENRATE_CSV
            // 
            this.BTN_GENRATE_CSV.Location = new System.Drawing.Point(1132, 649);
            this.BTN_GENRATE_CSV.Name = "BTN_GENRATE_CSV";
            this.BTN_GENRATE_CSV.Size = new System.Drawing.Size(184, 31);
            this.BTN_GENRATE_CSV.TabIndex = 26;
            this.BTN_GENRATE_CSV.Text = "Générer le csv";
            this.BTN_GENRATE_CSV.UseVisualStyleBackColor = true;
            this.BTN_GENRATE_CSV.Click += new System.EventHandler(this.BTN_GENRATE_CSV_Click);
            // 
            // CMB_BOUTIQUES
            // 
            this.CMB_BOUTIQUES.FormattingEnabled = true;
            this.CMB_BOUTIQUES.Location = new System.Drawing.Point(62, 20);
            this.CMB_BOUTIQUES.Name = "CMB_BOUTIQUES";
            this.CMB_BOUTIQUES.Size = new System.Drawing.Size(297, 21);
            this.CMB_BOUTIQUES.TabIndex = 27;
            this.CMB_BOUTIQUES.SelectedIndexChanged += new System.EventHandler(this.CMB_BOUTIQUES_SelectedIndexChanged);
            // 
            // LBL_CODE_BOUTIQUE
            // 
            this.LBL_CODE_BOUTIQUE.AutoSize = true;
            this.LBL_CODE_BOUTIQUE.Location = new System.Drawing.Point(409, 30);
            this.LBL_CODE_BOUTIQUE.Name = "LBL_CODE_BOUTIQUE";
            this.LBL_CODE_BOUTIQUE.Size = new System.Drawing.Size(0, 13);
            this.LBL_CODE_BOUTIQUE.TabIndex = 28;
            // 
            // TXT_NBR_IMAGE
            // 
            this.TXT_NBR_IMAGE.Location = new System.Drawing.Point(497, 538);
            this.TXT_NBR_IMAGE.Name = "TXT_NBR_IMAGE";
            this.TXT_NBR_IMAGE.Size = new System.Drawing.Size(58, 20);
            this.TXT_NBR_IMAGE.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nombre d\'image :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Catégorie(s) :";
            // 
            // TXT_CATEGORIES
            // 
            this.TXT_CATEGORIES.Location = new System.Drawing.Point(283, 570);
            this.TXT_CATEGORIES.Name = "TXT_CATEGORIES";
            this.TXT_CATEGORIES.Size = new System.Drawing.Size(272, 20);
            this.TXT_CATEGORIES.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 573);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Marque(s) :";
            // 
            // TXT_MARQUES
            // 
            this.TXT_MARQUES.Location = new System.Drawing.Point(74, 568);
            this.TXT_MARQUES.Name = "TXT_MARQUES";
            this.TXT_MARQUES.Size = new System.Drawing.Size(114, 20);
            this.TXT_MARQUES.TabIndex = 34;
            // 
            // DATA_VARIATIONS
            // 
            this.DATA_VARIATIONS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_VARIATIONS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tailles,
            this.Poids,
            this.Couleurs,
            this.Pointures,
            this.Tarif_Regu,
            this.Tarif_Promo});
            this.DATA_VARIATIONS.Location = new System.Drawing.Point(12, 27);
            this.DATA_VARIATIONS.Name = "DATA_VARIATIONS";
            this.DATA_VARIATIONS.Size = new System.Drawing.Size(714, 367);
            this.DATA_VARIATIONS.TabIndex = 35;
            this.DATA_VARIATIONS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_VARIATIONS_CellContentClick);
            // 
            // Tailles
            // 
            this.Tailles.HeaderText = "Tailles";
            this.Tailles.Name = "Tailles";
            // 
            // Poids
            // 
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            // 
            // Couleurs
            // 
            this.Couleurs.HeaderText = "Couleurs";
            this.Couleurs.Name = "Couleurs";
            // 
            // Pointures
            // 
            this.Pointures.HeaderText = "Pointures";
            this.Pointures.Name = "Pointures";
            // 
            // Tarif_Regu
            // 
            this.Tarif_Regu.HeaderText = "Tarif Régu";
            this.Tarif_Regu.Name = "Tarif_Regu";
            // 
            // Tarif_Promo
            // 
            this.Tarif_Promo.HeaderText = "Tarif Promo";
            this.Tarif_Promo.Name = "Tarif_Promo";
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(585, 414);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(141, 33);
            this.BTN_SAVE.TabIndex = 36;
            this.BTN_SAVE.Text = "Sauvgarder les Variations";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // CHK_TYPE
            // 
            this.CHK_TYPE.AutoSize = true;
            this.CHK_TYPE.Location = new System.Drawing.Point(452, 437);
            this.CHK_TYPE.Name = "CHK_TYPE";
            this.CHK_TYPE.Size = new System.Drawing.Size(57, 17);
            this.CHK_TYPE.TabIndex = 38;
            this.CHK_TYPE.Text = "Simple";
            this.CHK_TYPE.UseVisualStyleBackColor = true;
            this.CHK_TYPE.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GRP_VARIATION
            // 
            this.GRP_VARIATION.Controls.Add(this.BTN_SAVE);
            this.GRP_VARIATION.Controls.Add(this.DATA_VARIATIONS);
            this.GRP_VARIATION.Enabled = false;
            this.GRP_VARIATION.Location = new System.Drawing.Point(582, 38);
            this.GRP_VARIATION.Name = "GRP_VARIATION";
            this.GRP_VARIATION.Size = new System.Drawing.Size(734, 462);
            this.GRP_VARIATION.TabIndex = 39;
            this.GRP_VARIATION.TabStop = false;
            this.GRP_VARIATION.Text = "Variation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHK_NOUVEAUTE);
            this.groupBox2.Controls.Add(this.CHK_TYPE);
            this.groupBox2.Controls.Add(this.TXT_MARQUES);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TXT_CATEGORIES);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_NBR_IMAGE);
            this.groupBox2.Controls.Add(this.LST_PRODUITS);
            this.groupBox2.Controls.Add(this.TXT_NOUVEAUTE);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXT_TARIF_PROMO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_TARIF_REGU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_DESCRIPTION);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXT_Libelle);
            this.groupBox2.Controls.Add(this.TXT_UGS);
            this.groupBox2.Controls.Add(this.BTN_DELETE_PRODUITS);
            this.groupBox2.Controls.Add(this.BTN_UPDATE_PRODUITS);
            this.groupBox2.Controls.Add(this.BTN_CREATE_PRODUITS);
            this.groupBox2.Location = new System.Drawing.Point(7, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 641);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simple";
            // 
            // CHK_NOUVEAUTE
            // 
            this.CHK_NOUVEAUTE.AutoSize = true;
            this.CHK_NOUVEAUTE.Location = new System.Drawing.Point(351, 402);
            this.CHK_NOUVEAUTE.Name = "CHK_NOUVEAUTE";
            this.CHK_NOUVEAUTE.Size = new System.Drawing.Size(79, 17);
            this.CHK_NOUVEAUTE.TabIndex = 39;
            this.CHK_NOUVEAUTE.Text = "Nouveauté";
            this.CHK_NOUVEAUTE.UseVisualStyleBackColor = true;
            this.CHK_NOUVEAUTE.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // FRM_GESTION_PRODUITS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GRP_VARIATION);
            this.Controls.Add(this.LBL_CODE_BOUTIQUE);
            this.Controls.Add(this.CMB_BOUTIQUES);
            this.Controls.Add(this.BTN_GENRATE_CSV);
            this.Name = "FRM_GESTION_PRODUITS";
            this.Text = "Gestion des produits";
            this.Load += new System.EventHandler(this.FRM_GESTION_PRODUITS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_VARIATIONS)).EndInit();
            this.GRP_VARIATION.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CREATE_PRODUITS;
        private System.Windows.Forms.Button BTN_UPDATE_PRODUITS;
        private System.Windows.Forms.Button BTN_DELETE_PRODUITS;
        private System.Windows.Forms.TextBox TXT_UGS;
        private System.Windows.Forms.TextBox TXT_Libelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TXT_DESCRIPTION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_TARIF_REGU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_TARIF_PROMO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_NOUVEAUTE;
        private System.Windows.Forms.ListView LST_PRODUITS;
        private System.Windows.Forms.Button BTN_GENRATE_CSV;
        private System.Windows.Forms.ComboBox CMB_BOUTIQUES;
        private System.Windows.Forms.Label LBL_CODE_BOUTIQUE;
        private System.Windows.Forms.TextBox TXT_NBR_IMAGE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_CATEGORIES;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_MARQUES;
        private System.Windows.Forms.DataGridView DATA_VARIATIONS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tailles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couleurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pointures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarif_Regu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarif_Promo;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.CheckBox CHK_TYPE;
        private System.Windows.Forms.GroupBox GRP_VARIATION;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CHK_NOUVEAUTE;
    }
}

