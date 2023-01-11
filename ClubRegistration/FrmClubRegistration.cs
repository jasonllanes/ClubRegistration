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
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();

            

        }


        private ClassRegistrationQuery clubRegistrationQuery = new ClassRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshOfClubMembers();
        }

        private long StudentId;

        private void button1_Click(object sender, EventArgs e)
        {
            ID = count;

            StudentId = Convert.ToInt32(tbStudentID.Text);

            FirstName = tbFirstName.Text;
            MiddleName = tbMiddleName.Text;
            LastName = tbLastName.Text;

            Gender = cbGender.Text;
            Program = cbProgram.Text;

            Age = Convert.ToInt32(tbAge.Text);


            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RegistrationID();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            ClassRegistrationQuery classRegistrationQuery = new ClassRegistrationQuery();
            RefreshOfClubMembers();
        }

        


        public void RefreshOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        public int RegistrationID()
        {
            count++;
            return count;
        }

    }

    
}
