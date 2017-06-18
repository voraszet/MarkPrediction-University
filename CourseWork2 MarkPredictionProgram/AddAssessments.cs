using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2_MarkPredictionProgram
{
    public partial class AddAssessments : Form
    {
        public delegate void moduleHandler(object myObject,
                                  ModuleArg myArgs);

        public event moduleHandler moduleFormClose;

        private TabPage level4Tab;
        private TabPage level5Tab;
        private TabPage level6Tab;

        public Modules modules;

        public MainForm mainForm;

        AddModuleControl moduleDetails;
        int abc;

        int numAssessments;
        public String moduleNameNew;
        public String moduleCodeNew;
        public String moduleCreditsNew;

        //ASSESSMENT NAMES
        Label[] assessmentNameLbl;
        TextBox[] assessmentNameTxt;
        //ASSESSMENT WEIGHT %
        Label[] assessmentsWeightLbl;
        TextBox[] assessmentWeightTxt;
        //ASSESSMENT MARK INPUT
        Label[] assessmentMarkLbl;
        TextBox[] assessmentMarkTxt;

        Label[] assessmentName;

        double totalWeight;
        double totalMark;

        public AddAssessments()
        {
            InitializeComponent();
            CenterToScreen();
            
        }

        

        public AddAssessments(TabPage level4Tab, TabPage level5Tab, TabPage level6Tab, Modules modules)
        {
            this.level4Tab = level4Tab;
            this.level5Tab = level5Tab;
            this.level6Tab = level6Tab;
            this.modules = modules;
            InitializeComponent();
        }

        public String modName
        {
            get
            {
                return moduleNameNew;
            }
            set
            {
                moduleNameNew = value;
                moduleNameLabel.Text = moduleNameNew;
            }
        }

        public String modCode
        {
            get
            {
                return moduleCodeNew;
            }
            set
            {
                moduleCodeNew = value;
                moduleCodeLabel.Text = moduleCodeNew;
            }
        }

        public String modCredits
        {
            get
            {
                return moduleCreditsNew;
            }
            set
            {
                moduleCreditsNew = value;
                moduleCreditsLabel.Text = moduleCreditsNew;
            }
        }

        public int numofAssessments
        {
            get
            {
                return numAssessments;
            }

            set
            {
                numAssessments = value;
                Console.WriteLine("inside" + numofAssessments);
            }
        } 

        public void setAssessments()
        {

             assessmentNameLbl = new Label[numAssessments];
             assessmentNameTxt = new TextBox[numAssessments];
             assessmentsWeightLbl = new Label[numAssessments];
             assessmentWeightTxt = new TextBox[numAssessments];
             assessmentMarkLbl = new Label[numAssessments];
             assessmentMarkTxt = new TextBox[numAssessments];


            for (int i = 0; i < numAssessments; i++)
            {
                assessmentNameLbl[i] = new Label();
                assessmentNameTxt[i] = new TextBox();
                assessmentsWeightLbl[i] = new Label();
                assessmentWeightTxt[i] = new TextBox();
                assessmentMarkLbl[i] = new Label();
                assessmentMarkTxt[i] = new TextBox();

                assessmentNameLbl[i].AutoSize = true;
                assessmentNameLbl[i].Text = "Assesment Name" + (i + 1) + " : ";
                assessmentsWeightLbl[i].AutoSize = true;
                assessmentsWeightLbl[i].Text = "Assessment " + (i + 1) + " Weight % : ";
                assessmentMarkLbl[i].AutoSize = true;
                assessmentMarkLbl[i].Text = "Mark %";

                this.Controls.Add(assessmentNameLbl[i]);
                this.Controls.Add(assessmentNameTxt[i]);
                this.Controls.Add(assessmentsWeightLbl[i]);
                this.Controls.Add(assessmentWeightTxt[i]);
                this.Controls.Add(assessmentMarkLbl[i]);
                this.Controls.Add(assessmentMarkTxt[i]);

                assessmentNameLbl[i].Location = new System.Drawing.Point(50, 120 + abc);
                assessmentNameTxt[i].Location = new System.Drawing.Point(165, 120 + abc);
                assessmentsWeightLbl[i].Location = new System.Drawing.Point(270, 120 + abc);
                assessmentWeightTxt[i].Location = new System.Drawing.Point(410, 120 + abc);
                assessmentMarkLbl[i].Location = new System.Drawing.Point(515, 120 + abc);
                assessmentMarkTxt[i].Location = new System.Drawing.Point(560, 120 + abc);
                
                abc = abc + 30;
            }
        }

        private void AddAssessments_Load(object sender, EventArgs e)
        {
            

        }


        //SHIFT DOWN CONTROLLERS
        int shiftDown;
        
       
        //GENERATE BUTTON ON AddAssessmentsForm
        private void button1_Click(object sender, EventArgs e)
        {           
		    totalMark = 0;

            int errorDetector = 0;
            int weightDetector = 0;
            int weightCountDetector = 0;

            int goDown = 30;

            //moduleDetails = new AddModuleControl();
           

            Assessments assessments = new Assessments();

            //moduleDetails.modName = moduleNameNew;
            //moduleDetails.modCode = moduleCodeNew;
            //moduleDetails.modCredits = moduleCreditsNew;

            assessmentName = new Label[numAssessments];


            for (int i = 0; i < numAssessments; i++)
            {
                assessmentName[i] = new Label();
                assessmentName[i].AutoSize = true;
                assessmentName[i].Text = assessmentNameTxt[i].Text;
                //moduleDetails.Controls.Add(assessmentName[i]);
                assessmentName[i].Location = new System.Drawing.Point(300, goDown);
                goDown = goDown + 30;

                totalMark = double.Parse(assessmentMarkTxt[i].Text);
                totalWeight = totalWeight + double.Parse(assessmentWeightTxt[i].Text);

                if (totalMark > 100.00)
                {
                    errorDetector = 1;
                }

            }
            if (totalWeight > 100)
            {
                weightDetector = 1;
            }
            if (totalWeight != 100)
            {
                weightCountDetector = 1;
            }

            if (errorDetector == 1 || weightDetector == 1 || weightCountDetector == 1)
            {
                Console.WriteLine("ERRORS DETECTED");
                totalWeight = 0;
                totalMark = 0;
                weightCountDetector = 0;
            }
            else
            {
                for (int i = 0; i < numAssessments; i++)
                {

                    Assessments tempAssessment = new Assessments();
                    tempAssessment.setAssessmentName = assessmentNameTxt[i].Text;
                    tempAssessment.setAssessmentWeight = Int32.Parse(assessmentWeightTxt[i].Text);
                    tempAssessment.setAssessmentMark = Int32.Parse(assessmentMarkTxt[i].Text);
                    modules.AssessmentList.Add(tempAssessment);
                }

                goDown = 30;

                ////////////////////
                ModuleArg modArgs = new ModuleArg(modules);
                moduleFormClose(this, modArgs);
                ////////////////////
  
                this.Close();
            }
            
        }
        public void countUserControls()
        {
            for (int i = 0; i < level4Tab.Controls.Count; i++)
            {
                moduleDetails.Location = new Point(0, shiftDown);
                shiftDown = shiftDown + 170;
            }
        }
        protected void AddModuleControl_moduleRemoveBtn_Click(object sender, EventArgs e)
        {

            if (level4Tab.Controls.Count == 1)
            {
                level4Tab.Controls.Clear();
                Console.WriteLine("If zero, count" + level4Tab.Controls.Count);
            }
            else
            {
                int userControlIndex = (int)((AddModuleControl)sender).Tag;
                // Console.WriteLine("Tag" + x);
                level4Tab.Controls.RemoveAt(userControlIndex);
                Console.WriteLine("Not zero, count" + level4Tab.Controls.Count);
            }

            Console.WriteLine("BUTTONS WORKS");
            Console.WriteLine("UserControl count" + level4Tab.Controls.Count);
        }
    }
}
