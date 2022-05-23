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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            SqlCommand Command = new SqlCommand("AddPerson");
            Command.Parameters.Add(new SqlParameter("@PersonName", textBox1.Text));
            Command.Parameters.Add(new SqlParameter("@Phone", textBox2.Text));
            Command.Parameters.Add(new SqlParameter("@Rate", textBox3.Text));
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
