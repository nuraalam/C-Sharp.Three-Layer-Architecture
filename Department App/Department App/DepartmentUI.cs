using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department_App.BLL;
using Department_App.DLL.DAO;

namespace Department_App
{
    public partial class DepartmentUI : Form
    {
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment=new Department(nameTextBox.Text,codeTextBox.Text);
            DepartmentBLL aDepartmentBll=new DepartmentBLL();
            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);
        }
    }
}
