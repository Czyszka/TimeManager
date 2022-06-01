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

        public string? Name { get => name; set { name = value; NotifyPropertyChanged("Name"); } }
        public string? Description { get => description; set { description = value; NotifyPropertyChanged("Description"); } }
        public TimeSpan? WorkTimeSpan { get => workTimeSpan; set => workTimeSpan = value; }
        public int WotkTimeSpanSec { get => Convert.ToInt32(workTimeSpan.Value.TotalSeconds); }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
