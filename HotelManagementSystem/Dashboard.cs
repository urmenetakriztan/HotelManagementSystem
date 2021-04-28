using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = false;
            uC_Employee1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            customerDetails1.Visible = false;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            customerDetails1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
         
            customerDetails1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void uC_CustomerRegistration1_Load(object sender, EventArgs e)
        {

        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            customerDetails1.Visible = false;
 
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;

            uC_CustomerCheckOut1.Visible = false;
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
 
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            customerDetails1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
    }
}
