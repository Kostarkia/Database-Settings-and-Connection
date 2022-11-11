using csharp_sql_connection_settings_via_form.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_sql_connection_settings_via_form
{
    public partial class Form1 : Form
    {
        public static string SqlConnection;

        private string _jsonText = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Database\DatabaseConnection.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var json = File.ReadAllText(_jsonText);

            var databaseSettingModel = JsonConvert.DeserializeObject<DatabaseSettingsModel>(json);

            textDataSource.Text = databaseSettingModel.DataSource;
            textInitialCatalog.Text = databaseSettingModel.InitialCatalog;
            textUserID.Text = databaseSettingModel.UserID;
            textPassword.Text = databaseSettingModel.Password;
            numConnectionTimeout.Value = databaseSettingModel.ConnectionTimeout;
            checkIntegratedSecurity.Checked = databaseSettingModel.IntegratedSecurity;

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var jsonText = new DatabaseSettingsModel
            {
                DataSource = textDataSource.Text,
                InitialCatalog = textInitialCatalog.Text,
                UserID = textUserID.Text,
                Password = textPassword.Text,
                ConnectionTimeout = (int)numConnectionTimeout.Value,
                IntegratedSecurity = checkIntegratedSecurity.Checked
            };

            string databaseSettingModel = JsonConvert.SerializeObject(jsonText);

            File.WriteAllText(_jsonText, databaseSettingModel);

            MessageBox.Show("Registration Successful" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            var control = DatabaseControl();

            if (!control)
                return;
        }

        private bool Connection(DatabaseSettingsModel databaseSettingsModel)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

            if (databaseSettingsModel.IntegratedSecurity)
            {
                if (string.IsNullOrEmpty(databaseSettingsModel.DataSource) || string.IsNullOrEmpty(databaseSettingsModel.InitialCatalog))
                {
                    MessageBox.Show
                        (
                            "Could not get database connection or name",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                    return false;
                }

                sqlConnectionStringBuilder.DataSource = databaseSettingsModel.DataSource;
                sqlConnectionStringBuilder.InitialCatalog = databaseSettingsModel.InitialCatalog;
                sqlConnectionStringBuilder.IntegratedSecurity = true;
                sqlConnectionStringBuilder.MultipleActiveResultSets = true;
                sqlConnectionStringBuilder.ConnectTimeout = databaseSettingsModel.ConnectionTimeout;
            }
            else
            {
                if (string.IsNullOrEmpty(databaseSettingsModel.DataSource) || string.IsNullOrEmpty(databaseSettingsModel.InitialCatalog) ||
                    string.IsNullOrEmpty(databaseSettingsModel.UserID) || string.IsNullOrEmpty(databaseSettingsModel.Password))
                {

                    MessageBox.Show
                        (
                           "Check your database settings",
                           "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                    return false;
                }

                sqlConnectionStringBuilder.DataSource = databaseSettingsModel.DataSource;
                sqlConnectionStringBuilder.InitialCatalog = databaseSettingsModel.InitialCatalog;
                sqlConnectionStringBuilder.IntegratedSecurity = databaseSettingsModel.IntegratedSecurity;
                sqlConnectionStringBuilder.UserID = databaseSettingsModel.UserID;
                sqlConnectionStringBuilder.Password = databaseSettingsModel.Password;
                sqlConnectionStringBuilder.ConnectTimeout = databaseSettingsModel.ConnectionTimeout;
                sqlConnectionStringBuilder.MultipleActiveResultSets = true;
            }

            try
            {
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = sqlConnectionStringBuilder.ConnectionString;

                connection.Open();
                connection.Close();

                MessageBox.Show("Connection successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //You can get the connection address only with SqlConnection from other screens.
                SqlConnection = sqlConnectionStringBuilder.ConnectionString;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                   (
                        string.Format
                        (
                            "{1}{0}{0}{2}",
                            Environment.NewLine,
                            "Connection failed",
                            ex.Message
                        ),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                   );

                return false;
            }
        }

        private bool DatabaseControl()
        {
            var databaseSettingsModel = new DatabaseSettingsModel
            {
                DataSource = textDataSource.Text,
                InitialCatalog = textInitialCatalog.Text,
                UserID = textUserID.Text,
                Password = textPassword.Text,
                ConnectionTimeout = (int)numConnectionTimeout.Value,
                IntegratedSecurity = checkIntegratedSecurity.Checked
            };

            var databaseConnectionControl = Connection(databaseSettingsModel);

            if (!databaseConnectionControl)
                return false;

            return true;
        }


    }
}
