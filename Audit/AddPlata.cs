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

namespace Audit
{
    public partial class AddPlata : Form
    {
        public AddPlata()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Time1.Enabled = false;
                Time2.Enabled = false;
            }
            else
            {
                Time1.Enabled = true;
                Time2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            SqlCommand Command = new SqlCommand("AddPlata");
            Command.Parameters.Add(new SqlParameter("@ID", textBox1.Text));
            Command.Parameters.Add(new SqlParameter("@Status", checkBox1.Checked));
            if (!checkBox1.Checked)
            {
                Command.Parameters.Add(new SqlParameter("@Time1", Time1.Text));
                Command.Parameters.Add(new SqlParameter("@Time2", Time2.Text));
            }

            Command.Parameters.Add(new SqlParameter("@Date1", Date1.Value));
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
