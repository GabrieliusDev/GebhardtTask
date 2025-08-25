using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.IO
{
    public  interface IOutput
    {
        public void PrintReport(Report report); 
        public void PrintSeparator();
    }
}
