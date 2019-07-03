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
        private string conString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public HRForm()
        {
            InitializeComponent();
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand command;

            cn.ConnectionString = conString;

            try
            {
                cn.Open();
                command = cn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM EmployeeInfo";
                command.ExecuteNonQuery();

                DataTable employeeTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(employeeTable);
                employeeGridView.DataSource = employeeTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }
        }

        private void SaveEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Employee table values
            string personalNumber = PN.Text;
            string surename = Surename.Text;
            string name = EmpName.Text;
            string mobileNumber = MobileNumber.Text;
            string birthDay = BirthDay.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string mail = Mail.Text;

            //Positon table values
            string positionName = "";
            string dateOfPositionHeld = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

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

            cn.ConnectionString = conString;

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
                        $"INSERT INTO dbo.Employee(PN, Surename, Name, BirthDate, MobileNumber, Mail) VALUES (N'{personalNumber}', N'{surename}', N'{name}', '{birthDay}', N'{mobileNumber}', N'{mail}')";
                    command.ExecuteNonQuery();
                    //Insert Employee Position
                    command.CommandText =
                        $"INSERT INTO dbo.Position(PN, PositionName, DateOfPositionHeld) VALUES (N'{personalNumber}', N'{positionName}', '{dateOfPositionHeld}')";
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
            finally
            {
                cn.Close();
            }
        }

        private void changePositionBtn_Click(object sender, EventArgs e)
        {
            string personalNumber = ChangePositionPN.Text;
            string posName = "";
            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            if(ChnagePositionComboBox.SelectedItem != null)
            {
                posName = ChnagePositionComboBox.SelectedItem.ToString();
            } 
            else
            {
                MessageBox.Show("Please Select Position");
            }

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = null;

            cn.ConnectionString = conString;

            try
            {
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO dbo.Position(PN, PositionName, DateOfPositionHeld) VALUES (N'{personalNumber}', N'{posName}', '{date}')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Position Changed!");

                ChangePositionPN.Text = "";
                ChnagePositionComboBox.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
