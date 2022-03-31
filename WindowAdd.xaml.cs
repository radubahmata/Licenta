using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CRMAgentieImobiliaraModel;
using System.Data.Entity;
using CRMAgentieImobiliara;
using CRMAgentieImobiliaraModel;

namespace CRMAgentieImobiliara
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : MainWindow  
    {
         ActionState AddAction = base.action;
        public WindowAdd()
        {
            InitializeComponent();
        }

        private void btnAddProprietateNoua_Click(object sender, RoutedEventArgs e)
        {
            AddAction = ActionState.New;
        }


        /* private void SaveProprietate()
         {
             Proprietati proprietate = null;
             if (AddAction == ActionState.New)
             {
                 try
                 {
                     //instantiem Customer entity
                     /*
                     proprietate = new Proprietati()
                     {

                         //TipOferta = tipOfertaTextBox.Text.Trim();
                         //Nrtel = nrTelTextBox.Text.Trim();
                         TipProprietate = tipProprietateTextBox.Text.Trim();
                         Judet = judetTextBox.Text.Trim();
                     Oras = orasTextBox.Text.Trim();
                     Zona = zonaTextBox.Text.Trim();
                     Adresa = adresaTextBox.Text.Trim();
                     Amplasament = amplasamentTextBox.Text.Trim();
                         NrCamere = nrCamereTextBox.
                         NrBai
                         Etaj
                         SuprafataUtila
                         Compartimentare
                         LocuriParcare
                         Descriere
                         LinkOferta
                         Pret
                         //Imagini
                     };
                     //adaugam entitatea nou creata in context

                     customerVSource.View.Refresh();
                     //salvam modificarile
                     ctx.SaveChanges();
                 }
                 //using System.Data;
                 catch (DataException ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
 */
    }
}



