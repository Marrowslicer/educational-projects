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

using P000_Data.DataAccess;

using P001_TreeViewTextAndTypeSearchDemo.Control.ViewModel;

namespace P001_TreeViewTextAndTypeSearchDemo.Control
{
    /// <summary>
    /// Interaction logic for TextAndTypeSearchDemoControl.xaml
    /// </summary>
    public partial class TextAndTypeSearchDemoControl : UserControl
    {
        public TextAndTypeSearchDemoControl()
        {
            InitializeComponent();
            var persons = Database.GetPersons();
            DataContext = new DemoControlViewModel(persons.Select(p => new PersonViewModel(p)));
        }
    }
}
