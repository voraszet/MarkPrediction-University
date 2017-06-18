using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2_MarkPredictionProgram
{
    public class ModuleArg : EventArgs
    {
        private Modules modules;

        public ModuleArg(Modules module)    
        {
            this.modules = module;
        }



        public Modules module
        {
            get
            {
                return modules;
            }
            
        }
    }
}
