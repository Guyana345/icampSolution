using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCampApplication
{
    public partial class registerStudent : Form
    {

        DBAccess dba = new DBAccess();

        public registerStudent()
        {
            InitializeComponent();
        }

        // export button
        private void exportDetails_Click(object sender, EventArgs e)
        {
            exportDetails export = new exportDetails();
            export.Show();
            Hide();

        }

        // details button
        private void details_btn_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            Hide();
        }

        // activity button
        private void activityRegister_btn_Click(object sender, EventArgs e)
        {
            ActivityRegister registerActivity = new ActivityRegister();
            registerActivity.Show();
            Hide();
        }

        // signup button
        private void signup_btn_Click(object sender, EventArgs e)
        {
            signupSheet signup = new signupSheet();
            signup.Show();
            Hide();
        }

        // register button
        private void register_btn_Click(object sender, EventArgs e)
        {
            registerStudent register = new registerStudent();
            register.Show();
        }

        //home button
        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        // close button
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // register student button
        private void registerSt_btn_Click(object sender, EventArgs e)
        {

            // string age = Convert.ToUInt32(Age.Text).ToString();
            int age = Int32.Parse(Age.Text);
            dba.InsertStudent(studentName.Text, startDate.Value.ToString("yyyy/M/d"), endDate.Value.ToString("yyyy/M/d"),bunkName.Text, nationalites.Text, preferedName.Text, age, restriction.Text, medications.Text,transportation.Text, p1Name.Text, p1Email.Text, p1Phone.Text, p2Name.Text, p2Email.Text, p2Phone.Text);

            //dba.InsertParent1(p1Name.Text, p1Email.Text, p1Phone.Text);

           //dba.InsertParent1(p2Name.Text, p2Email.Text, p2Phone.Text);
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            exportDetails export = new exportDetails();
            export.Show();
            Hide();
        }
    }
}
