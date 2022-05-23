using System.Data;
using System.Data.SqlClient;

namespace Audit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            DataSet Data = new DataSet();

            SqlCommand Command = new SqlCommand("SelectPersons");
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Data);

            PersonsGrid.DataSource = Data.Tables[0];

            Connection.Close();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            Add Form = new Add();
            Form.ShowDialog();
        }

        private void EditPerson_Click(object sender, EventArgs e)
        {
            Edit Form = new Edit(PersonsGrid.CurrentRow.Cells[0].Value, PersonsGrid.CurrentRow.Cells[1].Value.ToString(), PersonsGrid.CurrentRow.Cells[2].Value.ToString(), PersonsGrid.CurrentRow.Cells[3].Value.ToString());
            Form.ShowDialog();
        }

        private void FirePerson_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            SqlCommand Command = new SqlCommand("FirePerson");
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add(new SqlParameter("@ID", PersonsGrid.CurrentRow.Cells[0].Value.ToString()));
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        private void PersonsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            DataSet Data = new DataSet();

            SqlCommand Command = new SqlCommand("SelectCash");
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add(new SqlParameter("@ID", PersonsGrid.CurrentRow.Cells[0].Value.ToString()));

            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Data);

            MoneyGrid.DataSource = Data.Tables[0];

            Connection.Close();
        }

        private void AddPlata_Click(object sender, EventArgs e)
        {
            AddPlata form = new AddPlata();
            form.ShowDialog();
        }

        private void MoneyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Server=server-sql1\Students; Integrated Security = true; Database = Elistratov_Practice");
            Connection.Open();

            DataSet Data = new DataSet();

            SqlCommand Command = new SqlCommand("SelectArc");
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add(new SqlParameter("@ID", PersonsGrid.CurrentRow.Cells[0].Value.ToString()));
            Command.Parameters.Add(new SqlParameter("@Moun", MoneyGrid.CurrentRow.Cells[2].Value.ToString()));
            Command.Parameters.Add(new SqlParameter("@Year", MoneyGrid.CurrentRow.Cells[3].Value.ToString()));
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Data);

            Grid_Explore.DataSource = Data.Tables[0];

            Connection.Close();
        }
    }
}