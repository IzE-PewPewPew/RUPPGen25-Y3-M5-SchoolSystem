using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Move Form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
        // Your query,
        string query = "SELECT user, pass FROM user";

        private void button1_Click(object sender, EventArgs e)
        {
            runQueryLogin();
        }

        private void runQueryLogin()
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool found = false;
                        while (reader.Read())
                        {
                            string dbUser = reader.GetString("user");
                            string dbPass = reader.GetString("pass");

                            if (username == dbUser && password == dbPass)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            MessageBox.Show("Login successful");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            if (txtPass.Text == "Input password...")
                txtPass.Text = "";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Input username...")
                txtUser.Text = "";
        }

        private void airForm1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void airForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void airForm1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Input password...";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
                txtUser.Text = "Input username...";
        }
    }
}
