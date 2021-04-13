using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INotifyProperty
{
    class Student:INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }



        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");  
            }
        }
        private string _fullName;


        public string FullName
        {
            get
            {
                return _name + " " + _lastName;
            }
            set
            { 
                _fullName = value;
                OnPropertyChanged("FullName");
            }

        }

        public Student(string name,string lastName)
        {
            Name = name;
            LastName = lastName;
            

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String porpertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(porpertyName));
            }
        }
        
    }   
}
