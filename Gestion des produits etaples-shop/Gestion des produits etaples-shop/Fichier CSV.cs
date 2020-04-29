using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Gestion_des_produits_etaples_shop
{
    class Fichier_CSV
    {
        public struct STRUCT_CSV
        {
            public string ID;
            public string Type;
            public string UGS;
            public string Nom;
            public string Publie;
            public string Mis_en_avant;
            public string Visibilite_dans_le_catalogue;
            public string Description_courte;
            public string Description;
            public string Date_de_debut_de_promo;
            public string Date_de_fin_de_promo;
            public string etat_de_la_TVA;
            public string Classe_TVA;
            public string En_stock;
            public string Stock;
            public string Montant_de_stock_faible;
            public string Autoriser_les_commandes_de_produits_en_rupture;
            public string Vendre_individuellement;
            public string Poids_kg;
            public string Longueur_cm;
            public string Largeur_cm;
            public string Hauteur_cm;
            public string Autoriser_les_avis_clients;
            public string Note_de_lachat;
            public string Tarif_promo;
            public string Tarif_regulier;
            public string Categories;
            public string etiquettes;
            public string Classe_de_livraison;
            public string Images;
            public string Limite_de_telechargement;
            public string Jours_dexpiration_du_telechargement;
            public string Parent;
            public string Groupes_de_produits;
            public string Montee_en_gamme;
            public string Ventes_croisees;
            public string URL_externe;
            public string Libelle_du_bouton;
            public string Position;
            public string Nom_de_lattribut_1;
            public string Valeurs_de_lattribut_1;
            public string Attribut_1_visible;
            public string Attribut_1_global;
            public string Meta_product_360_image_gallery;
            public string Meta_woodmart_single_product_style;
            public string Meta_woodmart_thums_position;
            public string Meta_woodmart_product_design;
            public string Meta_woodmart_extra_content;
            public string Meta_woodmart_extra_position;
            public string Meta__woodmart_sguide_select;
            public string Meta__woodmart_total_stock_quantity;
            public string Meta__slide_template;
            public string Meta__rs_page_bg_color;
            public string Meta_woodmart_whb_header;
            public string Meta_woodmart_main_layout;
            public string Meta_woodmart_sidebar_width;
            public string Meta_woodmart_custom_sidebar;
            public string Meta_woodmart_product_background;
            public string Meta_woodmart_product_custom_tab_title;
            public string Meta_woodmart_product_custom_tab_content;
            public string Meta_woodmart_swatches_attribute;
            public string Meta_woodmart_product_video;
            public string Meta_woodmart_product_hashtag;
            public string Meta_wpb_vc_js_status;
            public string Meta_woodmart_new_label;
            public string Nom_de_lattribut_2;
            public string Valeurs_de_lattribut_2;
            public string Attribut_2_visible;
            public string Attribut_2_global;
            public string Nom_de_lattribut_3;
            public string Valeurs_de_lattribut_3;
            public string Attribut_3_visible;
            public string Attribut_3_global;
            public string Nom_de_lattribut_4;
            public string Valeurs_de_lattribut_4;
            public string Attribut_4_visible;
            public string Attribut_4_global;

        }

        //
        //PRODUITS SIMPLE
        //
        //
        private STRUCT_CSV InitProduitSimple()
        {
            STRUCT_CSV myStructCSV = new STRUCT_CSV();

            myStructCSV.ID = "";
            myStructCSV.Type = "simple";
            myStructCSV.UGS = "";
            myStructCSV.Nom = "";
            myStructCSV.Publie = "1";
            myStructCSV.Mis_en_avant = "0";
            myStructCSV.Visibilite_dans_le_catalogue = "visible";
            myStructCSV.Description_courte = "";
            myStructCSV.Description = "";
            myStructCSV.Date_de_debut_de_promo = "";
            myStructCSV.Date_de_fin_de_promo = "";
            myStructCSV.etat_de_la_TVA = "taxable";
            myStructCSV.Classe_TVA = "";
            myStructCSV.En_stock = "1";
            myStructCSV.Stock = "";
            myStructCSV.Montant_de_stock_faible = "";
            myStructCSV.Autoriser_les_commandes_de_produits_en_rupture = "0";
            myStructCSV.Vendre_individuellement = "0";
            myStructCSV.Poids_kg = "";
            myStructCSV.Longueur_cm = "";
            myStructCSV.Largeur_cm = "";
            myStructCSV.Hauteur_cm = "";
            myStructCSV.Autoriser_les_avis_clients = "0";
            myStructCSV.Note_de_lachat = "";
            myStructCSV.Tarif_promo = "";
            myStructCSV.Tarif_regulier = "";
            myStructCSV.Categories = "";
            myStructCSV.etiquettes = "";
            myStructCSV.Classe_de_livraison = "";
            myStructCSV.Images = "";
            myStructCSV.Limite_de_telechargement = "";
            myStructCSV.Jours_dexpiration_du_telechargement = "";
            myStructCSV.Parent = "";
            myStructCSV.Groupes_de_produits = "";
            myStructCSV.Montee_en_gamme = "";
            myStructCSV.Ventes_croisees = "";
            myStructCSV.URL_externe = "";
            myStructCSV.Libelle_du_bouton = "";
            myStructCSV.Position = "0";
            myStructCSV.Nom_de_lattribut_1 = "Boutique";
            myStructCSV.Valeurs_de_lattribut_1 = "";
            myStructCSV.Attribut_1_visible = "1";
            myStructCSV.Attribut_1_global = "1";
            myStructCSV.Meta_product_360_image_gallery = "";
            myStructCSV.Meta_woodmart_single_product_style = "inherit";
            myStructCSV.Meta_woodmart_thums_position = "inherit";
            myStructCSV.Meta_woodmart_product_design = "inherit";
            myStructCSV.Meta_woodmart_extra_content = "none";
            myStructCSV.Meta_woodmart_extra_position = "after";
            myStructCSV.Meta__woodmart_sguide_select = "none";
            myStructCSV.Meta__woodmart_total_stock_quantity = "";
            myStructCSV.Meta__slide_template = "";
            myStructCSV.Meta__rs_page_bg_color = "";
            myStructCSV.Meta_woodmart_whb_header = "none";
            myStructCSV.Meta_woodmart_main_layout = "default";
            myStructCSV.Meta_woodmart_sidebar_width = "default";
            myStructCSV.Meta_woodmart_custom_sidebar = "none";
            myStructCSV.Meta_woodmart_product_background = "";
            myStructCSV.Meta_woodmart_product_custom_tab_title = "";
            myStructCSV.Meta_woodmart_product_custom_tab_content = "";
            myStructCSV.Meta_woodmart_swatches_attribute = "";
            myStructCSV.Meta_woodmart_product_video = "";
            myStructCSV.Meta_woodmart_product_hashtag = "";
            myStructCSV.Meta_wpb_vc_js_status = "VRAI";
            myStructCSV.Meta_woodmart_new_label = "";
            myStructCSV.Nom_de_lattribut_2 = "";
            myStructCSV.Valeurs_de_lattribut_2 = "";
            myStructCSV.Attribut_2_visible = "";
            myStructCSV.Attribut_2_global = "";
            myStructCSV.Nom_de_lattribut_3 = "";
            myStructCSV.Valeurs_de_lattribut_3 = "";
            myStructCSV.Attribut_3_visible = "";
            myStructCSV.Attribut_3_global = "";
            myStructCSV.Nom_de_lattribut_4 = "";
            myStructCSV.Valeurs_de_lattribut_4 = "";
            myStructCSV.Attribut_4_visible = "";
            myStructCSV.Attribut_4_global = "";

            return myStructCSV;
        }
        //
        //PRODUITS VARIABLE
        //
        //
        private STRUCT_CSV InitProduitsVariable()
        {
            STRUCT_CSV myStructCSV = new STRUCT_CSV();

            myStructCSV.ID = "";
            myStructCSV.Type = "variable";
            myStructCSV.UGS = "";
            myStructCSV.Nom = "";
            myStructCSV.Publie = "1";
            myStructCSV.Mis_en_avant = "0";
            myStructCSV.Visibilite_dans_le_catalogue = "visible";
            myStructCSV.Description_courte = "";
            myStructCSV.Description = "";
            myStructCSV.Date_de_debut_de_promo = "";
            myStructCSV.Date_de_fin_de_promo = "";
            myStructCSV.etat_de_la_TVA = "taxable";
            myStructCSV.Classe_TVA = "";
            myStructCSV.En_stock = "1";
            myStructCSV.Stock = "1";
            myStructCSV.Montant_de_stock_faible = "";
            myStructCSV.Autoriser_les_commandes_de_produits_en_rupture = "0";
            myStructCSV.Vendre_individuellement = "0";
            myStructCSV.Poids_kg = "";
            myStructCSV.Longueur_cm = "";
            myStructCSV.Largeur_cm = "";
            myStructCSV.Hauteur_cm = "";
            myStructCSV.Autoriser_les_avis_clients = "0";
            myStructCSV.Note_de_lachat = "";
            myStructCSV.Tarif_promo = "";// Pas mettre sur la première ligne du produit
            myStructCSV.Tarif_regulier = "";// Pas mettre sur la première ligne du produit
            myStructCSV.Categories = "";// que sur la première Ligne
            myStructCSV.etiquettes = "";
            myStructCSV.Classe_de_livraison = "";
            myStructCSV.Images = ""; //que sur la première ligne
            myStructCSV.Limite_de_telechargement = "";
            myStructCSV.Jours_dexpiration_du_telechargement = "";
            myStructCSV.Parent = ""; 
            myStructCSV.Groupes_de_produits = "";
            myStructCSV.Montee_en_gamme = "";
            myStructCSV.Ventes_croisees = "";
            myStructCSV.URL_externe = "";
            myStructCSV.Libelle_du_bouton = "";
            myStructCSV.Position = "0";
            myStructCSV.Nom_de_lattribut_1 = "Boutique"; //mettre sur la variation le nom de la variation exemple Pointure
            myStructCSV.Valeurs_de_lattribut_1 = ""; //Nom de la boutique
            myStructCSV.Attribut_1_visible = "1"; // que sur le premier produit
            myStructCSV.Attribut_1_global = "1";
            myStructCSV.Meta_product_360_image_gallery = "";
            myStructCSV.Meta_woodmart_single_product_style = "inherit";
            myStructCSV.Meta_woodmart_thums_position = "inherit";               ////////Le reste est que sur la première ligne
            myStructCSV.Meta_woodmart_product_design = "inherit";
            myStructCSV.Meta_woodmart_extra_content = "none";
            myStructCSV.Meta_woodmart_extra_position = "after";
            myStructCSV.Meta__woodmart_sguide_select = "none";
            myStructCSV.Meta__woodmart_total_stock_quantity = "";
            myStructCSV.Meta__slide_template = "";
            myStructCSV.Meta__rs_page_bg_color = "";
            myStructCSV.Meta_woodmart_whb_header = "none";
            myStructCSV.Meta_woodmart_main_layout = "default";
            myStructCSV.Meta_woodmart_sidebar_width = "default";
            myStructCSV.Meta_woodmart_custom_sidebar = "none";
            myStructCSV.Meta_woodmart_product_background = "";
            myStructCSV.Meta_woodmart_product_custom_tab_title = ""; //A propos de 
            myStructCSV.Meta_woodmart_product_custom_tab_content = ""; // html block
            myStructCSV.Meta_woodmart_swatches_attribute = "";
            myStructCSV.Meta_woodmart_product_video = "";
            myStructCSV.Meta_woodmart_product_hashtag = "";
            myStructCSV.Meta_wpb_vc_js_status = "VRAI";
            myStructCSV.Meta_woodmart_new_label = "";
            myStructCSV.Nom_de_lattribut_2 = "";
            myStructCSV.Valeurs_de_lattribut_2 = "";
            myStructCSV.Attribut_2_visible = "";
            myStructCSV.Attribut_2_global = "";
            myStructCSV.Nom_de_lattribut_3 = "Taille"; //Mettre sur la première ligne le nom de l'attribut 
            myStructCSV.Valeurs_de_lattribut_3 = "";//Mettre les valeurs séparé d'une virgule sauf pour le dernier
            myStructCSV.Attribut_3_visible = "1";
            myStructCSV.Attribut_3_global = "1";
            myStructCSV.Nom_de_lattribut_4 = "";
            myStructCSV.Valeurs_de_lattribut_4 = "";
            myStructCSV.Attribut_4_visible = "";
            myStructCSV.Attribut_4_global = "";

            return myStructCSV;
        }

        private STRUCT_CSV initLigneVariable()
        {
            STRUCT_CSV myStructCSV = new STRUCT_CSV();

            myStructCSV.ID = "";
            myStructCSV.Type = "variable";
            myStructCSV.UGS = "";
            myStructCSV.Nom = ""; //nom premiere ligne + valeur attribut
            myStructCSV.Publie = "1";
            myStructCSV.Mis_en_avant = "0";
            myStructCSV.Visibilite_dans_le_catalogue = "visible";
            myStructCSV.Description_courte = "";
            myStructCSV.Description = "";
            myStructCSV.Date_de_debut_de_promo = "";
            myStructCSV.Date_de_fin_de_promo = "";
            myStructCSV.etat_de_la_TVA = "taxable";
            myStructCSV.Classe_TVA = "parent";
            myStructCSV.En_stock = "1";
            myStructCSV.Stock = "1";
            myStructCSV.Montant_de_stock_faible = "";
            myStructCSV.Autoriser_les_commandes_de_produits_en_rupture = "0";
            myStructCSV.Vendre_individuellement = "0";
            myStructCSV.Poids_kg = "";
            myStructCSV.Longueur_cm = "";
            myStructCSV.Largeur_cm = "";
            myStructCSV.Hauteur_cm = "";
            myStructCSV.Autoriser_les_avis_clients = "0";
            myStructCSV.Note_de_lachat = "";
            myStructCSV.Tarif_promo = "";// mettre le tarif
            myStructCSV.Tarif_regulier = "";//mettre le tarif
            myStructCSV.Categories = ""; 
            myStructCSV.etiquettes = "";
            myStructCSV.Classe_de_livraison = "";
            myStructCSV.Images = "";
            myStructCSV.Limite_de_telechargement = "";
            myStructCSV.Jours_dexpiration_du_telechargement = "";
            myStructCSV.Parent = ""; //Sur la variation mettre l'ugs du produit comme parent
            myStructCSV.Groupes_de_produits = "";
            myStructCSV.Montee_en_gamme = "";
            myStructCSV.Ventes_croisees = "";
            myStructCSV.URL_externe = "";
            myStructCSV.Libelle_du_bouton = "";
            myStructCSV.Position = ""; //Faire une boucle de 1 au nombre de variation 6 par exemple 0 est la première ligne du produit
            myStructCSV.Nom_de_lattribut_1 = "Taille"; //mettre sur la variation le nom de la variation exemple Pointure
            myStructCSV.Valeurs_de_lattribut_1 = ""; //mettre la valeur de la variation exemple 38
            myStructCSV.Attribut_1_visible = ""; 
            myStructCSV.Attribut_1_global = "1";
            myStructCSV.Meta_product_360_image_gallery = "";
            myStructCSV.Meta_woodmart_single_product_style = "";
            myStructCSV.Meta_woodmart_thums_position = "";              
            myStructCSV.Meta_woodmart_product_design = "";
            myStructCSV.Meta_woodmart_extra_content = "";
            myStructCSV.Meta_woodmart_extra_position = "";
            myStructCSV.Meta__woodmart_sguide_select = "";
            myStructCSV.Meta__woodmart_total_stock_quantity = "";
            myStructCSV.Meta__slide_template = "";
            myStructCSV.Meta__rs_page_bg_color = "";
            myStructCSV.Meta_woodmart_whb_header = "";
            myStructCSV.Meta_woodmart_main_layout = "";
            myStructCSV.Meta_woodmart_sidebar_width = "";
            myStructCSV.Meta_woodmart_custom_sidebar = "";
            myStructCSV.Meta_woodmart_product_background = "";
            myStructCSV.Meta_woodmart_product_custom_tab_title = "";
            myStructCSV.Meta_woodmart_product_custom_tab_content = "";
            myStructCSV.Meta_woodmart_swatches_attribute = "";
            myStructCSV.Meta_woodmart_product_video = "";
            myStructCSV.Meta_woodmart_product_hashtag = "";
            myStructCSV.Meta_wpb_vc_js_status = "";
            myStructCSV.Meta_woodmart_new_label = "";
            myStructCSV.Nom_de_lattribut_2 = "";
            myStructCSV.Valeurs_de_lattribut_2 = "";
            myStructCSV.Attribut_2_visible = "";
            myStructCSV.Attribut_2_global = "";
            myStructCSV.Nom_de_lattribut_3 = ""; 
            myStructCSV.Valeurs_de_lattribut_3 = "";
            myStructCSV.Attribut_3_visible = "";
            myStructCSV.Attribut_3_global = "";
            myStructCSV.Nom_de_lattribut_4 = "";
            myStructCSV.Valeurs_de_lattribut_4 = "";
            myStructCSV.Attribut_4_visible = "";
            myStructCSV.Attribut_4_global = "";

            return myStructCSV;
        }

        public void CreateSimpleProductCSV(RequeteSQL.STRUCT_BOUTIQUES myBoutique)
        {
            string NomDuFichier = @"C:\Users\Théo Perrin\Documents\Etaples-shopping\Gestion des produits etaples-shop\Fichier CSV\Royal Dentelle\EtaplesShopSimple.csv";
            string HeaderCSV = "ID;Type;UGS;Nom;Publié;Mis en avant ?;Visibilité dans le catalogue;Description courte;Description;Date de début de promo;Date de fin de promo;État de la TVA;Classe TVA;En stock ?;Stock;Montant de stock faible;Autoriser les commandes de produits en rupture ?;Vendre individuellement ?;Poids (kg);Longueur (cm);Largeur (cm);Hauteur (cm);Autoriser les avis clients ?;Note de l'achat;Tarif promo;Tarif régulier;Catégories;Étiquettes;Classe de livraison;Images;Limite de téléchargement;Jours d'expiration du téléchargement;Parent;Groupes de produits;Montée en gamme;Ventes croisées;URL externe;Libellé du bouton;Position;Nom de l'attribut 1;Valeur(s) de l'attribut 1;Attribut 1 visible;Attribut 1 global;Méta : _product_360_image_gallery;Méta : _woodmart_single_product_style;Méta : _woodmart_thums_position;Méta : _woodmart_product_design;Méta : _woodmart_extra_content;Méta : _woodmart_extra_position;Méta : woodmart_sguide_select;Méta : woodmart_total_stock_quantity;Méta : slide_template;Méta : rs_page_bg_color;Méta : _woodmart_whb_header;Méta : _woodmart_main_layout;Méta : _woodmart_sidebar_width;Méta : _woodmart_custom_sidebar;Méta : _woodmart_product-background;Méta : _woodmart_product_custom_tab_title;Méta : _woodmart_product_custom_tab_content;Méta : _woodmart_swatches_attribute;Méta : _woodmart_product_video;Méta : _woodmart_product_hashtag;Méta : _wpb_vc_js_status;Méta : _woodmart_new_label;Nom de l'attribut 2;Valeur(s) de l'attribut 2;Attribut 2 visible;Attribut 2 global;Nom de l'attribut 3;Valeur(s) de l'attribut 3;Attribut 3 visible;Attribut 3 global;Nom de l'attribut 4;Valeur(s) de l'attribut 4;Attribut 4 visible;Attribut 4 global";
            RequeteSQL requeteSQL = new RequeteSQL();
            RequeteSQL.STRUCT_PRODUITS myStructProduits = new RequeteSQL.STRUCT_PRODUITS();
            STRUCT_CSV myStructCSV = new STRUCT_CSV();
            int mois = DateTime.Now.Month;
            string strNouveaute = "";
            String strMois = "";

            if (mois < 10)
            {
                strMois = String.Format("0{0}", mois);
            }
            else
            {
                strMois = mois.ToString();
            }

            try
            {
                using (StreamWriter outputFile = new StreamWriter(NomDuFichier, false, Encoding.UTF8))
                {
                    outputFile.WriteLine(HeaderCSV);

                    if (requeteSQL.GetProduits(myBoutique.Id_BOUTIQUES) == true)
                    {
                        for (int i = 0; i < requeteSQL.myTableauDataProduits.Count; i++)
                        {
                            myStructProduits = (RequeteSQL.STRUCT_PRODUITS)requeteSQL.myTableauDataProduits[i];

                            if(myStructProduits.bType == false)
                            {
                                myStructCSV = InitProduitSimple();

                                myStructCSV.UGS = myBoutique.Code_BOUTIQUES + "-" + myStructProduits.Ugs;
                                myStructCSV.Nom = myStructProduits.Libelle;
                                myStructCSV.Description_courte = myStructProduits.Description;
                                myStructCSV.Description = myStructProduits.Description;
                                myStructCSV.Tarif_regulier = myStructProduits.Tarif_Regu;
                                myStructCSV.Tarif_promo = myStructProduits.Tarif_Promo;

                                if (myStructProduits.Nouveaute == true)
                                {
                                    strNouveaute = "on";
                                }
                                myStructCSV.Meta_woodmart_new_label = strNouveaute;// mettre en on

                                for (int j = 0; j < myStructProduits.iImage; j++)
                                {
                                    myStructCSV.Images += "https://www.etaples-shop.fr/wp-content/uploads/2020/" + strMois + "/" + myBoutique.Code_BOUTIQUES + "-" + myStructProduits.Ugs + "-" + (j + 1);

                                    if ((myStructProduits.iImage > 1) && ((j + 1) != myStructProduits.iImage))
                                    {
                                        myStructCSV.Images += ", ";
                                    }
                                }

                                myStructCSV.Valeurs_de_lattribut_1 = myBoutique.Nom_BOUTIQUES;
                                myStructCSV.Meta_woodmart_product_custom_tab_title = "A propos de " + myBoutique.Nom_BOUTIQUES;
                                myStructCSV.Meta_woodmart_product_custom_tab_content = "[html_block id=\"" + myBoutique.Html_Code_BOUTIQUES + "\"]";
                                myStructCSV.Categories = myStructProduits.Categories;

                                if (myStructProduits.Marques != "")
                                {
                                    myStructCSV.Nom_de_lattribut_2 = "Marque";
                                    myStructCSV.Valeurs_de_lattribut_2 = myStructProduits.Marques;
                                }

                                //outputFile.WriteLine(myStructProduits.Ugs + ";" + myStructProduits.Libelle + ";" + myStructProduits.Description + ";" + myStructProduits.Tarif_Regu + ";" + myStructProduits.Tarif_Promo + ";" + myStructProduits.Nouveaute);
                                outputFile.WriteLine(
                                    myStructCSV.ID + ";" +
                                    myStructCSV.Type + ";" +
                                    myStructCSV.UGS + ";" +
                                    myStructCSV.Nom + ";" +
                                    myStructCSV.Publie + ";" +
                                    myStructCSV.Mis_en_avant + ";" +
                                    myStructCSV.Visibilite_dans_le_catalogue + ";" +
                                    myStructCSV.Description_courte + ";" +
                                    myStructCSV.Description + ";" +
                                    myStructCSV.Date_de_debut_de_promo + ";" +
                                    myStructCSV.Date_de_fin_de_promo + ";" +
                                    myStructCSV.etat_de_la_TVA + ";" +
                                    myStructCSV.Classe_TVA + ";" +
                                    myStructCSV.En_stock + ";" +
                                    myStructCSV.Stock + ";" +
                                    myStructCSV.Montant_de_stock_faible + ";" +
                                    myStructCSV.Autoriser_les_commandes_de_produits_en_rupture + ";" +
                                    myStructCSV.Vendre_individuellement + ";" +
                                    myStructCSV.Poids_kg + ";" +
                                    myStructCSV.Longueur_cm + ";" +
                                    myStructCSV.Largeur_cm + ";" +
                                    myStructCSV.Hauteur_cm + ";" +
                                    myStructCSV.Autoriser_les_avis_clients + ";" +
                                    myStructCSV.Note_de_lachat + ";" +
                                    myStructCSV.Tarif_promo + ";" +
                                    myStructCSV.Tarif_regulier + ";" +
                                    myStructCSV.Categories + ";" +
                                    myStructCSV.etiquettes + ";" +
                                    myStructCSV.Classe_de_livraison + ";" +
                                    myStructCSV.Images + ";" +
                                    myStructCSV.Limite_de_telechargement + ";" +
                                    myStructCSV.Jours_dexpiration_du_telechargement + ";" +
                                    myStructCSV.Parent + ";" +
                                    myStructCSV.Groupes_de_produits + ";" +
                                    myStructCSV.Montee_en_gamme + ";" +
                                    myStructCSV.Ventes_croisees + ";" +
                                    myStructCSV.URL_externe + ";" +
                                    myStructCSV.Libelle_du_bouton + ";" +
                                    myStructCSV.Position + ";" +
                                    myStructCSV.Nom_de_lattribut_1 + ";" +
                                    myStructCSV.Valeurs_de_lattribut_1 + ";" +
                                    myStructCSV.Attribut_1_visible + ";" +
                                    myStructCSV.Attribut_1_global + ";" +
                                    myStructCSV.Meta_product_360_image_gallery + ";" +
                                    myStructCSV.Meta_woodmart_single_product_style + ";" +
                                    myStructCSV.Meta_woodmart_thums_position + ";" +
                                    myStructCSV.Meta_woodmart_product_design + ";" +
                                    myStructCSV.Meta_woodmart_extra_content + ";" +
                                    myStructCSV.Meta_woodmart_extra_position + ";" +
                                    myStructCSV.Meta__woodmart_sguide_select + ";" +
                                    myStructCSV.Meta__woodmart_total_stock_quantity + ";" +
                                    myStructCSV.Meta__slide_template + ";" +
                                    myStructCSV.Meta__rs_page_bg_color + ";" +
                                    myStructCSV.Meta_woodmart_whb_header + ";" +
                                    myStructCSV.Meta_woodmart_main_layout + ";" +
                                    myStructCSV.Meta_woodmart_sidebar_width + ";" +
                                    myStructCSV.Meta_woodmart_custom_sidebar + ";" +
                                    myStructCSV.Meta_woodmart_product_background + ";" +
                                    myStructCSV.Meta_woodmart_product_custom_tab_title + ";" +
                                    myStructCSV.Meta_woodmart_product_custom_tab_content + ";" +
                                    myStructCSV.Meta_woodmart_swatches_attribute + ";" +
                                    myStructCSV.Meta_woodmart_product_video + ";" +
                                    myStructCSV.Meta_woodmart_product_hashtag + ";" +
                                    myStructCSV.Meta_wpb_vc_js_status + ";" +
                                    myStructCSV.Meta_woodmart_new_label + ";" +
                                    myStructCSV.Nom_de_lattribut_2 + ";" +
                                    myStructCSV.Valeurs_de_lattribut_2 + ";" +
                                    myStructCSV.Attribut_2_visible + ";" +
                                    myStructCSV.Attribut_2_global + ";" +
                                    myStructCSV.Nom_de_lattribut_3 + ";" +
                                    myStructCSV.Valeurs_de_lattribut_3 + ";" +
                                    myStructCSV.Attribut_3_visible + ";" +
                                    myStructCSV.Attribut_3_global + ";" +
                                    myStructCSV.Nom_de_lattribut_4 + ";" +
                                    myStructCSV.Valeurs_de_lattribut_4 + ";" +
                                    myStructCSV.Attribut_4_visible + ";" +
                                    myStructCSV.Attribut_4_global
                                    );
                            }
                        }
                    }

                    //Créer le header
                    //Charger les données de la BDD
                    //Construire la ligne du csv
                    //Fonction pour le contenu
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
            //sw = null;
        }

        private void CreateFirstLineForProductVariable(StreamWriter outputFile, RequeteSQL.STRUCT_BOUTIQUES myBoutique, ArrayList myRequeteSQL)
        {
            STRUCT_CSV myStructCSV = new STRUCT_CSV();
            string strNouveaute = "";
            string strMois = "";
            int iMois = DateTime.Now.Month;
            RequeteSQL.STRUCT_PRODUITS_VARIABLES myStructProduitsVariables = new RequeteSQL.STRUCT_PRODUITS_VARIABLES();

            myStructProduitsVariables = (RequeteSQL.STRUCT_PRODUITS_VARIABLES)myRequeteSQL[0];  // Initialise la variable de type STRUCT avec ce qu'il y a en mémoire

            myStructCSV = InitProduitsVariable();       //Initialisation des données par défaut de la ligne CSV

            if (iMois < 10)
            {
                strMois = String.Format("0{0}", iMois);
            }
            else
            {
                strMois = iMois.ToString();
            }

            myStructCSV.UGS = myBoutique.Code_BOUTIQUES + "-" + myStructProduitsVariables.Ugs;
            myStructCSV.Nom = myStructProduitsVariables.Libelle;
            myStructCSV.Description_courte = myStructProduitsVariables.Description;
            myStructCSV.Description = myStructProduitsVariables.Description;

            if (myStructProduitsVariables.Nouveaute == true)
            {
                strNouveaute = "on";
            }
            myStructCSV.Meta_woodmart_new_label = strNouveaute;

            for (int j = 0; j < myStructProduitsVariables.iImage; j++)
            {
                myStructCSV.Images += "https://www.etaples-shop.fr/wp-content/uploads/2020/" + strMois + "/" + myBoutique.Code_BOUTIQUES + "-" + myStructProduitsVariables.Ugs + "-" + (j + 1);

                if ((myStructProduitsVariables.iImage > 1) && ((j + 1) != myStructProduitsVariables.iImage))
                {
                    myStructCSV.Images += ", ";
                }
            }

            myStructCSV.Valeurs_de_lattribut_1 = myBoutique.Nom_BOUTIQUES;
            myStructCSV.Meta_woodmart_product_custom_tab_title = "A propos de " + myBoutique.Nom_BOUTIQUES;
            myStructCSV.Meta_woodmart_product_custom_tab_content = "[html_block id=\"" + myBoutique.Html_Code_BOUTIQUES + "\"]";
            myStructCSV.Categories = myStructProduitsVariables.Categories;

            if (myStructProduitsVariables.Marques != "")
            {
                myStructCSV.Nom_de_lattribut_2 = "Marque";
                myStructCSV.Valeurs_de_lattribut_2 = myStructProduitsVariables.Marques;
                myStructCSV.Attribut_2_visible = "1";
                myStructCSV.Attribut_2_global = "1";

            }

            for (int j = 0; j < myRequeteSQL.Count; j++)//UTILISER j
            {
                myStructProduitsVariables = (RequeteSQL.STRUCT_PRODUITS_VARIABLES)myRequeteSQL[j];  // Initialise la variable de type STRUCT avec ce qu'il y a en mémoire

                myStructCSV.Valeurs_de_lattribut_3 += myStructProduitsVariables.strTaille;

                //                if ((myStructVariation.strTaille.Length > 1) && ((j + 1) != myStructVariation.strTaille.Length))

                if (j  == (myRequeteSQL.Count))
                {
                    myStructCSV.Valeurs_de_lattribut_3 += ", ";
                }
            }
            
            //outputFile.WriteLine(myStructProduits.Ugs + ";" + myStructProduits.Libelle + ";" + myStructProduits.Description + ";" + myStructProduits.Tarif_Regu + ";" + myStructProduits.Tarif_Promo + ";" + myStructProduits.Nouveaute);
            outputFile.WriteLine(
                myStructCSV.ID + ";" +
                myStructCSV.Type + ";" +
                myStructCSV.UGS + ";" +
                myStructCSV.Nom + ";" +
                myStructCSV.Publie + ";" +
                myStructCSV.Mis_en_avant + ";" +
                myStructCSV.Visibilite_dans_le_catalogue + ";" +
                myStructCSV.Description_courte + ";" +
                myStructCSV.Description + ";" +
                myStructCSV.Date_de_debut_de_promo + ";" +
                myStructCSV.Date_de_fin_de_promo + ";" +
                myStructCSV.etat_de_la_TVA + ";" +
                myStructCSV.Classe_TVA + ";" +
                myStructCSV.En_stock + ";" +
                myStructCSV.Stock + ";" +
                myStructCSV.Montant_de_stock_faible + ";" +
                myStructCSV.Autoriser_les_commandes_de_produits_en_rupture + ";" +
                myStructCSV.Vendre_individuellement + ";" +
                myStructCSV.Poids_kg + ";" +
                myStructCSV.Longueur_cm + ";" +
                myStructCSV.Largeur_cm + ";" +
                myStructCSV.Hauteur_cm + ";" +
                myStructCSV.Autoriser_les_avis_clients + ";" +
                myStructCSV.Note_de_lachat + ";" +
                myStructCSV.Tarif_promo + ";" +
                myStructCSV.Tarif_regulier + ";" +
                myStructCSV.Categories + ";" +
                myStructCSV.etiquettes + ";" +
                myStructCSV.Classe_de_livraison + ";" +
                myStructCSV.Images + ";" +
                myStructCSV.Limite_de_telechargement + ";" +
                myStructCSV.Jours_dexpiration_du_telechargement + ";" +
                myStructCSV.Parent + ";" +
                myStructCSV.Groupes_de_produits + ";" +
                myStructCSV.Montee_en_gamme + ";" +
                myStructCSV.Ventes_croisees + ";" +
                myStructCSV.URL_externe + ";" +
                myStructCSV.Libelle_du_bouton + ";" +
                myStructCSV.Position + ";" +
                myStructCSV.Nom_de_lattribut_1 + ";" +
                myStructCSV.Valeurs_de_lattribut_1 + ";" +
                myStructCSV.Attribut_1_visible + ";" +
                myStructCSV.Attribut_1_global + ";" +
                myStructCSV.Meta_product_360_image_gallery + ";" +
                myStructCSV.Meta_woodmart_single_product_style + ";" +
                myStructCSV.Meta_woodmart_thums_position + ";" +
                myStructCSV.Meta_woodmart_product_design + ";" +
                myStructCSV.Meta_woodmart_extra_content + ";" +
                myStructCSV.Meta_woodmart_extra_position + ";" +
                myStructCSV.Meta__woodmart_sguide_select + ";" +
                myStructCSV.Meta__woodmart_total_stock_quantity + ";" +
                myStructCSV.Meta__slide_template + ";" +
                myStructCSV.Meta__rs_page_bg_color + ";" +
                myStructCSV.Meta_woodmart_whb_header + ";" +
                myStructCSV.Meta_woodmart_main_layout + ";" +
                myStructCSV.Meta_woodmart_sidebar_width + ";" +
                myStructCSV.Meta_woodmart_custom_sidebar + ";" +
                myStructCSV.Meta_woodmart_product_background + ";" +
                myStructCSV.Meta_woodmart_product_custom_tab_title + ";" +
                myStructCSV.Meta_woodmart_product_custom_tab_content + ";" +
                myStructCSV.Meta_woodmart_swatches_attribute + ";" +
                myStructCSV.Meta_woodmart_product_video + ";" +
                myStructCSV.Meta_woodmart_product_hashtag + ";" +
                myStructCSV.Meta_wpb_vc_js_status + ";" +
                myStructCSV.Meta_woodmart_new_label + ";" +
                myStructCSV.Nom_de_lattribut_2 + ";" +
                myStructCSV.Valeurs_de_lattribut_2 + ";" +
                myStructCSV.Attribut_2_visible + ";" +
                myStructCSV.Attribut_2_global + ";" +
                myStructCSV.Nom_de_lattribut_3 + ";" +
                myStructCSV.Valeurs_de_lattribut_3 + ";" +
                myStructCSV.Attribut_3_visible + ";" +
                myStructCSV.Attribut_3_global + ";" +
                myStructCSV.Nom_de_lattribut_4 + ";" +
                myStructCSV.Valeurs_de_lattribut_4 + ";" +
                myStructCSV.Attribut_4_visible + ";" +
                myStructCSV.Attribut_4_global
                );
        }
 
        private void CreateLinesVariablesForProduct(StreamWriter outputFile, RequeteSQL.STRUCT_BOUTIQUES myBoutique, RequeteSQL.STRUCT_PRODUITS_VARIABLES myStructVariable, int iPosition)
        {
            STRUCT_CSV myStructCSV = new STRUCT_CSV();

            myStructCSV = initLigneVariable();

            myStructCSV.Nom = myStructVariable.Libelle + " - " + myStructVariable.strTaille;
            myStructCSV.Tarif_promo = myStructVariable.strTarif_Promo;
            myStructCSV.Tarif_regulier = myStructVariable.strTarif_Regu;
            myStructCSV.Parent = myBoutique.Code_BOUTIQUES + "-" + myStructVariable.Ugs;
            myStructCSV.Position = (iPosition + 1).ToString();
            myStructCSV.Valeurs_de_lattribut_1 = myStructVariable.strTaille;
            //myStructCSV = InitProduitsVariable();       //Initialisation des données par défaut de la ligne CSV

            //MAJ du Struc CVS (prix, promo)
            //Ecriture Fichier STRUCT CSV (writlen)
            outputFile.WriteLine(
             myStructCSV.ID + ";" +
             myStructCSV.Type + ";" +
             myStructCSV.UGS + ";" +
             myStructCSV.Nom + ";" +
             myStructCSV.Publie + ";" +
             myStructCSV.Mis_en_avant + ";" +
             myStructCSV.Visibilite_dans_le_catalogue + ";" +
             myStructCSV.Description_courte + ";" +
             myStructCSV.Description + ";" +
             myStructCSV.Date_de_debut_de_promo + ";" +
             myStructCSV.Date_de_fin_de_promo + ";" +
             myStructCSV.etat_de_la_TVA + ";" +
             myStructCSV.Classe_TVA + ";" +
             myStructCSV.En_stock + ";" +
             myStructCSV.Stock + ";" +
             myStructCSV.Montant_de_stock_faible + ";" +
             myStructCSV.Autoriser_les_commandes_de_produits_en_rupture + ";" +
             myStructCSV.Vendre_individuellement + ";" +
             myStructCSV.Poids_kg + ";" +
             myStructCSV.Longueur_cm + ";" +
             myStructCSV.Largeur_cm + ";" +
             myStructCSV.Hauteur_cm + ";" +
             myStructCSV.Autoriser_les_avis_clients + ";" +
             myStructCSV.Note_de_lachat + ";" +
             myStructCSV.Tarif_promo + ";" +
             myStructCSV.Tarif_regulier + ";" +
             myStructCSV.Categories + ";" +
             myStructCSV.etiquettes + ";" +
             myStructCSV.Classe_de_livraison + ";" +
             myStructCSV.Images + ";" +
             myStructCSV.Limite_de_telechargement + ";" +
             myStructCSV.Jours_dexpiration_du_telechargement + ";" +
             myStructCSV.Parent + ";" +
             myStructCSV.Groupes_de_produits + ";" +
             myStructCSV.Montee_en_gamme + ";" +
             myStructCSV.Ventes_croisees + ";" +
             myStructCSV.URL_externe + ";" +
             myStructCSV.Libelle_du_bouton + ";" +
             myStructCSV.Position + ";" +
             myStructCSV.Nom_de_lattribut_1 + ";" +
             myStructCSV.Valeurs_de_lattribut_1 + ";" +
             myStructCSV.Attribut_1_visible + ";" +
             myStructCSV.Attribut_1_global + ";" +
             myStructCSV.Meta_product_360_image_gallery + ";" +
             myStructCSV.Meta_woodmart_single_product_style + ";" +
             myStructCSV.Meta_woodmart_thums_position + ";" +
             myStructCSV.Meta_woodmart_product_design + ";" +
             myStructCSV.Meta_woodmart_extra_content + ";" +
             myStructCSV.Meta_woodmart_extra_position + ";" +
             myStructCSV.Meta__woodmart_sguide_select + ";" +
             myStructCSV.Meta__woodmart_total_stock_quantity + ";" +
             myStructCSV.Meta__slide_template + ";" +
             myStructCSV.Meta__rs_page_bg_color + ";" +
             myStructCSV.Meta_woodmart_whb_header + ";" +
             myStructCSV.Meta_woodmart_main_layout + ";" +
             myStructCSV.Meta_woodmart_sidebar_width + ";" +
             myStructCSV.Meta_woodmart_custom_sidebar + ";" +
             myStructCSV.Meta_woodmart_product_background + ";" +
             myStructCSV.Meta_woodmart_product_custom_tab_title + ";" +
             myStructCSV.Meta_woodmart_product_custom_tab_content + ";" +
             myStructCSV.Meta_woodmart_swatches_attribute + ";" +
             myStructCSV.Meta_woodmart_product_video + ";" +
             myStructCSV.Meta_woodmart_product_hashtag + ";" +
             myStructCSV.Meta_wpb_vc_js_status + ";" +
             myStructCSV.Meta_woodmart_new_label + ";" +
             myStructCSV.Nom_de_lattribut_2 + ";" +
             myStructCSV.Valeurs_de_lattribut_2 + ";" +
             myStructCSV.Attribut_2_visible + ";" +
             myStructCSV.Attribut_2_global + ";" +
             myStructCSV.Nom_de_lattribut_3 + ";" +
             myStructCSV.Valeurs_de_lattribut_3 + ";" +
             myStructCSV.Attribut_3_visible + ";" +
             myStructCSV.Attribut_3_global + ";" +
             myStructCSV.Nom_de_lattribut_4 + ";" +
             myStructCSV.Valeurs_de_lattribut_4 + ";" +
             myStructCSV.Attribut_4_visible + ";" +
             myStructCSV.Attribut_4_global
             );
        }

        public void CreateVariableProductCSV(RequeteSQL.STRUCT_BOUTIQUES myBoutique, int iIDProduit)
        {
            string NomDuFichier = @"C:\Users\Théo Perrin\Documents\Etaples-shopping\Gestion des produits etaples-shop\Fichier CSV\Royal Dentelle\EtaplesShopVariable.csv";
            string HeaderCSV = "ID;Type;UGS;Nom;Publié;Mis en avant ?;Visibilité dans le catalogue;Description courte;Description;Date de début de promo;Date de fin de promo;État de la TVA;Classe TVA;En stock ?;Stock;Montant de stock faible;Autoriser les commandes de produits en rupture ?;Vendre individuellement ?;Poids (kg);Longueur (cm);Largeur (cm);Hauteur (cm);Autoriser les avis clients ?;Note de l'achat;Tarif promo;Tarif régulier;Catégories;Étiquettes;Classe de livraison;Images;Limite de téléchargement;Jours d'expiration du téléchargement;Parent;Groupes de produits;Montée en gamme;Ventes croisées;URL externe;Libellé du bouton;Position;Nom de l'attribut 1;Valeur(s) de l'attribut 1;Attribut 1 visible;Attribut 1 global;Méta : _product_360_image_gallery;Méta : _woodmart_single_product_style;Méta : _woodmart_thums_position;Méta : _woodmart_product_design;Méta : _woodmart_extra_content;Méta : _woodmart_extra_position;Méta : woodmart_sguide_select;Méta : woodmart_total_stock_quantity;Méta : slide_template;Méta : rs_page_bg_color;Méta : _woodmart_whb_header;Méta : _woodmart_main_layout;Méta : _woodmart_sidebar_width;Méta : _woodmart_custom_sidebar;Méta : _woodmart_product-background;Méta : _woodmart_product_custom_tab_title;Méta : _woodmart_product_custom_tab_content;Méta : _woodmart_swatches_attribute;Méta : _woodmart_product_video;Méta : _woodmart_product_hashtag;Méta : _wpb_vc_js_status;Méta : _woodmart_new_label;Nom de l'attribut 2;Valeur(s) de l'attribut 2;Attribut 2 visible;Attribut 2 global;Nom de l'attribut 3;Valeur(s) de l'attribut 3;Attribut 3 visible;Attribut 3 global;Nom de l'attribut 4;Valeur(s) de l'attribut 4;Attribut 4 visible;Attribut 4 global";
            RequeteSQL requeteSQL = new RequeteSQL();
            RequeteSQL.STRUCT_PRODUITS_VARIABLES myStructProduitsVariables = new RequeteSQL.STRUCT_PRODUITS_VARIABLES();

            try
            {
                using (StreamWriter outputFile = new StreamWriter(NomDuFichier, false, Encoding.UTF8))
                {
                    outputFile.WriteLine(HeaderCSV);            //Création du Header

                    if (requeteSQL.GetProduitsVariables(iIDProduit) == true)   //Récupére la liste des produits avec leurs variations
                    {
                        CreateFirstLineForProductVariable(outputFile, myBoutique, requeteSQL.myTableauDataProduits);   //Création de la 1ère ligne du fichier CSV pour un produit Variable

                        for (int i = 0; i < requeteSQL.myTableauDataProduits.Count; i++)        // Lit en mémoire la requête SQL
                        {
                            myStructProduitsVariables = (RequeteSQL.STRUCT_PRODUITS_VARIABLES)requeteSQL.myTableauDataProduits[i];  // Initialise la variable de type STRUCT avec ce qu'il y a en mémoire
                            CreateLinesVariablesForProduct(outputFile, myBoutique, myStructProduitsVariables, i);      // Création de toutes les lignes suivantes qui sont les Variations
                        }
                    }

                    //Créer le header
                    //Charger les données de la BDD
                    //Construire la ligne du csv
                    //Fonction pour le contenu
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            //sw = null;
        }
    }
}
