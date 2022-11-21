using KPZ_Lab02.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KPZ_Lab02_UI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            SubmitSubjectCommand = new Command(SubmitSubject);
        }

        private string _visibleControl = "Login";
        public string VisibleControl
        {
            get
            {
                return _visibleControl; 
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args) 
        {
            VisibleControl = args.ToString();
        }

        private ObservableCollection<StudentViewModel> _students;
        public ObservableCollection<StudentViewModel> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged("Students");
            }
        }

        public ICommand SubmitSubjectCommand { get; set; }
        public void SubmitSubject(object args)
        {
            SelectedStatus = Status.NotRated;
        }

        private Status _selectedStatus;
        public Status SelectedStatus
        {
            get
            {
                return _selectedStatus;
            }
            set
            {
                _selectedStatus = value;
                OnPropertyChanged("SelectedStatus");
            }
        }

        private ObservableCollection<TeacherViewModel> _teachers;
        public ObservableCollection<TeacherViewModel> Teachers
        {
            get
            {
                return _teachers;
            }
            set
            {
                _teachers = value;
                OnPropertyChanged("Teachers");
            }
        }

        

        
    }
}
