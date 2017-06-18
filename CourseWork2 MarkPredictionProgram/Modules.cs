using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2_MarkPredictionProgram
{
   public class Modules
    {
        private String moduleName;
        private String moduleCode;
        private int moduleCredits;
        List<Assessments> assessmentList = new List<Assessments>();

        internal List<Assessments> AssessmentList
        {
            get { return assessmentList; }
            set { assessmentList = value; }
        }

        public String setModuleName
        {
            get
            {
                return moduleName;
            }
            set
            {
                moduleName = value;
            }
        }

        public String setModuleCode
        {
            get
            {
                return moduleCode;
            }
            set
            {
                moduleCode = value;
            }
        }

        public int setModuleCredits
        {
            get
            {
                return moduleCredits;
            }
            set
            {
                moduleCredits = value;
            }
        }


    }
}
