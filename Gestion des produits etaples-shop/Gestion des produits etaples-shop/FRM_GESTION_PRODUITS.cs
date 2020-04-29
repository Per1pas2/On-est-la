using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_produits_etaples_shop
{
    public partial class FRM_GESTION_PRODUITS : Form
    {
        RequeteSQL.STRUCT_BOUTIQUES myBoutiques = new RequeteSQL.STRUCT_BOUTIQUES();

        public FRM_GESTION_PRODUITS()
        {
            InitializeComponent();
        }
        private void Col(string strNomCol, int iNumCol, int iTailleCol)
        {
            ColumnHeader objColonne = new ColumnHeader();

            objColonne.Text = strNomCol;
            objColonne.Width = ((LST_PRODUITS.Width * iTailleCol) / 100);
            objColonne.TextAlign = HorizontalAlignment.Center;
            objColonne.Name = "Colonne " + iNumCol;
            LST_PRODUITS.Columns.Add(objColonne);

            objColonne = null;
        }

        private void BTN_CREATE_PRODUITS_Click(object sender, EventArgs e)
        {
            RequeteSQL requetesSQL = new RequeteSQL();
            int iType = 0;
            int iNouveaute = 0;

            if(CHK_TYPE.Checked == true)
            {
                iType = 1;
            }

            if(CHK_NOUVEAUTE.Checked == true)
            {
                iNouveaute = 1;
            }

            if (requetesSQL.InsertProduits(TXT_UGS.Text.Trim(), TXT_Libelle.Text.Trim(), TXT_DESCRIPTION.Text.Trim(), TXT_TARIF_REGU.Text.Trim(), TXT_TARIF_PROMO.Text.Trim(), iNouveaute, myBoutiques.Id_BOUTIQUES, int.Parse(TXT_NBR_IMAGE.Text.Trim()), TXT_CATEGORIES.Text.Trim(), TXT_MARQUES.Text.Trim(), iType) == true)
            {
                MessageBox.Show("Création OK");
                LoadLST(myBoutiques.Id_BOUTIQUES);
            }
            else
            {
                MessageBox.Show("Création pas pu effectuer");
            }

            requetesSQL = null;

        }

        private void BTN_DELETE_PRODUITS_Click(object sender, EventArgs e)
        {
            RequeteSQL requetesSQL = new RequeteSQL();

            if(LST_PRODUITS.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Souhaitez-vous supprimer le produit", "Supprimer Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (requetesSQL.DeleteProduits(int.Parse(LST_PRODUITS.SelectedItems[0].SubItems[0].Text)) == true)
                    {
                        MessageBox.Show("Suppression ok");
                        LoadLST(myBoutiques.Id_BOUTIQUES);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression");
                    }
                }

                requetesSQL = null;
            }
        }

        private void BTN_UPDATE_PRODUITS_Click(object sender, EventArgs e)
        {
            RequeteSQL requetesSQL = new RequeteSQL();
            int iType = 0;
            int iNouveaute = 0;

            if (CHK_TYPE.Checked == true)
            {
                iType = 1;
            }

            if (CHK_NOUVEAUTE.Checked == true)
            {
                iNouveaute = 1;
            }

            if (LST_PRODUITS.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Souhaitez-vous modifier le produit", "Modifier Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (requetesSQL.UpdateProduits(int.Parse(LST_PRODUITS.SelectedItems[0].SubItems[0].Text), TXT_UGS.Text, TXT_Libelle.Text, TXT_DESCRIPTION.Text, TXT_TARIF_REGU.Text, TXT_TARIF_PROMO.Text, iNouveaute, int.Parse(TXT_NBR_IMAGE.Text), TXT_CATEGORIES.Text, TXT_MARQUES.Text, iType) == true)
                    {
                        MessageBox.Show("Modification ok");
                        LoadLST(myBoutiques.Id_BOUTIQUES);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification");
                    }
                }

                requetesSQL = null;
            }
        }

        private void FRM_GESTION_PRODUITS_Load(object sender, EventArgs e)
        {
            LoadCMB();
        }
        private void LoadCMB()
        {
            RequeteSQL requeteSQL = new RequeteSQL();

            RequeteSQL.STRUCT_BOUTIQUES myStructBoutiques = new RequeteSQL.STRUCT_BOUTIQUES();

            if (requeteSQL.GetBoutiques() == true)
            {
                for (int i = 0; i < requeteSQL.myTableauDataProduits.Count; i++)
                {

                    myStructBoutiques = (RequeteSQL.STRUCT_BOUTIQUES)requeteSQL.myTableauDataProduits[i];

                    CMB_BOUTIQUES.Items.Add(myStructBoutiques.Id_BOUTIQUES.ToString() + "-" + myStructBoutiques.Nom_BOUTIQUES.ToString() + "-" + myStructBoutiques.Code_BOUTIQUES.ToString() + "-" + myStructBoutiques.Html_Code_BOUTIQUES.ToString());
                }
            }
        }
        private void LoadLST(int iId)
        {
            ListViewItem myListViewItem = new ListViewItem();
            RequeteSQL requeteSQL = new RequeteSQL();

            RequeteSQL.STRUCT_PRODUITS myStructProduits = new RequeteSQL.STRUCT_PRODUITS();

            LST_PRODUITS.Clear();

            Col("Id", 1, 5);
            Col("Ugs", 2, 10);
            Col("Libelleé", 3, 10);
            Col("Description", 4, 5);
            Col("Tarif régu", 5, 20);
            Col("Tarif promo", 6, 25);
            Col("Nouveauté", 7, 10);
            Col("Nombre d'Image", 8, 15);
            Col("Catégorie(s)", 9, 20);
            Col("Marque(s)", 10, 15);
            Col("Type", 11, 10);

            if (requeteSQL.GetProduits(iId) == true)
            {
                for (int i = 0; i < requeteSQL.myTableauDataProduits.Count; i++)
                {
                    myStructProduits = (RequeteSQL.STRUCT_PRODUITS)requeteSQL.myTableauDataProduits[i];

                    myListViewItem = new ListViewItem();

                    //myListViewItem.Tag = int.Parse(objRow["NUM_CODE_ROLE"].ToString());
                    myListViewItem.Text = myStructProduits.Id.ToString();
                    myListViewItem.SubItems.Add(myStructProduits.Ugs);
                    myListViewItem.SubItems.Add(myStructProduits.Libelle);
                    myListViewItem.SubItems.Add(myStructProduits.Description);
                    myListViewItem.SubItems.Add(myStructProduits.Tarif_Regu);
                    myListViewItem.SubItems.Add(myStructProduits.Tarif_Promo);
                    myListViewItem.SubItems.Add(myStructProduits.Nouveaute.ToString());
                    myListViewItem.SubItems.Add(myStructProduits.iImage.ToString());
                    myListViewItem.SubItems.Add(myStructProduits.Categories.ToString());
                    myListViewItem.SubItems.Add(myStructProduits.Marques.ToString());
                    myListViewItem.SubItems.Add(myStructProduits.bType.ToString());

                    LST_PRODUITS.Items.Add(myListViewItem);

                    myListViewItem = null;
                }
            }
            requeteSQL = null;
        }

        private void LST_PRODUITS_SelectedIndexChanged(object sender, EventArgs e)
        {

            RequeteSQL requeteSQL = new RequeteSQL();

            RequeteSQL.STRUCT_VARIATION myStructVariation = new RequeteSQL.STRUCT_VARIATION();

            DATA_VARIATIONS.Rows.Clear();

            if (LST_PRODUITS.SelectedItems.Count > 0)
            {
                TXT_UGS.Text = LST_PRODUITS.SelectedItems[0].SubItems[1].Text;
                TXT_Libelle.Text = LST_PRODUITS.SelectedItems[0].SubItems[2].Text;
                TXT_DESCRIPTION.Text = LST_PRODUITS.SelectedItems[0].SubItems[3].Text;
                TXT_TARIF_REGU.Text = LST_PRODUITS.SelectedItems[0].SubItems[4].Text;
                TXT_TARIF_PROMO.Text = LST_PRODUITS.SelectedItems[0].SubItems[5].Text;

                if(LST_PRODUITS.SelectedItems[0].SubItems[6].Text == "True")
                {
                    CHK_NOUVEAUTE.Checked = true;
                }
                else
                {
                    CHK_NOUVEAUTE.Checked = false;
                }
                TXT_NBR_IMAGE.Text = LST_PRODUITS.SelectedItems[0].SubItems[7].Text;
                TXT_CATEGORIES.Text = LST_PRODUITS.SelectedItems[0].SubItems[8].Text;
                TXT_MARQUES.Text = LST_PRODUITS.SelectedItems[0].SubItems[9].Text;
                CHK_TYPE.Checked = bool.Parse(LST_PRODUITS.SelectedItems[0].SubItems[10].Text);
                

                if (CHK_TYPE.Checked == true)
                {
                    if (requeteSQL.GetVariation(int.Parse(LST_PRODUITS.SelectedItems[0].SubItems[0].Text)) == true)
                    {
                        for (int i = 0; i < requeteSQL.myTableauDataProduits.Count; i++)
                        {
                            myStructVariation = (RequeteSQL.STRUCT_VARIATION)requeteSQL.myTableauDataProduits[i];
                            DATA_VARIATIONS.Rows.Add();

                            DATA_VARIATIONS.Rows[i].Cells[0].Value = myStructVariation.strTaille;
                            DATA_VARIATIONS.Rows[i].Cells[1].Value = myStructVariation.strPoids;
                            DATA_VARIATIONS.Rows[i].Cells[2].Value = myStructVariation.strCouleur;
                            DATA_VARIATIONS.Rows[i].Cells[3].Value = myStructVariation.strPointure;
                            DATA_VARIATIONS.Rows[i].Cells[4].Value = myStructVariation.strTarif_Regu;
                            DATA_VARIATIONS.Rows[i].Cells[5].Value = myStructVariation.strTarif_Promo;

                        }
                    }
                }
            }
            else
            {
                TXT_UGS.Text = "";
                TXT_Libelle.Text = "";
                TXT_DESCRIPTION.Text = "";
                TXT_TARIF_REGU.Text = "";
                TXT_TARIF_PROMO.Text = "";
                TXT_NOUVEAUTE.Text = "";
                TXT_NBR_IMAGE.Text = "";
                TXT_CATEGORIES.Text = "";
                TXT_MARQUES.Text = "";
            }     

        }

        private void BTN_GENRATE_CSV_Click(object sender, EventArgs e)
        {
            Fichier_CSV fichier_CSV = new Fichier_CSV();
            bool bType;
            int iIDProduit = 0;

            File.Delete(@"C:\Users\Théo Perrin\Documents\Etaples-shopping\Gestion des produits etaples-shop\Fichier CSV\Royal Dentelle\EtaplesShopSimple.csv");
            File.Delete(@"C:\Users\Théo Perrin\Documents\Etaples-shopping\Gestion des produits etaples-shop\Fichier CSV\Royal Dentelle\EtaplesShopVariable.csv");

            for(int i = 0; i < LST_PRODUITS.Items.Count; i++)
            {
                 bType  = bool.Parse(LST_PRODUITS.Items[i].SubItems[10].Text);

                if(bType == false)
                {
                    fichier_CSV.CreateSimpleProductCSV(myBoutiques);
                }
                else
                {
                    iIDProduit = int.Parse(LST_PRODUITS.Items[i].SubItems[0].Text);
                    fichier_CSV.CreateVariableProductCSV(myBoutiques, iIDProduit);
                }
            }
            // Delete 2 fichiers CSV  -> DeleteFilesCSV()

            //  Lire toutes les lignes de la ListView
            //  For chaque ligne
            //      Si produit = Simple
            //          CreateSImpeProduit (On met le paramètre APPEND dans la création du Fichier)
            //      Sinon
            //          CreateVariableProduit
            // Fin de Lecture

            //if(CHK_TYPE.Checked == true)
            //{
            //    fichier_CSV.CreateVariableProductCSV(myBoutiques);
            //}
            //else
            //{
            //    fichier_CSV.CreateSimpleProductCSV(myBoutiques);
            //}

            fichier_CSV = null;
        }

        private void CMB_BOUTIQUES_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLigne = "";
            string[] strBoutique; 

            if(CMB_BOUTIQUES.SelectedIndex >= 0)
            {
                strLigne = CMB_BOUTIQUES.SelectedItem.ToString();

                strBoutique = strLigne.Split('-');

                //myBoutiques.Id_BOUTIQUES = int.Parse(strLigne.Substring(0, strLigne.IndexOf(' ')));

                myBoutiques.Id_BOUTIQUES = int.Parse(strBoutique[0]);
                myBoutiques.Nom_BOUTIQUES = strBoutique[1];
                myBoutiques.Code_BOUTIQUES = strBoutique[2];
                myBoutiques.Html_Code_BOUTIQUES = int.Parse(strBoutique[3]);

                LBL_CODE_BOUTIQUE.Text = myBoutiques.Code_BOUTIQUES;

                LoadLST(myBoutiques.Id_BOUTIQUES);
            }
            else
            {
                myBoutiques.Id_BOUTIQUES = 0;
            }
        }

        private void DATA_VARIATIONS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CHK_TYPE.Checked == true)
            {
                CHK_TYPE.Text = "Variation";
                GRP_VARIATION.Enabled = true;
                TXT_TARIF_REGU.Enabled = false;
                TXT_TARIF_PROMO.Enabled = false;
            }
            else
            {
                CHK_TYPE.Text = "Simple";
                GRP_VARIATION.Enabled = false;
                TXT_TARIF_REGU.Enabled = true;
                TXT_TARIF_PROMO.Enabled = true;
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            bool bOk = true;
            RequeteSQL requeteSQL = new RequeteSQL();
            string strColonne0 = "";
            string strColonne1 = "";
            string strColonne2 = "";
            string strColonne3 = "";
            string strColonne4 = "";
            string strColonne5 = "";

            if (requeteSQL.DeleteVariation(int.Parse(LST_PRODUITS.SelectedItems[0].SubItems[0].Text)) == true)
            {
                for(int i =0; i < DATA_VARIATIONS.Rows.Count-1 ;i++)
                {
                    if (DATA_VARIATIONS.Rows[i].Cells[0].Value != null) strColonne0 = DATA_VARIATIONS.Rows[i].Cells[0].Value.ToString(); else strColonne0 = "";
                    if (DATA_VARIATIONS.Rows[i].Cells[1].Value != null) strColonne1 = DATA_VARIATIONS.Rows[i].Cells[1].Value.ToString(); else strColonne1 = "";
                    if (DATA_VARIATIONS.Rows[i].Cells[2].Value != null) strColonne2 = DATA_VARIATIONS.Rows[i].Cells[2].Value.ToString(); else strColonne2 = "";
                    if (DATA_VARIATIONS.Rows[i].Cells[3].Value != null) strColonne3 = DATA_VARIATIONS.Rows[i].Cells[3].Value.ToString(); else strColonne3 = "";
                    if (DATA_VARIATIONS.Rows[i].Cells[4].Value != null) strColonne4 = DATA_VARIATIONS.Rows[i].Cells[4].Value.ToString(); else strColonne4 = "";
                    if (DATA_VARIATIONS.Rows[i].Cells[5].Value != null) strColonne5 = DATA_VARIATIONS.Rows[i].Cells[5].Value.ToString(); else strColonne5 = "";

                    if (requeteSQL.InsertVariation(int.Parse(LST_PRODUITS.SelectedItems[0].SubItems[0].Text), strColonne0, strColonne1, strColonne2, strColonne3, strColonne4,strColonne5) == false)
                    {
                        MessageBox.Show("ERREURRR : Veuillez contacter le chef");
                        bOk = false;
                        break;
                    }
                }
                if(bOk == true)
                {
                    MessageBox.Show("Sauvergarde Ok !");
                }
            }
            else
            {
                MessageBox.Show("Erreur de Suppression");
            }
            //Je supprime les enregistrement avec id = produit //Méthode Suppression Variation by ID
            //Si Suppression OK alors
            //  Creation des lignes de variation dans BDD   //Creation Variation for ID
            //Sinon
            // Alerte()
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
