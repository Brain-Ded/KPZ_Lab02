using KPZ_Lab02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab02_UI.ViewModels
{
    public class TeacherViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }           
        }
        private string _surname;
        public string Surname
        {
            get 
            {
                return _surname; 
            }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }
        //private List<Subject> _subjects;
        //public List<Subject> Subjects
        //{
        //    get 
        //    {
        //        return _subjects; 
        //    }
        //    set
        //    {
        //        _subjects = value;
        //        OnPropertyChanged("LeadingSubjects");
        //    }
        //}
    }
}
