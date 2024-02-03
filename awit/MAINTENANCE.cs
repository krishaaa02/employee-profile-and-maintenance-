using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace awit
{
    public partial class MAINTENANCE : Form
    {
        private string MySqlConn = "Server=127.0.0.1;user=root;database=maintenance;password=";
        private DataTable dataTable;
        private DataView dataView;
        private int currentRowIndex = 0;

        public MAINTENANCE()
        {
            InitializeComponent();
           
            MAINTENANCE_Load(this, EventArgs.Empty);
        }

        private void x_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadGridData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MySqlConn))
                {
                    conn.Open();

                    string query = "SELECT * FROM tbl_maintenance";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView = new DataView(dataTable);
                        dataGridView1.DataSource = dataTable;

                        
                        dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MAINTENANCE_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(MySqlConn))
                {
                    conn.Open();

                    string query = "SELECT * FROM tbl_maintenance";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            
                            dataGridView1.DataSource = dataTable;

                           
                            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                            
                            dataView = new DataView(dataTable);

                            
                            LoadDataFromRow(currentRowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataFromRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataView.Count)
            {
                DataRowView rowView = dataView[rowIndex];

                txtroomnum.Text = rowView["ROOM NUMBER"].ToString();
                txtoccupantid.Text = rowView["OCCUPANT ID"].ToString();
                txtemployeeassigned.Text = rowView["EMPLOYEE ASSIGNED"].ToString();
                txtmaintenance.Text = rowView["MAINTENANCE"].ToString();

                if (rowView["DATE ISSUED"] != DBNull.Value)
                {
                    DateTime dateIssued = Convert.ToDateTime(rowView["DATE ISSUED"]);
                    txtdateissued.Text = dateIssued.ToString("MM/dd/yyyy");
                }
                else
                {
                    txtdateissued.Text = string.Empty;
                }

                if (rowView["DATE FIXED"] != DBNull.Value)
                {
                    DateTime dateFixed = Convert.ToDateTime(rowView["DATE FIXED"]);
                    txtdatefixed.Text = dateFixed.ToString("MM/dd/yyyy");
                }
                else
                {
                    txtdatefixed.Text = string.Empty;
                }
            }
        }

        private bool OccupantIdExists(string occupantId)
        {
            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM tbl_maintenance WHERE `OCCUPANT ID` = @OccupantId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OccupantId", occupantId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string occupantId = this.txtoccupantid.Text.Trim();

            if (OccupantIdExists(occupantId))
            {
                MessageBox.Show("Occupant ID already exists. Please choose a different Occupant ID.");
                return;
            }

            string query = "INSERT INTO tbl_maintenance(`OCCUPANT ID`, `EMPLOYEE ASSIGNED`, `MAINTENANCE`, `DATE ISSUED`, `DATE FIXED`) VALUES (@OccupantId, @EmployeeAssigned, @Maintenance, @DateIssued, @DateFixed)";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OccupantId", this.txtoccupantid.Text);
                        cmd.Parameters.AddWithValue("@EmployeeAssigned", this.txtemployeeassigned.Text);
                        cmd.Parameters.AddWithValue("@Maintenance", this.txtmaintenance.Text);

                        if (!string.IsNullOrEmpty(this.txtdateissued.Text))
                        {
                            DateTime dateIssued;
                            if (DateTime.TryParseExact(this.txtdateissued.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateIssued))
                                cmd.Parameters.AddWithValue("@DateIssued", dateIssued);
                            else
                                cmd.Parameters.AddWithValue("@DateIssued", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DateIssued", DBNull.Value);
                        }

                        if (!string.IsNullOrEmpty(this.txtdatefixed.Text))
                        {
                            DateTime dateFixed;
                            if (DateTime.TryParseExact(this.txtdatefixed.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFixed))
                                cmd.Parameters.AddWithValue("@DateFixed", dateFixed);
                            else
                                cmd.Parameters.AddWithValue("@DateFixed", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DateFixed", DBNull.Value);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information saved");
                            loadGridData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save information");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string occupantId = this.txtoccupantid.Text.Trim();

            if (OccupantIdExists(occupantId))
            {
                MessageBox.Show("Cannot update. Occupant ID already exists.");
                return;
            }

            string query = "UPDATE tbl_maintenance SET `OCCUPANT ID` = @OccupantId, `EMPLOYEE ASSIGNED` = @EmployeeAssigned, " +
                           "`MAINTENANCE` = @Maintenance, `DATE ISSUED` = @DateIssued, `DATE FIXED` = @DateFixed " +
                           "WHERE `ROOM NUMBER` = @RoomNumber";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OccupantId", this.txtoccupantid.Text);
                        cmd.Parameters.AddWithValue("@EmployeeAssigned", this.txtemployeeassigned.Text);
                        cmd.Parameters.AddWithValue("@Maintenance", this.txtmaintenance.Text);

                        if (!string.IsNullOrEmpty(this.txtdateissued.Text))
                        {
                            DateTime dateIssued;
                            if (DateTime.TryParseExact(this.txtdateissued.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateIssued))
                                cmd.Parameters.AddWithValue("@DateIssued", dateIssued);
                            else
                                cmd.Parameters.AddWithValue("@DateIssued", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DateIssued", DBNull.Value);
                        }

                        if (!string.IsNullOrEmpty(this.txtdatefixed.Text))
                        {
                            DateTime dateFixed;
                            if (DateTime.TryParseExact(this.txtdatefixed.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFixed))
                                cmd.Parameters.AddWithValue("@DateFixed", dateFixed);
                            else
                                cmd.Parameters.AddWithValue("@DateFixed", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DateFixed", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@RoomNumber", this.txtroomnum.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record has been updated");
                            loadGridData(); 
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the specified ROOM NUMBER.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root;password=;database=maintenance";
            string query = "DELETE FROM tbl_maintenance WHERE `ROOM NUMBER` = @RoomNumber";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", this.txtroomnum.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Successfully Removed!");
                            loadGridData();
                        }
                        else
                        {
                            MessageBox.Show("No records found or failed to remove record.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                LoadDataFromRow(currentRowIndex);
            }
            else
            {
                MessageBox.Show("No previous information available.");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < dataView.Count - 1)
            {
                currentRowIndex++;
                LoadDataFromRow(currentRowIndex);
            }
            else
            {
                MessageBox.Show("No next information available.");
            }
        }
    }
}