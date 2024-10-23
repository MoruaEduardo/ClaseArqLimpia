﻿using System.Timers;

namespace MVVMApp.ViewModel
{
    public class ClockViewModel
    {
        public System.Timers.Timer timmer {  get; set; }
        public string CurrentTime { get; set; } = DateTime.Now.ToString("hh:mm:ss");

        public string Name { get; set; }

        public ClockViewModel()
        {
            timmer = new System.Timers.Timer(1000);
            timmer.Elapsed += UpdateTime;
            timmer.Start();
        }

        public void UpdateTime(object sender, ElapsedEventArgs args)
        {
            this.CurrentTime = DateTime.Now.ToString("hh:mm:ss");
        }

        public void Dispose()
        {
            timmer.Dispose();
        }

    }
}
