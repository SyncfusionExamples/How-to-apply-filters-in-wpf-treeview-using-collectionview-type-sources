using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SfTreeViewDemo
{
    public class FileManager : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        private ObservableCollection<FileManager> subFiles;
        private string fileDescription;

        #endregion

        #region Constructor
        public FileManager()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string FileDescription
        {
            get { return fileDescription; }
            set
            {
                fileDescription = value;
                RaisedOnPropertyChanged("FileDescription");
            }
        }
        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FileName");
            }
        }

        private Visibility visibility = Visibility.Visible;

        public Visibility Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                RaisedOnPropertyChanged("Visibility");
            }
        }


        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
