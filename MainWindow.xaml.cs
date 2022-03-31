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

namespace CRMAgentieImobiliara
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    enum ActionState
    {
        New,
        Edit,
        Delete,
        Nothing
    }

    public partial class MainWindow : Window
    {
        ActionState Action = ActionState.Nothing;
        CRMAgentieImobiliaraEntitiesModel ctx = new CRMAgentieImobiliaraEntitiesModel();
        CollectionViewSource proprietatiVSource;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ///System.Windows.Data.CollectionViewSource proprietatiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("proprietatiViewSource")));
            proprietatiVSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("proprietatiViewSource")));
            proprietatiVSource.Source = ctx.Proprietatis.Local;
            ctx.Proprietatis.Load();
            // Load data by setting the CollectionViewSource.Source property:
            // proprietatiViewSource.Source = [generic data source]
        }

        private void btnProprietateNoua_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd windowAdd = new WindowAdd();
            windowAdd.Show();
            Action = ActionState.New;
        }

        private void btnProprietateEdit_Click(object sender, RoutedEventArgs e)
        {
            Action = ActionState.Edit;
        }

        private void btnProprietateStergere_Click(object sender, RoutedEventArgs e)
        {
            Action = ActionState.Delete;
        }




    }
}
