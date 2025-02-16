using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect_info_gym
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String gymTime = comboBoxTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymTime + "','" + address + "','" + membership + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            comboBoxTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
