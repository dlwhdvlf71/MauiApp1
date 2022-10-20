using MauiApp1.Class;
using MauiApp1.Models;
using MauiApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Student = MauiApp1.Models.Student;

namespace MauiApp1.ViewModel
{
    public class StudentViewModel :INotifyPropertyChanged
    {
        private readonly StudentRepository studentRepository;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand InsertStudentCommand { get; private set; }


        private int _id;
        public int Id
        {
            get => _id; 
            set {
                this._id = value;
                OnPropertyChanged();
            } }

        private string _name;
        public string Name { get => _name; set {
                this._name = value;
                OnPropertyChanged();
            } }

        private int _age;
        public int Age { get => _age; set
            {
                this._age = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get
            {
                if(this._students is null)
                {
                    _students = new ObservableCollection<Student>();
                }

                return this._students;
            }

            set
            {
                this._students = value;
                OnPropertyChanged();
            }
        }


        public StudentViewModel()
        {
            studentRepository = new();

            InsertStudentCommand = new Command((model) =>
            {
                studentRepository.create((Student)model);
            });
        }

        private void GetStudentList()
        {
            List<Student> students = studentRepository.list();

            if(students is not null)
            {
                students.ForEach(x =>
                {
                    this.Students.Add(x);
                });
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
