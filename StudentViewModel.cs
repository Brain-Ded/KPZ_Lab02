using KPZ_Lab02.Model;
using KPZ_Lab02_UI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KPZ_Lab02_UI.ViewModels
{
    public class StudentViewModel : ViewModelBase
    {

        public StudentViewModel()
        {
        }

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

        private ObservableDictionary<Subject, List<int>> _grades;
        public ObservableDictionary<Subject, List<int>> Grades
        {
            get
            {
                return this._grades;
            }
            set
            {
                this._grades = value;
                OnPropertyChanged("Grades");
            }
        }

        private ObservableDictionary<Subject, List<Status>> _gradesStatus;
        public ObservableDictionary<Subject, List<Status>> GradesStatus
        {
            get 
            { 
                return this._gradesStatus; 
            }
            set
            {
                this._gradesStatus = value;
                OnPropertyChanged("GradesStatus");
            }
        }
        private int _group;
        public int Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
                OnPropertyChanged("Group");
            }
        }
    }
}
