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
    public partial class AddModuleForm : Form
    {
        //
        public delegate void moduleHandler(object myObject,
                          ModuleArg myArgs);

        public event moduleHandler moduleFormClose;
        //

        private TabPage level4Tab;
        private TabPage level5Tab;
        private TabPage level6Tab;

        //private int tempCreditAddFormLvl4;

        //private int counter;
        public Modules modules;

        int b;

        int tempCreditCounter;
        //
        AddAssessments myAssessments = new AddAssessments();


        //

        public AddModuleForm()
        {
            InitializeComponent();
            CenterToScreen();

        }


        public AddModuleForm(TabPage level4Tab, TabPage level5Tab, TabPage level6Tab, int tempCreditCounter)
        {
            InitializeComponent();
            this.level4Tab = level4Tab;
            this.level5Tab = level5Tab;
            this.level6Tab = level6Tab;
            this.tempCreditCounter = tempCreditCounter;

            //this.counter = counter;
            CenterToScreen();
        }

        int shiftDown;
        int joseCounter;

        int assCount;

        int pullDown;

        int abc;
      

        
        //ADD MODULE BUTTON
        private void setModuleBtn_Click(object sender, EventArgs e)
        {

            int credits15 = 15;
            int credits30 = 30;
            int temp;

            

            modules = new Modules();
            modules.setModuleName = moduleNameTxt.Text;
            modules.setModuleCredits = Int32.Parse(moduleCreditsTxt.Text);
            modules.setModuleCode = moduleCodeTxt.Text;

            if ((Int32.Parse(moduleCreditsTxt.Text) == credits15) || (Int32.Parse(moduleCreditsTxt.Text) == credits30))
            {
                //tempCreditAddFormLvl4 = tempCreditAddFormLvl4 + Int32.Parse(moduleCreditsTxt.Text);
                temp = tempCreditCounter + Int32.Parse(moduleCreditsTxt.Text);
             
                if (temp <= 120)
                {
                    AddAssessments ass = new AddAssessments(level4Tab, level5Tab, level6Tab, modules);
                    ass.moduleFormClose += new AddAssessments.moduleHandler(showMessage);
                    
                    ass.AutoSize = true;
                    ass.AutoScroll = true;

                    ass.modName = moduleNameTxt.Text;
                    ass.modCode = moduleCodeTxt.Text;
                    ass.modCredits = moduleCreditsTxt.Text;

                    ass.numofAssessments = Int32.Parse(numOfAssessmentsTxt.Text);

                    ass.setAssessments();

                    this.Hide();
                    ass.Show();
                }
                else { MessageBox.Show("TOTAL MODULE CREDITS MUST BE 120"+Environment.NewLine+"RE-ENTER THE CREDITS!"); 
                }

            }
            else
            {
                MessageBox.Show("  CREDITS MUST BE"+Environment.NewLine+"     15   OR   30");

            }
            

        }

        private void showMessage(object a, ModuleArg e)
        {
            this.modules = e.module;
            List<Assessments> temp = new List<Assessments>();
            temp = modules.AssessmentList;
            ModuleArg modArgs = new ModuleArg(modules);
            moduleFormClose(this, modArgs);
            this.Close();
        }

        protected void AddModuleControl_moduleRemoveBtn_Click(object sender, EventArgs e)
        {


        }

        private void AddModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numOfAssessments_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
