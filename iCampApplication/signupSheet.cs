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
    public partial class signupSheet : Form
    {
        public signupSheet()
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
            Hide();
        }

        //home button
        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_btn_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void registerSt_btn_Click(object sender, EventArgs e)
        {
            studentActivityRegister stregister = new studentActivityRegister();
            stregister.Show();
            Hide();
        }
    }
}
