using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2_MarkPredictionProgram
{

    

    class Assessments
    {
        private String assessmentName;
        private int assessmentWeight;
        private int assessmentMark;

        private int totalMark;

        List<int> average = new List<int>();



        private int totalcunt { get; set; }

        public int TotalMark
        {
            get { return totalMark; }
            set { totalMark = value; }
        }

        public String setAssessmentName
        {
            get { return this.assessmentName; }
            set{this.assessmentName = value;}
        }

        public int setAssessmentWeight
        {
            get { return this.assessmentWeight; }
            set { this.assessmentWeight = value;

            countMarks();
            
            }
        }

        public int setAssessmentMark
        {
            get { return this.setAssessmentMark; }
            set { this.assessmentMark = value;
            countMarks();
            }
        }

        public String getAsessmentName
        {
            get{
                return this.assessmentName;
            }
        }



        public int getAssessmentMark
        {
            get
            {
                return this.assessmentMark;
            }
        }

        public int getAssessmentWeight
        {
            get
            {
                return this.assessmentWeight;
            }
        }

        public void countMarks()
        {
          totalMark = (assessmentMark * assessmentWeight) / 100;
          
        }
    }



}
