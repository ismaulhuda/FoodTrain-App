using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrain_Admin
{
    public partial class secondCustomControl : UserControl
    {
        //access database koneksi string
        string MinumanConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\WIN10x64\\Documents\\Foodtrain-App\\db_access.accdb";
        //query for interesting data into microsoft access database
        string insertDataIntoMinuman = "INSERT INTO Minuman (Nama, Jenis, Harga, Deskripsi, ImagePath, ImageFile) VALUES (?,?,?,?,?,?)";
        //query for seleting from makanan
        string selectAllDataFromMinumanQuery = "Select * FROM Minuman";
        //query for updating from makanan
        string updateAllDataFromMinumanQuery = "UPDATE Minuman SET Nama = ?, Jenis = ?, Harga = ?, Deskripsi = ?, ImagePath = ?, ImageFile = ? WHERE ID = ?";
        //query for updating from makanan
        string deleteDataFromMinumanQuery = "DELETE FROM Minuman  WHERE ID = ?";


        public OleDbConnection MinumanOleDbConnection = null;

        public secondCustomControl()
        {
            //inisialisasi oledbkoneksi dalam konstruksi
            MinumanOleDbConnection = new OleDbConnection(MinumanConnectionString);
            InitializeComponent();
        }

        private void openCennection()
        {
            //membuka koneksi
            if (MinumanOleDbConnection.State == ConnectionState.Closed)
            {
                MinumanOleDbConnection.Open();
            }
        }

        private void closeConnection()
        {
            //tutup koneksi
            if (MinumanOleDbConnection.State == ConnectionState.Open)
            {
                MinumanOleDbConnection.Close();
            }
        }

        //function for converting iage to byte array
        public byte[] convertImageToByteArray(Image imageToConvert)
        {
            MemoryStream concertImageMemoryStream = new MemoryStream();
            imageToConvert.Save(concertImageMemoryStream, imageToConvert.RawFormat);
            return concertImageMemoryStream.ToArray();
        }

        //function for converting byte array to image
        public Image convertByteArrayToImage(byte[] byteArrayToConvert)
        {
            MemoryStream convertByteArrayToImageMemoryStream = new MemoryStream(byteArrayToConvert);
            Image convertedImage = Image.FromStream(convertByteArrayToImageMemoryStream);
            return convertedImage;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog cariFile = new OpenFileDialog();
                cariFile.Title = "cari gambar";
                cariFile.Filter = "cari gambar file  | *.png;*.jpg;*.gif";
                DialogResult cariFileResult = cariFile.ShowDialog();
                if (cariFileResult == DialogResult.OK)
                {
                    string filename = cariFile.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                    txtImagePath.Text = filename;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbCommand insertDataIntoMinumanOleDBCommand;
            //check field empty or not
            if (String.IsNullOrEmpty(txtNama.Text) || String.IsNullOrEmpty(txtJenis.Text) || String.IsNullOrEmpty(txtHarga.Text) || String.IsNullOrEmpty(txtDeskripsi.Text) || String.IsNullOrEmpty(txtImagePath.Text) || pictureBox1.Image == null)
            {
                MessageBox.Show("One or more fields are empty make sure all fields are filled.");
            }
            else
                try
                {
                    insertDataIntoMinumanOleDBCommand = new OleDbCommand(insertDataIntoMinuman, MinumanOleDbConnection);
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("Nama", OleDbType.VarChar).Value = txtNama.Text;
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("Jenis", OleDbType.VarChar).Value = txtJenis.Text;
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("Harga", OleDbType.VarChar).Value = txtHarga.Text;
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("Deskripsi", OleDbType.VarChar).Value = txtDeskripsi.Text;
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("ImagePath", OleDbType.VarChar).Value = txtImagePath.Text;
                    insertDataIntoMinumanOleDBCommand.Parameters.AddWithValue("ImageFile", OleDbType.Binary).Value = convertImageToByteArray(pictureBox1.Image);
                    //open database connection
                    openCennection();

                    int dataInserted = insertDataIntoMinumanOleDBCommand.ExecuteNonQuery();

                    if (dataInserted > 0)
                    {
                        MessageBox.Show("insert data successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //finally close connection to the database
                    closeConnection();
                    //refresh datagridview after inserting data to the database
                    populateDataGridViewFromMinuman();
                }
        }

        private void MinumanCustomControl_Load(object sender, EventArgs e)
        {
            //change row height
            dataGridView1.RowTemplate.Height = 60;
            //populate dataGridview on form minuman on from load
            populateDataGridViewFromMinuman();
        }
        //Function datagridview retrieving data from minuman and displaying it on datagridview
        private void populateDataGridViewFromMinuman()
        {
            //clear datagridview rows before loading data from minuman
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }

            try
            {
                OleDbCommand populateDataGridViewFromMinumanOleDbCommand = new OleDbCommand(selectAllDataFromMinumanQuery, MinumanOleDbConnection);
                //open koneksi
                openCennection();
                OleDbDataReader reader = populateDataGridViewFromMinumanOleDbCommand.ExecuteReader();
                //loop trough data minuman
                while (reader.Read())
                {
                    //add makanan ke datagridview
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), (byte[])reader[6]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close koneksi
                closeConnection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if datagridview  is clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectDataGridViewRow = dataGridView1.Rows[e.RowIndex];

                txtID.Text = selectDataGridViewRow.Cells[0].Value.ToString();
                txtNama.Text = selectDataGridViewRow.Cells[1].Value.ToString();
                txtJenis.Text = selectDataGridViewRow.Cells[2].Value.ToString();
                txtHarga.Text = selectDataGridViewRow.Cells[3].Value.ToString();
                txtDeskripsi.Text = selectDataGridViewRow.Cells[4].Value.ToString();
                txtImagePath.Text = selectDataGridViewRow.Cells[5].Value.ToString();

                //convert byte array to image
                pictureBox1.Image = convertByteArrayToImage((byte[])selectDataGridViewRow.Cells[6].Value);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty)
            {
                MessageBox.Show("First Click On DatagridView Row Cell Or Make Sure ID Field Is Not Empty.");
            }
            else
            {
                try
                {
                    //Check If One Or More Fields Are Empty
                    if (txtNama.Text == String.Empty || txtJenis.Text == String.Empty || txtHarga.Text == String.Empty || txtDeskripsi.Text == String.Empty || txtImagePath.Text == String.Empty || pictureBox1.Image == null)
                    {
                        MessageBox.Show("One Or More Empty Field Make sure all fields are filled.");
                    }
                    else
                    {
                        OleDbCommand updateMinumanOleDbCommand = new OleDbCommand(updateAllDataFromMinumanQuery, MinumanOleDbConnection);
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@Nama", OleDbType.VarChar).Value = txtNama.Text;
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@Jenis", OleDbType.VarChar).Value = txtJenis.Text;
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@Harga", OleDbType.VarChar).Value = txtHarga.Text;
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@Deskripsi", OleDbType.VarChar).Value = txtDeskripsi.Text;
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@ImagePath", OleDbType.VarChar).Value = txtImagePath.Text;
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@ImageFile", OleDbType.Binary).Value = convertImageToByteArray(pictureBox1.Image);
                        updateMinumanOleDbCommand.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = Convert.ToInt32(txtID.Text);
                        //Opening Access Database Connection
                        MinumanOleDbConnection.Open();
                        int insertDataIntoMinuman = updateMinumanOleDbCommand.ExecuteNonQuery();
                        //If data Has been inserted to the database output the following message
                        if (insertDataIntoMinuman > 0)
                        {
                            MessageBox.Show("Data Updated In Minuman Susccessfully.");
                            //Clear Input fields After Deleting the Data From MS Access Database
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    //Finally Close MS Access Database Connection
                    if (MinumanOleDbConnection != null)
                    {
                        MinumanOleDbConnection.Close();
                    }
                }
                //Refreshing Datagridview after Updating a row
                populateDataGridViewFromMinuman();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //check if id textbox is empty
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("ID field is empty click on datagrid row cell first.");
                }
                else
                {
                    OleDbCommand deleteDataFromMinumanQueryOleDbCommand = new OleDbCommand(deleteDataFromMinumanQuery, MinumanOleDbConnection);
                    deleteDataFromMinumanQueryOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(txtID.Text);
                    //open koneksi
                    openCennection();

                    int deleteDataFromMinuman = deleteDataFromMinumanQueryOleDbCommand.ExecuteNonQuery();
                    if (deleteDataFromMinuman > 0)
                    {
                        MessageBox.Show("Delete data from Table Minuman Successfully.");
                        //clear input fields

                        clearInputFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close koneksi minuman
                closeConnection();
                //refresh datagridview after deleting data to the database
                populateDataGridViewFromMinuman();
            }
        }

        private void clearInputFields()
        {
            //first check if all input fields are empty
            if (String.IsNullOrEmpty(txtNama.Text) && String.IsNullOrEmpty(txtJenis.Text) && String.IsNullOrEmpty(txtHarga.Text) && String.IsNullOrEmpty(txtDeskripsi.Text) && String.IsNullOrEmpty(txtImagePath.Text))
            {
                MessageBox.Show("All input fields are empty");
            }
            else
            {
                //clearing textboxes
                txtID.Text = string.Empty;
                txtNama.Text = string.Empty;
                txtJenis.Text = string.Empty;
                txtHarga.Text = string.Empty;
                txtDeskripsi.Text = string.Empty;
                txtImagePath.Text = string.Empty;
                //clearing picturebox
                pictureBox1.Image = null;
            }
        }
    }
}
