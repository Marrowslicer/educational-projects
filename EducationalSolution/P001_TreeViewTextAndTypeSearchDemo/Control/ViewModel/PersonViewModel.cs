using System;
using System.Collections.ObjectModel;
using System.Linq;

using P000_Data.DataModel;

using P000_Framework;

namespace P001_TreeViewTextAndTypeSearchDemo.Control.ViewModel
{
    public class PersonViewModel : ObservableObject
    {
        private  ObservableCollection<PersonViewModel> m_children;
        private PersonViewModel m_parent;
        private Person m_person;

        private bool m_isVisible;
        private bool m_isExpanded;

        public PersonViewModel(Person person)
            : this(person, null)
        {
        }

        public PersonViewModel(Person person, PersonViewModel parent)
        {
            m_person = person;
            m_parent = parent;

            m_children = new ObservableCollection<PersonViewModel>
            (
                (from child in m_person.Children
                select new PersonViewModel(child, this)).ToList()
            );

            m_isVisible = true;
        }

        public string Name => m_person.Name;

        public ObservableCollection<PersonViewModel> Children => m_children;

        public bool IsVisible
        {
            get => m_isVisible;
            set
            {
                if (value != m_isVisible)
                {
                    m_isVisible = value;
                    OnPropertyChanged();
                }

                if (m_isVisible && m_parent != null)
                {
                    m_parent.IsVisible = true;
                }
            }
        }

        public bool IsExpanded
        {
            get => m_isExpanded;
            set
            {
                if (value != m_isExpanded)
                {
                    m_isExpanded = value;
                    OnPropertyChanged();
                }

                if (m_isExpanded && m_parent != null)
                {
                    m_parent.IsExpanded = true;
                }
            }
        }

        public bool HasSearchText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }

            return Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        public bool HasSearchProfession(Profession profession)
        {
            if (profession == Profession.Any)
            {
                return true;
            }

            return m_person.Profession == profession;
        }
    }
}
