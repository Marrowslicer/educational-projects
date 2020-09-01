using System.Collections.Generic;
using System.Collections.ObjectModel;

using P000_Data.DataModel;

using P000_Framework;

namespace P001_TreeViewTextAndTypeSearchDemo.Control.ViewModel
{
    public class DemoControlViewModel : ObservableObject
    {
        private readonly ObservableCollection<PersonViewModel> m_itemsSource;
        private string m_searchText;
        private Profession m_searchProfession;

        public DemoControlViewModel(IEnumerable<PersonViewModel> itemsSource)
        {
            m_itemsSource = new ObservableCollection<PersonViewModel>(itemsSource);
            m_searchText = string.Empty;
        }

        public ObservableCollection<PersonViewModel> ItemsSource => m_itemsSource;

        public string SearchText
        {
            get => m_searchText;
            set
            {
                if (value != m_searchText)
                {
                    m_searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public Profession SearchProfession
        {
            get => m_searchProfession;
            set
            {
                if (value != m_searchProfession)
                {
                    m_searchProfession = value;
                    OnPropertyChanged();
                }
            }
        }

        public Profession[] ProfessionsSource => new Profession[]
        {
            Profession.Any,
            Profession.Actor,
            Profession.Development,
            Profession.Doctor,
            Profession.Fireman,
            Profession.Investigator,
            Profession.Policeman,
            Profession.Scientist,
            Profession.Seller,
            Profession.Teacher,
            Profession.Writer
        };
    }
}
