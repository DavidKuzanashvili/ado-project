using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Employee table values
            string personalNumber = PN.Text;
            string surename = Surename.Text;
            string name = EmpName.Text;
            string mobileNumber = MobileNumber.Text;
            string birthDay = BirthDay.Value.ToString("yyyy-MM-dd");
            string mail = Mail.Text;

            //Positon table values
            string positionName = "";
            string dateOfPositionHeld = DateTime.Now.ToString("yyyy-MM-dd");

            if(PositionDropDownList.SelectedItem != null)
            {
                positionName = PositionDropDownList.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Position!");
            }

            //Setup
            SqlConnection cn = new SqlConnection();
            SqlCommand command;
            SqlTransaction transaction;

            cn.ConnectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

            //Action
            try
            {
                cn.Open();
                command = cn.CreateCommand();
                transaction = cn.BeginTransaction("AddingEmployee");
                command.Connection = cn;
                command.Transaction = transaction;

                try
                {
                    //Insert Employee
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        $"INSERT INTO dbo.Employee(PN, Surname, Name, MobileNumber, BirthDate, Mail) VALUES (N'{personalNumber}', N'{surename}', N'{name}', N'{mobileNumber}', '{birthDay}', N'{mail}')";
                    command.ExecuteNonQuery();
                    //Insert Employee Position
                    command.CommandText =
                        $"INSERT INTO dbo.Position(PositionName, DateOfPositionHeld, PN) VALUES (N'{positionName}', '{dateOfPositionHeld}', N'{personalNumber}')";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee was added to database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Commit Exception type: {ex.GetType()}");
                    MessageBox.Show(ex.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception tex)
                    {
                        MessageBox.Show("Rollback Exception Type: " + tex.GetType());
                        MessageBox.Show("Message: " + tex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
