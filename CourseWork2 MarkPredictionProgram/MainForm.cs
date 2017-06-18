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
    public partial class MainForm : Form
    {

        List<Modules> modulesLevel4List = new List<Modules>();
        List<Modules> modulesLevel5List = new List<Modules>();
        List<Modules> modulesLevel6List = new List<Modules>();

        Label[] moduleNameLabel;
        Label[] moduleCodeLabel;
        Label[] moduleCreditsLabel;

        Label[] totalMarkLabelLvl4;
        Label[] totalMarkLabelLvl5;
        Label[] totalMarkLabelLvl6;

        //ASSESSMENT MANAGEMENT BUTTONS
        Button[] manageAssessmentsBtnLvl4;
        Button[] manageAssessmentsBtnLvl5;
        Button[] manageAssessmentsBtnLvl6;

        //REMOVE MODULES BUTTONS
        Button[] removeModuleBtnLvl4;
        Button[] removeModuleBtnLvl5;
        Button[] removeModuleBtnLvl6;

        Button saveAssessmentsLvl4;
        Button saveAssessmentsLvl5;
        Button saveAssessmentsLvl6;

        Button addAssessmentLvl4;
        Button addAssessmentLvl5;
        Button addAssessmentLvl6;

        Label[] AssessmentName;
        TextBox[] AssessmentMarkTextBox;
        TextBox[] AssessmentWeightTextBox;
        TextBox[] AssessmentNameText;

        int assessmentIndex;

        int tempMarklvl4 = 0;
        int tempMarklvl5 = 0;
        int tempMarklvl6 = 0;

        int totalCreditsLevel4 = 0;
        int totalCreditsLevel5 = 0;
        int totalCreditsLevel6 = 0;

        int tabLocationCounter = 0;

        //private int counter = 1;
        //ARRAYLIST HERE
        int tempCreditCounterLvl4;
        int tempCreditCounterLvl5;
        int tempCreditCounterLvl6;

        int creditValLvl4 = 0;
        int creditValLvl5 = 0;
        int creditValLvl6 = 0;

        int creditAverageCounterLvl4 = 0;
        int totalMarksLvl4 = 0;
        int markLvl4 = 0;
        int level4Average = 0;
        int temporaryL4 = 0;

        int credit15or30 = 0;


        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(String cName)
        {
            InitializeComponent();
            this.courseNameLbl.Text = cName;
            this.CenterToScreen();
            level4Tab.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab.SelectTab(0);
            levelLabel.Text = "Level 4";
            mainPageCredits.Text = creditValLvl4.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab.SelectTab(1);
            levelLabel.Text = "Level 5";
            mainPageCredits.Text = creditValLvl5.ToString();
            Console.WriteLine("LVL 5 CREDITS" + creditValLvl5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab.SelectTab(2);
            levelLabel.Text = "Level 6";
            mainPageCredits.Text = creditValLvl6.ToString();
            Console.WriteLine("LVL 6 CREDITS" + creditValLvl6);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addModuleBtn_Click(object sender, EventArgs e)
        {
            
            tempCreditCounterLvl4 = creditValLvl4;

            if (creditValLvl4 >= 120)
            {
                MessageBox.Show("MODULES ARE WORTH TOTAL CREDITS (120)");
            }
            else
            {
                AddModuleForm moduleForm = new AddModuleForm(level4Tab, level5Tab, level6Tab, tempCreditCounterLvl4);
                //moduleForm.moduleFormClose += new AddModuleForm.moduleHandler(showMessage);
                moduleForm.moduleFormClose += new AddModuleForm.moduleHandler(addLevel4);

                moduleForm.Show();
            }

        }

        private void level4Tab_Click(object sender, EventArgs e)
        {

        }

        private void showMessage(object a, ModuleArg e)
        {

        }


        private void addModuleLevel5_Click(object sender, EventArgs e)
        {
            tempCreditCounterLvl5 = creditValLvl5;

            if (creditValLvl5 >= 120)
            {
                MessageBox.Show("MODULES ARE WORTH TOTAL CREDITS (120)");
            }
            else
            {
                AddModuleForm moduleForm2 = new AddModuleForm(level4Tab, level5Tab, level6Tab, tempCreditCounterLvl5);
                moduleForm2.moduleFormClose += new AddModuleForm.moduleHandler(showMessage);
                moduleForm2.moduleFormClose += new AddModuleForm.moduleHandler(addLevel5);

                moduleForm2.Show();
            }
        }

        private void addModuleLevel6_Click(object sender, EventArgs e)
        {
            tempCreditCounterLvl6 = creditValLvl6;

            if (creditValLvl6 >= 120)
            {
                MessageBox.Show("MODULES ARE WORTH TOTAL CREDITS (120)");
            }
            else
            {
                AddModuleForm moduleForm3 = new AddModuleForm(level4Tab, level5Tab, level6Tab, tempCreditCounterLvl6);
                moduleForm3.moduleFormClose += new AddModuleForm.moduleHandler(showMessage);
                moduleForm3.moduleFormClose += new AddModuleForm.moduleHandler(addLevel6);

                moduleForm3.Show();
            }
        }

        private void addLevel4(object a, ModuleArg e)
        {
            level4Tab.Controls.Clear();

            this.modulesLevel4List.Add(e.module);

            if (e.module.setModuleCredits == 15)
            {
                creditAverageCounterLvl4 = creditAverageCounterLvl4 + 1;

            }
            if (e.module.setModuleCredits == 30)
            {
                creditAverageCounterLvl4 = creditAverageCounterLvl4 + 2;
            }

            setLevel4Labels();
           

            if (e.module.setModuleCredits == 15)
            {
               markLvl4 = markLvl4 + temporaryL4;
               credit15or30 = 0;
               Console.WriteLine("ASD" + markLvl4);
            }
            if (e.module.setModuleCredits == 30)
            {
                markLvl4 = (temporaryL4 * 2) + markLvl4;
                credit15or30 = 1;
                Console.WriteLine("BRR" + markLvl4);
            }

            
            level4Tab.Controls.Add(addModuleBtn);
        }

        public void setLevel4Labels()
        {
            int tempCredits = 0;

            moduleNameLabel = new Label[modulesLevel4List.Count];
            moduleCodeLabel = new Label[modulesLevel4List.Count];
            moduleCreditsLabel = new Label[modulesLevel4List.Count];
            totalMarkLabelLvl4 = new Label[modulesLevel4List.Count];
            manageAssessmentsBtnLvl4 = new Button[modulesLevel4List.Count];
            removeModuleBtnLvl4 = new Button[modulesLevel4List.Count];

            //MOVING LABELS DOWN
            tabLocationCounter = 30;

            for (int i = 0; i < modulesLevel4List.Count; i++)
            {
                moduleNameLabel[i] = new Label();
                moduleCodeLabel[i] = new Label();
                moduleCreditsLabel[i] = new Label();
                totalMarkLabelLvl4[i] = new Label();
                manageAssessmentsBtnLvl4[i] = new Button();
                removeModuleBtnLvl4[i] = new Button();

                manageAssessmentsBtnLvl4[i].Tag = i;
                removeModuleBtnLvl4[i].Tag = i;

                moduleNameLabel[i].Text = modulesLevel4List[i].setModuleName.ToString();
                moduleCodeLabel[i].Text = modulesLevel4List[i].setModuleCode.ToString();
                moduleCreditsLabel[i].Text = modulesLevel4List[i].setModuleCredits.ToString();

                tempCredits = tempCredits + Int32.Parse(modulesLevel4List[i].setModuleCredits.ToString());
                creditValLvl4 = tempCredits;

                int tempMarkLevel4 = 0;

                for (int b = 0; b < modulesLevel4List[i].AssessmentList.Count; b++)
                {
                    tempMarkLevel4 = tempMarkLevel4 + modulesLevel4List[i].AssessmentList[b].TotalMark;
                }

                totalMarkLabelLvl4[i].Text = tempMarkLevel4.ToString();
                //
                temporaryL4 = tempMarkLevel4;
                //
                
                tempMarkLevel4 = 0;

                manageAssessmentsBtnLvl4[i].Text = "Manage Assessments";
                removeModuleBtnLvl4[i].Text = "Remove";
                manageAssessmentsBtnLvl4[i].AutoSize = true;
                removeModuleBtnLvl4[i].AutoSize = true;

                moduleNameLabel[i].Location = new System.Drawing.Point(50, tabLocationCounter);
                moduleCodeLabel[i].Location = new System.Drawing.Point(150, tabLocationCounter);
                moduleCreditsLabel[i].Location = new System.Drawing.Point(250, tabLocationCounter);
                manageAssessmentsBtnLvl4[i].Location = new System.Drawing.Point(350, tabLocationCounter);
                totalMarkLabelLvl4[i].Location = new System.Drawing.Point(600, tabLocationCounter);
                removeModuleBtnLvl4[i].Location = new System.Drawing.Point(750, tabLocationCounter);
                tabLocationCounter = tabLocationCounter + 30;

                level4Tab.Controls.Add(moduleNameLabel[i]);
                level4Tab.Controls.Add(moduleCodeLabel[i]);
                level4Tab.Controls.Add(moduleCreditsLabel[i]);
                level4Tab.Controls.Add(manageAssessmentsBtnLvl4[i]);
                level4Tab.Controls.Add(totalMarkLabelLvl4[i]);
                level4Tab.Controls.Add(removeModuleBtnLvl4[i]);

                manageAssessmentsBtnLvl4[i].Click += new EventHandler(manageAsessmentsLvl4_Click);
                removeModuleBtnLvl4[i].Click += new EventHandler(removeModuleLvl4_Click);
            }


            creditValLvl4 = tempCredits;

            mainPageCredits.Text = tempCredits.ToString();

            levelLabel.Text = "Level 4";

            
        }

        public void setLevel5Labels()
        {
            int tempCredits = 0;

            moduleNameLabel = new Label[modulesLevel5List.Count];
            moduleCodeLabel = new Label[modulesLevel5List.Count];
            moduleCreditsLabel = new Label[modulesLevel5List.Count];
            totalMarkLabelLvl5 = new Label[modulesLevel5List.Count];
            manageAssessmentsBtnLvl5 = new Button[modulesLevel5List.Count];
            removeModuleBtnLvl5 = new Button[modulesLevel5List.Count];

            int tempMark = 0;

            tabLocationCounter = 30;

            for (int i = 0; i < modulesLevel5List.Count; i++)
            {

                moduleNameLabel[i] = new Label();
                moduleCodeLabel[i] = new Label();
                moduleCreditsLabel[i] = new Label();
                totalMarkLabelLvl5[i] = new Label();
                manageAssessmentsBtnLvl5[i] = new Button();
                removeModuleBtnLvl5[i] = new Button();

                manageAssessmentsBtnLvl5[i].Tag = i;
                removeModuleBtnLvl5[i].Tag = i;

                moduleNameLabel[i].Text = modulesLevel5List[i].setModuleName.ToString();
                moduleCodeLabel[i].Text = modulesLevel5List[i].setModuleCode.ToString();
                moduleCreditsLabel[i].Text = modulesLevel5List[i].setModuleCredits.ToString();

                tempCredits = tempCredits + Int32.Parse(modulesLevel5List[i].setModuleCredits.ToString());
                creditValLvl5 = tempCredits;

                for (int b = 0; b < modulesLevel5List[i].AssessmentList.Count; b++)
                {
                    tempMark = tempMark + modulesLevel5List[i].AssessmentList[b].TotalMark;
                }


                totalMarkLabelLvl5[i].Text = tempMark.ToString();
                tempMark = 0;

                manageAssessmentsBtnLvl5[i].Text = "Manage Assessments";
                removeModuleBtnLvl5[i].Text = "Remove";
                manageAssessmentsBtnLvl5[i].AutoSize = true;
                removeModuleBtnLvl5[i].AutoSize = true;

                moduleNameLabel[i].Location = new System.Drawing.Point(50, tabLocationCounter);
                moduleCodeLabel[i].Location = new System.Drawing.Point(150, tabLocationCounter);
                moduleCreditsLabel[i].Location = new System.Drawing.Point(250, tabLocationCounter);
                manageAssessmentsBtnLvl5[i].Location = new System.Drawing.Point(350, tabLocationCounter);
                totalMarkLabelLvl5[i].Location = new System.Drawing.Point(600, tabLocationCounter);
                removeModuleBtnLvl5[i].Location = new System.Drawing.Point(750, tabLocationCounter);
                tabLocationCounter = tabLocationCounter + 30;

                level5Tab.Controls.Add(moduleNameLabel[i]);
                level5Tab.Controls.Add(moduleCodeLabel[i]);
                level5Tab.Controls.Add(moduleCreditsLabel[i]);
                level5Tab.Controls.Add(manageAssessmentsBtnLvl5[i]);
                level5Tab.Controls.Add(totalMarkLabelLvl5[i]);
                level5Tab.Controls.Add(removeModuleBtnLvl5[i]);

                manageAssessmentsBtnLvl5[i].Click += new EventHandler(manageAsessmentsLvl5_Click);
                removeModuleBtnLvl5[i].Click += new EventHandler(removeModuleLvl5_Click);
            }
            creditValLvl5 = tempCredits;
            //totalCreditsLevel5 = totalCreditsLevel5 + tempCredits;
            mainPageCredits.Text = tempCredits.ToString();
            levelLabel.Text = "Level 5";
        }

        public void setLevel6Labels()
        {

            int tempCredits = 0;

            moduleNameLabel = new Label[modulesLevel6List.Count];
            moduleCodeLabel = new Label[modulesLevel6List.Count];
            moduleCreditsLabel = new Label[modulesLevel6List.Count];
            totalMarkLabelLvl6 = new Label[modulesLevel6List.Count];
            manageAssessmentsBtnLvl6 = new Button[modulesLevel6List.Count];
            removeModuleBtnLvl6 = new Button[modulesLevel6List.Count];

            tabLocationCounter = 30;

            for (int i = 0; i < modulesLevel6List.Count; i++)
            {

                moduleNameLabel[i] = new Label();
                moduleCodeLabel[i] = new Label();
                moduleCreditsLabel[i] = new Label();
                totalMarkLabelLvl6[i] = new Label();
                manageAssessmentsBtnLvl6[i] = new Button();
                removeModuleBtnLvl6[i] = new Button();
                Console.WriteLine("IMNA FAG");
                manageAssessmentsBtnLvl6[i].Tag = i;
                removeModuleBtnLvl6[i].Tag = i;

                moduleNameLabel[i].Text = modulesLevel6List[i].setModuleName.ToString();
                moduleCodeLabel[i].Text = modulesLevel6List[i].setModuleCode.ToString();
                moduleCreditsLabel[i].Text = modulesLevel6List[i].setModuleCredits.ToString();

                tempCredits = tempCredits + Int32.Parse(modulesLevel6List[i].setModuleCredits.ToString());
                creditValLvl6 = tempCredits;

                int tempMarkLevel6 = 0;
                for (int b = 0; b < modulesLevel6List[i].AssessmentList.Count; b++)
                {
                    tempMarkLevel6 = tempMarkLevel6 + modulesLevel6List[i].AssessmentList[b].TotalMark;
                }

                totalMarkLabelLvl6[i].Text = tempMarkLevel6.ToString();
                tempMarklvl6 = tempMarkLevel6;
                tempMarkLevel6 = 0;

                manageAssessmentsBtnLvl6[i].Text = "Manage Assessments";
                removeModuleBtnLvl6[i].Text = "Remove";
                manageAssessmentsBtnLvl6[i].AutoSize = true;
                removeModuleBtnLvl6[i].AutoSize = true;

                moduleNameLabel[i].Location = new System.Drawing.Point(50, tabLocationCounter);
                moduleCodeLabel[i].Location = new System.Drawing.Point(150, tabLocationCounter);
                moduleCreditsLabel[i].Location = new System.Drawing.Point(250, tabLocationCounter);
                manageAssessmentsBtnLvl6[i].Location = new System.Drawing.Point(350, tabLocationCounter);
                totalMarkLabelLvl6[i].Location = new System.Drawing.Point(600, tabLocationCounter);
                removeModuleBtnLvl6[i].Location = new System.Drawing.Point(750, tabLocationCounter);
                tabLocationCounter = tabLocationCounter + 30;

                level6Tab.Controls.Add(moduleNameLabel[i]);
                level6Tab.Controls.Add(moduleCodeLabel[i]);
                level6Tab.Controls.Add(moduleCreditsLabel[i]);
                level6Tab.Controls.Add(manageAssessmentsBtnLvl6[i]);
                level6Tab.Controls.Add(totalMarkLabelLvl6[i]);
                level6Tab.Controls.Add(removeModuleBtnLvl6[i]);

                manageAssessmentsBtnLvl6[i].Click += new EventHandler(manageAsessmentsLvl6_Click);
                removeModuleBtnLvl6[i].Click += new EventHandler(removeModuleLvl6_Click);
            }
            creditValLvl6 = tempCredits;
            //totalCreditsLevel6 = totalCreditsLevel6 + tempCredits;
            mainPageCredits.Text = tempCredits.ToString();

            levelLabel.Text = "Level 6";
        }

        public void manageAsessmentsLvl4_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);
            assessmentIndex = tempBtnIndex;

            setAssessmentLabelsLevel4();
        }

        public void setAssessmentLabelsLevel4()
        {

            int moveDown = 30;
            Label[] labelMark = new Label[modulesLevel4List[assessmentIndex].AssessmentList.Count];
            Label[] labelWeight = new Label[modulesLevel4List[assessmentIndex].AssessmentList.Count];
            Button[] remButton = new Button[modulesLevel4List[assessmentIndex].AssessmentList.Count];

            saveAssessmentsLvl4 = new Button();
            saveAssessmentsLvl4.Text = "Save";
            saveAssessmentsLvl4.Anchor = AnchorStyles.Bottom;
            addAssessmentLvl4 = new Button();
            addAssessmentLvl4.Text = "+";
            addAssessmentLvl4.Anchor = AnchorStyles.Bottom;

            Console.WriteLine("MODULE NAME CLICKED " + modulesLevel4List[assessmentIndex].setModuleName.ToString());

            AssessmentManagement manage = new AssessmentManagement();

            AssessmentName = new Label[modulesLevel4List[assessmentIndex].AssessmentList.Count];
            AssessmentMarkTextBox = new TextBox[modulesLevel4List[assessmentIndex].AssessmentList.Count];
            AssessmentWeightTextBox = new TextBox[modulesLevel4List[assessmentIndex].AssessmentList.Count];
            AssessmentNameText = new TextBox[modulesLevel4List[assessmentIndex].AssessmentList.Count];

            for (int i = 0; i < modulesLevel4List[assessmentIndex].AssessmentList.Count; i++)
            {
                AssessmentName[i] = new Label();
                labelMark[i] = new Label();
                labelWeight[i] = new Label();
                AssessmentMarkTextBox[i] = new TextBox();
                AssessmentWeightTextBox[i] = new TextBox();
                AssessmentNameText[i] = new TextBox();

                labelMark[i].AutoSize = true;
                labelWeight[i].AutoSize = true;

                remButton[i] = new Button();

                AssessmentName[i].Font = new Font(AssessmentName[i].Font, FontStyle.Bold);
                AssessmentName[i].Text = modulesLevel4List[assessmentIndex].AssessmentList[i].getAsessmentName;
                labelMark[i].Text = "Mark : ";
                labelWeight[i].Text = "Weight % : ";
                remButton[i].Text = "DEL";

                //SIZE OF TEXTBOXES
                AssessmentMarkTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentWeightTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentNameText[i].Size = new System.Drawing.Size(150, 70);

                AssessmentName[i].Location = new System.Drawing.Point(50, 20 + moveDown);
                AssessmentNameText[i].Location = new System.Drawing.Point(150, 20 + moveDown);
                labelMark[i].Location = new System.Drawing.Point(300, 20 + moveDown);
                AssessmentMarkTextBox[i].Location = new System.Drawing.Point(400, 20 + moveDown);
                labelWeight[i].Location = new System.Drawing.Point(510, 20 + moveDown);
                AssessmentWeightTextBox[i].Location = new System.Drawing.Point(675, 20 + moveDown);
                remButton[i].Location = new System.Drawing.Point(790, 20 + moveDown);

                AssessmentMarkTextBox[i].Text = modulesLevel4List[assessmentIndex].AssessmentList[i].getAssessmentMark.ToString();
                AssessmentWeightTextBox[i].Text = modulesLevel4List[assessmentIndex].AssessmentList[i].getAssessmentWeight.ToString();
                AssessmentNameText[i].Text = modulesLevel4List[assessmentIndex].AssessmentList[i].getAsessmentName.ToString();


                moveDown = moveDown + 30;

                remButton[i].Tag = i;

                manage.Controls.Add(AssessmentName[i]);
                manage.Controls.Add(AssessmentNameText[i]);
                manage.Controls.Add(labelMark[i]);
                manage.Controls.Add(AssessmentMarkTextBox[i]);
                manage.Controls.Add(labelWeight[i]);
                manage.Controls.Add(AssessmentWeightTextBox[i]);
                manage.Controls.Add(remButton[i]);

                remButton[i].Click += removeAssessmentsLvl4_Click;

            }

            addAssessmentLvl4.Location = new Point(100, 220);
            saveAssessmentsLvl4.Location = new Point(215, 220);
            manage.Controls.Add(saveAssessmentsLvl4);
            manage.Controls.Add(addAssessmentLvl4);

            saveAssessmentsLvl4.Click += saveAssessmentsLevel4_Click;
            addAssessmentLvl4.Click += addNewAssessmentsLevel4_Click;

            manage.Show();
        }
        public void setAssessmentLabelsLevel5()
        {
            int moveDown = 30;
            Label[] labelMark = new Label[modulesLevel5List[assessmentIndex].AssessmentList.Count];
            Label[] labelWeight = new Label[modulesLevel5List[assessmentIndex].AssessmentList.Count];
            Button[] remButton = new Button[modulesLevel5List[assessmentIndex].AssessmentList.Count];

            saveAssessmentsLvl5 = new Button();
            saveAssessmentsLvl5.Text = "Save";
            saveAssessmentsLvl5.Anchor = AnchorStyles.Bottom;
            addAssessmentLvl5 = new Button();
            addAssessmentLvl5.Text = "+";
            addAssessmentLvl5.Anchor = AnchorStyles.Bottom;

            Console.WriteLine("MODULE NAME CLICKED " + modulesLevel5List[assessmentIndex].setModuleName.ToString());

            AssessmentManagement manage = new AssessmentManagement();

            AssessmentName = new Label[modulesLevel5List[assessmentIndex].AssessmentList.Count];
            AssessmentMarkTextBox = new TextBox[modulesLevel5List[assessmentIndex].AssessmentList.Count];
            AssessmentWeightTextBox = new TextBox[modulesLevel5List[assessmentIndex].AssessmentList.Count];
            AssessmentNameText = new TextBox[modulesLevel5List[assessmentIndex].AssessmentList.Count];

            for (int i = 0; i < modulesLevel5List[assessmentIndex].AssessmentList.Count; i++)
            {
                AssessmentName[i] = new Label();
                labelMark[i] = new Label();
                labelWeight[i] = new Label();
                AssessmentMarkTextBox[i] = new TextBox();
                AssessmentWeightTextBox[i] = new TextBox();
                AssessmentNameText[i] = new TextBox();

                labelMark[i].AutoSize = true;
                labelWeight[i].AutoSize = true;

                remButton[i] = new Button();

                AssessmentName[i].Font = new Font(AssessmentName[i].Font, FontStyle.Bold);
                AssessmentName[i].Text = modulesLevel5List[assessmentIndex].AssessmentList[i].getAsessmentName;
                labelMark[i].Text = "Mark : ";
                labelWeight[i].Text = "Weight % : ";
                remButton[i].Text = "DEL";

                //SIZE OF TEXTBOXES
                AssessmentMarkTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentWeightTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentNameText[i].Size = new System.Drawing.Size(150, 70);

                AssessmentName[i].Location = new System.Drawing.Point(50, 20 + moveDown);
                AssessmentNameText[i].Location = new System.Drawing.Point(150, 20 + moveDown);
                labelMark[i].Location = new System.Drawing.Point(300, 20 + moveDown);
                AssessmentMarkTextBox[i].Location = new System.Drawing.Point(400, 20 + moveDown);
                labelWeight[i].Location = new System.Drawing.Point(510, 20 + moveDown);
                AssessmentWeightTextBox[i].Location = new System.Drawing.Point(675, 20 + moveDown);
                remButton[i].Location = new System.Drawing.Point(790, 20 + moveDown);

                AssessmentMarkTextBox[i].Text = modulesLevel5List[assessmentIndex].AssessmentList[i].getAssessmentMark.ToString();
                AssessmentWeightTextBox[i].Text = modulesLevel5List[assessmentIndex].AssessmentList[i].getAssessmentWeight.ToString();
                AssessmentNameText[i].Text = modulesLevel5List[assessmentIndex].AssessmentList[i].getAsessmentName.ToString();

                moveDown = moveDown + 30;

                remButton[i].Tag = i;

                manage.Controls.Add(AssessmentName[i]);
                manage.Controls.Add(AssessmentNameText[i]);
                manage.Controls.Add(labelMark[i]);
                manage.Controls.Add(AssessmentMarkTextBox[i]);
                manage.Controls.Add(labelWeight[i]);
                manage.Controls.Add(AssessmentWeightTextBox[i]);
                manage.Controls.Add(remButton[i]);

                remButton[i].Click += removeAssessmentsLvl5_Click;
            }
            addAssessmentLvl5.Location = new Point(100, 220);
            saveAssessmentsLvl5.Location = new Point(215, 220);
            manage.Controls.Add(saveAssessmentsLvl5);
            manage.Controls.Add(addAssessmentLvl5);

            saveAssessmentsLvl5.Click += saveAssessmentsLevel5_Click;
            //addAssessmentLvl5.Click += addNewAssessmentsLevel5_Click;
            manage.Show();
        }

        public void setAssessmentLabelsLevel6()
        {

            int moveDown = 30;
            Label[] labelMark = new Label[modulesLevel6List[assessmentIndex].AssessmentList.Count];
            Label[] labelWeight = new Label[modulesLevel6List[assessmentIndex].AssessmentList.Count];
            Button[] remButton = new Button[modulesLevel6List[assessmentIndex].AssessmentList.Count];


            saveAssessmentsLvl6 = new Button();
            saveAssessmentsLvl6.Text = "Save";
            saveAssessmentsLvl6.Anchor = AnchorStyles.Bottom;
            addAssessmentLvl6 = new Button();
            addAssessmentLvl6.Text = "+";
            addAssessmentLvl6.Anchor = AnchorStyles.Bottom;

            Console.WriteLine("MODULE NAME CLICKED " + modulesLevel6List[assessmentIndex].setModuleName.ToString());

            AssessmentManagement manage = new AssessmentManagement();

            AssessmentName = new Label[modulesLevel6List[assessmentIndex].AssessmentList.Count];
            AssessmentMarkTextBox = new TextBox[modulesLevel6List[assessmentIndex].AssessmentList.Count];
            AssessmentWeightTextBox = new TextBox[modulesLevel6List[assessmentIndex].AssessmentList.Count];
            AssessmentNameText = new TextBox[modulesLevel6List[assessmentIndex].AssessmentList.Count];

            for (int i = 0; i < modulesLevel6List[assessmentIndex].AssessmentList.Count; i++)
            {
                AssessmentName[i] = new Label();
                labelMark[i] = new Label();
                labelWeight[i] = new Label();
                AssessmentMarkTextBox[i] = new TextBox();
                AssessmentWeightTextBox[i] = new TextBox();
                AssessmentNameText[i] = new TextBox();

                labelMark[i].AutoSize = true;
                labelWeight[i].AutoSize = true;

                remButton[i] = new Button();

                AssessmentName[i].Font = new Font(AssessmentName[i].Font, FontStyle.Bold);
                AssessmentName[i].Text = modulesLevel6List[assessmentIndex].AssessmentList[i].getAsessmentName;
                labelMark[i].Text = "Mark : ";
                labelWeight[i].Text = "Weight % : ";
                remButton[i].Text = "DEL";

                //SIZE OF TEXTBOXES
                AssessmentMarkTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentWeightTextBox[i].Size = new System.Drawing.Size(100, 70);
                AssessmentNameText[i].Size = new System.Drawing.Size(150, 70);

                AssessmentName[i].Location = new System.Drawing.Point(50, 20 + moveDown);
                AssessmentNameText[i].Location = new System.Drawing.Point(150, 20 + moveDown);
                labelMark[i].Location = new System.Drawing.Point(300, 20 + moveDown);
                AssessmentMarkTextBox[i].Location = new System.Drawing.Point(400, 20 + moveDown);
                labelWeight[i].Location = new System.Drawing.Point(510, 20 + moveDown);
                AssessmentWeightTextBox[i].Location = new System.Drawing.Point(675, 20 + moveDown);
                remButton[i].Location = new System.Drawing.Point(790, 20 + moveDown);

                AssessmentMarkTextBox[i].Text = modulesLevel6List[assessmentIndex].AssessmentList[i].getAssessmentMark.ToString();
                AssessmentWeightTextBox[i].Text = modulesLevel6List[assessmentIndex].AssessmentList[i].getAssessmentWeight.ToString();
                AssessmentNameText[i].Text = modulesLevel6List[assessmentIndex].AssessmentList[i].getAsessmentName.ToString();

                moveDown = moveDown + 30;

                remButton[i].Tag = i;

                manage.Controls.Add(AssessmentName[i]);
                manage.Controls.Add(AssessmentNameText[i]);
                manage.Controls.Add(labelMark[i]);
                manage.Controls.Add(AssessmentMarkTextBox[i]);
                manage.Controls.Add(labelWeight[i]);
                manage.Controls.Add(AssessmentWeightTextBox[i]);
                manage.Controls.Add(remButton[i]);

                remButton[i].Click += removeAssessmentsLvl6_Click;
            }

            addAssessmentLvl6.Location = new Point(100, 220);
            saveAssessmentsLvl6.Location = new Point(215, 220);
            manage.Controls.Add(saveAssessmentsLvl6);
            manage.Controls.Add(addAssessmentLvl6);

            saveAssessmentsLvl6.Click += saveAssessmentsLevel6_Click;
            //addAssessmentLvl6.Click += addNewAssessmentsLevel6_Click;

            manage.Show();
        }

        public void removeAssessmentsLvl4_Click(object sender, EventArgs e)
        {

            int tempBtnIndex = (int)(((Button)sender).Tag);
            int tempMarkLvl4 = 0;

            Console.WriteLine("CLICKED ON " + tempBtnIndex);

            for (int i = 0; i < modulesLevel4List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel4List[assessmentIndex].AssessmentList.RemoveAt(tempBtnIndex);
                tempMarkLvl4 = tempMarklvl4 + modulesLevel4List[assessmentIndex].AssessmentList[i].TotalMark;
            }

            temporaryL4 = tempMarkLvl4;
            calculateAverage();

            ((Form)((Button)sender).Parent).Close();
            setAssessmentLabelsLevel4();

            

        }

        public void removeAssessmentsLvl5_Click(object sender, EventArgs e)
        {

            int tempBtnIndex = (int)(((Button)sender).Tag);

            Console.WriteLine("CLICKED ON " + tempBtnIndex);

            for (int i = 0; i < modulesLevel5List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel5List[assessmentIndex].AssessmentList.RemoveAt(tempBtnIndex);
            }

            ((Form)((Button)sender).Parent).Close();
            setAssessmentLabelsLevel5();
        }

        public void removeAssessmentsLvl6_Click(object sender, EventArgs e)
        {

            int tempBtnIndex = (int)(((Button)sender).Tag);

            Console.WriteLine("CLICKED ON " + tempBtnIndex);

            for (int i = 0; i < modulesLevel6List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel6List[assessmentIndex].AssessmentList.RemoveAt(tempBtnIndex);
            }

            ((Form)((Button)sender).Parent).Close();
            setAssessmentLabelsLevel6();
        }

        public void addNewAssessmentsLevel4_Click(object sender, EventArgs e)
        {


        }

        public void manageAsessmentsLvl5_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);
            assessmentIndex = tempBtnIndex;
            //DISPLAYING EVERYTHING
            setAssessmentLabelsLevel5();
        }

        public void manageAsessmentsLvl6_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);
            assessmentIndex = tempBtnIndex;

            setAssessmentLabelsLevel6();

        }

        public void removeModuleLvl4_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);

            if (modulesLevel4List[tempBtnIndex].setModuleCredits == 15)
            {
                creditAverageCounterLvl4 = creditAverageCounterLvl4 - 1;
                markLvl4 = markLvl4 - Int32.Parse(totalMarkLabelLvl4[tempBtnIndex].Text);
            }
            if (modulesLevel4List[tempBtnIndex].setModuleCredits == 30)
            {
                creditAverageCounterLvl4 = creditAverageCounterLvl4 - 2;
                markLvl4 = markLvl4 - (Int32.Parse(totalMarkLabelLvl4[tempBtnIndex].Text) * 2);
            }

            //REMOVE LVL4 MODULE AT ITS INDEX
            modulesLevel4List.RemoveAt(tempBtnIndex);
            //CLEAR THE TAB PAGE
            level4Tab.Controls.Clear();
            //SET LABELS BACK BASED ON MODULE ARRAY SIZE
            setLevel4Labels();

            //SET THE BUTTON BACK
            level4Tab.Controls.Add(addModuleBtn);
            calculateAverage();
        }

        public void removeModuleLvl5_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);

            //REMOVE LVL4 MODULE AT ITS INDEX
            modulesLevel5List.RemoveAt(tempBtnIndex);
            //CLEAR THE TAB PAGE
            level5Tab.Controls.Clear();
            //SET LABELS BACK BASED ON MODULE ARRAY SIZE
            setLevel5Labels();
            //SET THE BUTTON BACK
            level5Tab.Controls.Add(addModuleLevel5);
        }

        public void removeModuleLvl6_Click(object sender, EventArgs e)
        {
            int tempBtnIndex = (int)(((Button)sender).Tag);

            //REMOVE LVL4 MODULE AT ITS INDEX
            modulesLevel6List.RemoveAt(tempBtnIndex);
            //CLEAR THE TAB PAGE
            level6Tab.Controls.Clear();
            //SET LABELS BACK BASED ON MODULE ARRAY SIZE
            setLevel6Labels();
            //SET THE BUTTON BACK
            level6Tab.Controls.Add(addModuleLevel6);
        }

        public void saveAssessmentsLevel4_Click(object sender, EventArgs e)
        {
            tempMarklvl4 = 0;


            for (int i = 0; i < modulesLevel4List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel4List[assessmentIndex].AssessmentList[i].setAssessmentMark = Int32.Parse(AssessmentMarkTextBox[i].Text);
                modulesLevel4List[assessmentIndex].AssessmentList[i].setAssessmentWeight = Int32.Parse(AssessmentWeightTextBox[i].Text);
                modulesLevel4List[assessmentIndex].AssessmentList[i].setAssessmentName = AssessmentNameText[i].Text;

                tempMarklvl4 = tempMarklvl4 + modulesLevel4List[assessmentIndex].AssessmentList[i].TotalMark;
            }

            totalMarkLabelLvl4[assessmentIndex].Text = "" + tempMarklvl4;

            //markLvl4 = markLvl4 + modulesLevel4List[assessmentIndex].AssessmentList[i].getAssessmentMark; 

            Console.WriteLine("*************************");
            Console.WriteLine("NEWEST AVGZ   ****** " + level4Average);
            Console.WriteLine("TOTAL         ****** " + markLvl4);
            Console.WriteLine("TEMP         ****** " + temporaryL4);
            Console.WriteLine("TOTAL TEMP  ******** " + tempMarklvl4);
            Console.WriteLine("15 OR 30     ************" + credit15or30);
            Console.WriteLine("*************************");

            for (int i = 0; i < modulesLevel4List[assessmentIndex].AssessmentList.Count; i++)
            {
                
                Console.WriteLine(modulesLevel4List[assessmentIndex].AssessmentList[i].getAssessmentMark);
            }
            

            ((Form)((Button)sender).Parent).Close();
            
            //setLevel4Labels(); 
        }


        public void saveAssessmentsLevel5_Click(object sender, EventArgs e)
        {
            tempMarklvl5 = 0;
            for (int i = 0; i < modulesLevel5List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel5List[assessmentIndex].AssessmentList[i].setAssessmentMark = Int32.Parse(AssessmentMarkTextBox[i].Text);
                modulesLevel5List[assessmentIndex].AssessmentList[i].setAssessmentWeight = Int32.Parse(AssessmentWeightTextBox[i].Text);
                modulesLevel5List[assessmentIndex].AssessmentList[i].setAssessmentName = AssessmentNameText[i].Text;

                //tempMarklvl4 = modulesLevel4List[assessmentIndex].AssessmentList[i].getAssessmentMark;
                tempMarklvl5 = tempMarklvl5 + modulesLevel5List[assessmentIndex].AssessmentList[i].TotalMark;
            }

            totalMarkLabelLvl5[assessmentIndex].Text = "" + tempMarklvl5;
            Console.WriteLine("LEVEL 5");
            //setLevel4Labels(); 
        }



        public void saveAssessmentsLevel6_Click(object sender, EventArgs e)
        {
            tempMarklvl6 = 0;
            for (int i = 0; i < modulesLevel6List[assessmentIndex].AssessmentList.Count; i++)
            {
                modulesLevel6List[assessmentIndex].AssessmentList[i].setAssessmentMark = Int32.Parse(AssessmentMarkTextBox[i].Text);
                modulesLevel6List[assessmentIndex].AssessmentList[i].setAssessmentWeight = Int32.Parse(AssessmentWeightTextBox[i].Text);
                modulesLevel6List[assessmentIndex].AssessmentList[i].setAssessmentName = AssessmentNameText[i].Text;

                tempMarklvl6 = tempMarklvl6 + modulesLevel6List[assessmentIndex].AssessmentList[i].TotalMark;
            }

            totalMarkLabelLvl6[assessmentIndex].Text = "" + tempMarklvl6;
            //setLevel4Labels(); 
        }

        private void addLevel5(object a, ModuleArg e)
        {
            level5Tab.Controls.Clear();

            this.modulesLevel5List.Add(e.module);

            setLevel5Labels();

            //tempCreditCounterLvl5 = tempCreditCounterLvl5 + e.module.setModuleCredits;

            level5Tab.Controls.Add(addModuleLevel5);

            //moduleDetails.removeClick += new EventHandler(AddModuleControl_moduleRemoveBtn_Click);
        }

        private void addLevel6(object a, ModuleArg e)
        {
            level6Tab.Controls.Clear();

            this.modulesLevel6List.Add(e.module);

            setLevel6Labels();

            //tempCreditCounterLvl6 = tempCreditCounterLvl6 + e.module.setModuleCredits;

            level6Tab.Controls.Add(addModuleLevel6);
            //moduleDetails.removeClick += new EventHandler(AddModuleControl_moduleRemoveBtn_Click);

        }

        private void viewSummaryBtn_Click(object sender, EventArgs a)
        {
            tab.SelectTab(3);
            levelLabel.Text = "Course Summary";

            Label creditsLevel4Label = new Label();
            Label creditsLevel5Label = new Label();
            Label creditsLevel6Label = new Label();
            Label level4AverageLabel = new Label();
            Label level5AverageLabel = new Label();
            Label level6AverageLabel = new Label();

            creditsLevel4Label.AutoSize = true;
            creditsLevel5Label.AutoSize = true;
            creditsLevel6Label.AutoSize = true;

            level4AverageLabel.AutoSize = true;
            level5AverageLabel.AutoSize = true;
            level6AverageLabel.AutoSize = true;

            creditsLevel4Label.Text = "Total Credits : " + creditValLvl4.ToString();
            creditsLevel5Label.Text = "Total Credits : " + creditValLvl5.ToString();
            creditsLevel6Label.Text = "Total Credits : " + creditValLvl6.ToString();
            level4AverageLabel.Text = "Level 4 Average : " + level4Average.ToString(); ;

            creditsLevel4Label.Location = new System.Drawing.Point(50, 100);
            creditsLevel5Label.Location = new System.Drawing.Point(200, 100);
            creditsLevel6Label.Location = new System.Drawing.Point(350, 100);
            level4AverageLabel.Location = new System.Drawing.Point(50, 200);

            summaryTab.Controls.Add(creditsLevel4Label);
            summaryTab.Controls.Add(creditsLevel5Label);
            summaryTab.Controls.Add(creditsLevel6Label);
            summaryTab.Controls.Add(level4AverageLabel);
            summaryTab.Controls.Add(level5AverageLabel);
            summaryTab.Controls.Add(level6AverageLabel);

        }

        private void viewSum(object a, ModuleArg e)
        {

        }

        private void levelLabel_Click(object sender, EventArgs e)
        {

        }
        
        public void calculateAverage()
        {
            
            int tempMarkLevel4 = 0;
            ////
            for (int i = 0; i < modulesLevel4List.Count; i++)
            {
                for (int b = 0; b < modulesLevel4List[i].AssessmentList.Count; b++)
                {
                    tempMarkLevel4 = tempMarkLevel4 + modulesLevel4List[i].AssessmentList[b].TotalMark;
                }
            }
            //if (credit15or30 == 1)
            //{
            //    tempMarkLevel4 = tempMarkLevel4 + tempMarkLevel4;
            //}
            //else if (credit15or30 == 0)
            //{
            //    markLvl4 = tempMarkLevel4;
            //}

            level4Average = markLvl4  / creditAverageCounterLvl4;

            Console.WriteLine("AVERAGE   ----  " + level4Average);
            Console.WriteLine("TEMP ---------- "+ temporaryL4);
            Console.WriteLine("TOTAL MARK ---  " + markLvl4);
            Console.WriteLine("COUNTER ------- " + creditAverageCounterLvl4);
            Console.WriteLine("TOTAL TEMP ---- " + tempMarkLevel4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculateAverage();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            calculateAverage();
            Console.WriteLine(" MARK LEVEL $$$$$$    +"+markLvl4);
        }
    }
}
