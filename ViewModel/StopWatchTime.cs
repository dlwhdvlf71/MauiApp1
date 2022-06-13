using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public class StopWatchTime : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        Stopwatch stopwatch = new Stopwatch();

        public string currentStopWatch 
        {
            get
            {
                TimeSpan ts = stopwatch.Elapsed;

                return String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }

            set
            {
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("currentStopWatch"));
                }
            } 
        }

        public StopWatchTime()
        {
            stopwatch.Start();

            

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.currentStopWatch = String.Empty;

                return true;
            });

            //Timer timer = new Timer(new TimerCallback((s) => this.currentStopWatch = String.Empty), null, 0, 1000);
            //Timer timer = new Timer(new TimerCallback((s) => this.currentStopWatch = String.Empty));

           
        }

    }
}
