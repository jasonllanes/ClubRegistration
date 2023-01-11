using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {

        ClassRegistrationQuery classRegistrationQuery = new ClassRegistrationQuery();

        public FrmUpdateMember()
        {
            InitializeComponent();

      
            classRegistrationQuery.IdSelect(cbStudentId);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            classRegistrationQuery.AutoSearch(tbFirstName,tbMiddleName,tbLastName, tbAge,cbGender,cbProgram,Convert.ToInt32(cbStudentId.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classRegistrationQuery.UpdateStudent(Convert.ToInt32(cbStudentId.Text), tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, Convert.ToInt32(tbAge.Text), cbGender.Text, cbProgram.Text);
            FrmClubRegistration frmClubRegistration = new FrmClubRegistration();
            frmClubRegistration.RefreshOfClubMembers();
        }
    }

}
