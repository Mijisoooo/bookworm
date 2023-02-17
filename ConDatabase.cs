using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace 책벌레2
{
    public class ConDatabase
    {
        const string _connStr = "Data Source=localhost;Initial Catalog=testDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection(_connStr);

        public DataSet GetDataSetFromSqlQuery(string qry) // 접속정보
        {
            SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
            DataSet table = new DataSet();
            adapter.Fill(table);

            return table;
        }

        public SqlDataReader sqlExecuteReader(string qry)  
        {
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlCommand sqlCmdParams(string qry, List<SqlParameter> parameters)   
        {
            conn.Open();
            SqlCommand command = new SqlCommand(qry, conn);

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        

        public bool DBOpen()
        {
            bool blRtv = true;
            try
            {
                conn.Open();

                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("DB 연결 실패", "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                blRtv = false;
                if (conn.State != ConnectionState.Open)
                {

                    MessageBox.Show(ex.Message, "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//end try

            return blRtv;
        }

        public void DBClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
