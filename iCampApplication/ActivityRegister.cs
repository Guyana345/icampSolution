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
    public partial class ActivityRegister : Form
    {
        public ActivityRegister()
        {
            InitializeComponent();
        }


        //home button
        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }
        //register button
        private void register_btn_Click(object sender, EventArgs e)
        {
            registerStudent register = new registerStudent();
            register.Show();
            Hide();
        }

        //signup button
        private void signup_btn_Click(object sender, EventArgs e)
        {
            signupSheet signup = new signupSheet();
            signup.Show();
            Hide();
        }

        //activity register button
        private void activityRegister_btn_Click(object sender, EventArgs e)
        {
        }

        //details button
        private void details_btn_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            Hide();
        }

        //export button
        private void export_btn_Click(object sender, EventArgs e)
        {
            exportDetails export = new exportDetails();
            export.Show();
            Hide();
        }

        //close button
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // student activity register
        private void studentActivity_btn_Click(object sender, EventArgs e)
        {
            studentActivityRegister stregister = new studentActivityRegister();
            stregister.Show();
            Hide();
        }
    }
}
