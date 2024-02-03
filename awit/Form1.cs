using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace awit
{
    public partial class Form1 : Form
    {
        private int currentRecordIndex = 1;

        public Form1()
        {
            //  to initialize ui components and to display and fetch employees data form
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {   

            // connection and fetch 1 record from the database table to display it
            string mysqlCon = "server=localhost;user id=root;password=; database=employee";
            string query = $"SELECT * FROM tbl_employee LIMIT {currentRecordIndex - 1}, 1";

            // retrieves data from database 
            using (MySqlConnection connection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    connection.Open();
                    // query that reads and populates certain fields
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {   
                                 
                                txtemployeeid.Text = reader["EMPLOYEE ID"].ToString();
                                txtname.Text = reader["NAME"].ToString();
                                txtage.Text = reader["AGE"].ToString();
                                txtgender.Text = reader["GENDER"].ToString();
                                txtjo.Text = reader["JOB OCCUPATION"].ToString();
                                txtcn.Text = reader["CONTACT NUMBER"].ToString();
                            }
                            else
                            {
                                
                                currentRecordIndex = 1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message);
                }
            }
        }

        private void employee_Click(object sender, EventArgs e)
        {
            
            string mysqlCon = "server=127.0.0.1; user=root; database=employee; password=";
            MySqlConnection employee = new MySqlConnection(mysqlCon);
            
        }

        private void x_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {   
            // insert query for save button
            string saveconn = "server=localhost;user id=root;password=; database=employee";
            string query = "SELECT COUNT(*) FROM tbl_employee WHERE `EMPLOYEE ID` = @EmployeeId";
            string insertQuery = "INSERT INTO tbl_employee(`EMPLOYEE ID`, `NAME`, `AGE`, `GENDER`, `JOB OCCUPATION`, `CONTACT NUMBER`) VALUES(@EmployeeId, @Name, @Age, @Gender, @JobOccupation, @ContactNumber)";

            using (MySqlConnection saveulet = new MySqlConnection(saveconn))
            {
                try
                {
                    saveulet.Open();

                  
                    using (MySqlCommand checkCmd = new MySqlCommand(query, saveulet))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeId", this.txtemployeeid.Text);
                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            MessageBox.Show("Employee ID already exists. Please use a different ID.");
                            return; 
                        }
                    }

                    
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, saveulet))
                    {
                        insertCmd.Parameters.AddWithValue("@EmployeeId", this.txtemployeeid.Text);
                        insertCmd.Parameters.AddWithValue("@Name", this.txtname.Text);
                        insertCmd.Parameters.AddWithValue("@Age", this.txtage.Text);
                        insertCmd.Parameters.AddWithValue("@Gender", this.txtgender.Text);
                        insertCmd.Parameters.AddWithValue("@JobOccupation", this.txtjo.Text);
                        insertCmd.Parameters.AddWithValue("@ContactNumber", this.txtcn.Text);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been successfully saved");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving record: " + ex.Message);
                }
                finally
                {
                    if (saveulet.State == ConnectionState.Open)
                    {
                        saveulet.Close();
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            string saveconn = "server=localhost;user id=root;password=; database=employee";
            string query = "UPDATE tbl_employee SET NAME=@Name, AGE=@Age, GENDER=@Gender, `JOB OCCUPATION`=@JobOccupation, `CONTACT NUMBER`=@ContactNumber WHERE `EMPLOYEE ID`=@EmployeeId";
            using (MySqlConnection saveulet = new MySqlConnection(saveconn))
            {
                try
                {
                    saveulet.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, saveulet))
                    {
                        cmd.Parameters.AddWithValue("@Name", this.txtname.Text);
                        cmd.Parameters.AddWithValue("@Age", this.txtage.Text);
                        cmd.Parameters.AddWithValue("@Gender", this.txtgender.Text);
                        cmd.Parameters.AddWithValue("@JobOccupation", this.txtjo.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", this.txtcn.Text);
                        cmd.Parameters.AddWithValue("@EmployeeId", this.txtemployeeid.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Employee record has been updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating employee record: " + ex.Message);
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string saveconn = "server=localhost;user id=root;password=; database=employee";
            string query = "DELETE FROM tbl_employee WHERE `EMPLOYEE ID` = @EmployeeId";

            using (MySqlConnection saveulet = new MySqlConnection(saveconn))
            {
                try
                {
                    saveulet.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, saveulet))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", this.txtemployeeid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record has been removed");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing record: " + ex.Message);
                }
                finally
                {
                    if (saveulet.State == ConnectionState.Open)
                    {
                        saveulet.Close();
                    }
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentRecordIndex++;
            LoadEmployeeData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (currentRecordIndex > 1)
            {
                currentRecordIndex--;
                LoadEmployeeData();
            }
        }

        private void maintenance_Click(object sender, EventArgs e)
        {
            MAINTENANCE maintenanceForm = new MAINTENANCE();
            maintenanceForm.Show();
        }

    }
}

