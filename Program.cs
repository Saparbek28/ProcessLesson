using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var calculatorProcess = Process.Start("calc");
            //Thread.Sleep(5000);
            //Console.WriteLine($"{calculatorProcess.Id}" + $"{calculatorProcess.ProcessName}" + $"{calculatorProcess.HasExited}");
            //Console.ReadLine(); 
            #endregion

            #region
            //грохнуть visual studio 
            var processes = Process.GetProcessesByName("devenv");// это грохнуть gmail )))), chrome это грохнуть хром ))
            foreach(var process in processes)
            {
                process.Kill();
            }
            #endregion

        }
    }
}
