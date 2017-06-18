using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2_MarkPredictionProgram
{
    public partial class AddModuleControl : UserControl
    {


        String moduleName;
        String moduleCode;
        String moduleCredits;
        int assessmentsNumber;
        

       // AddModuleForm addModuleForm = new AddModuleForm();
     

        public event EventHandler removeClick;

        protected void moduleRemoveBtn_Click(object sender, EventArgs e)
        {
            if (this.removeClick != null)
            {
                this.removeClick(this, e);
                
            }
        }

        
        public String modName
        {
            get
            {
                return moduleName;
            }
            set
            {
                moduleName = value;
                moduleNameLbl.Text = moduleName;

            }
        }

        public String modCode
        {
            get
            {
                return moduleCode;
            }
            set
            {
                moduleCode = value;
                moduleCodeLbl.Text = moduleCode;

            }
        }

        public String modCredits
        {
            get
            {
                return moduleCredits;
            }
            set
            {
                moduleCredits = value;
                moduleCreditsLbl.Text = moduleCredits;

            }
        }

        public int assessmentsNum
        {
            get
            {
                return assessmentsNumber;
            }

            set
            {
                assessmentsNumber = value;
            }
        }

        public AddModuleControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddModuleControl_Load(object sender, EventArgs e)
        {

        }

 

    }
}
