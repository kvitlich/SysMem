using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMemory_Demonstrator
{
    public class DataLocator
    {
        private Process currentProccess;
        //PerformanceCounter performanceCounterCom;
        //PerformanceCounter performanceCounterApp;
        PerformanceCounter ramCounterCom;
        //PerformanceCounter ramCounterApp;
        public DataLocator()
        {
            currentProccess = Process.GetCurrentProcess();
            //performanceCounterCom = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //performanceCounterApp = new PerformanceCounter("Processor", "% Processor Time", currentProccess.ProcessName);
            ramCounterCom = new PerformanceCounter("Process", "Working Set", "_Total");
            //ramCounterApp = new PerformanceCounter("Process", "Working Set", currentProccess.ProcessName);
        }

        public long GetAppMemoryLoad()
        {
            return currentProccess.WorkingSet64;
        }

        public float GetComMemoryLoad()
        {
            return ramCounterCom.NextValue();
        }


        //decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
        //decimal percentOccupied = 100 - percentFree;
        //Console.WriteLine("Available Physical Memory (MiB) " + phav.ToString());
        //Console.WriteLine("Total Memory (MiB) " + tot.ToString());
        //Console.WriteLine("Free (%) " + percentFree.ToString());
        //Console.WriteLine("Occupied (%) " + percentOccupied.ToString());

    }
}
