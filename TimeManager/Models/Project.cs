using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Models
{
    public class Project : INotifyPropertyChanged
    {
        private string? name;
        private string? description;
        private TimeSpan? workTimeSpan = new TimeSpan();

        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Name { get => name; set { name = value; NotifyPropertyChanged("Name"); } }
        public string? Description { get => description; set { description = value; NotifyPropertyChanged("Description"); } }
        public TimeSpan? WorkTimeSpan { get => workTimeSpan; set => workTimeSpan = value; }
        public int WorkTimeSpanSec { get => Convert.ToInt32(workTimeSpan.Value.TotalSeconds); set { workTimeSpan = TimeSpan.FromSeconds(value);  } }
       // public int WorkTimeSpanSec { get ; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
