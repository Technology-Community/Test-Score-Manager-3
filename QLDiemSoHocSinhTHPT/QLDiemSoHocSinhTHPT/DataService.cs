using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDiemSoHocSinhTHPT
{
    public class DataService : DataTable
    {
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        string strConn = "Data Source=localhost;Initial Catalog=QLDiemSoHocSinhTHPT;User Id=sa;Password=;";
        public DataService()
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }
        }

        public DataTable Load(SqlCommand command)
        {
            m_DataAdapter = new SqlDataAdapter();
            m_Command = new SqlCommand();
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }

            m_Command = command;
            m_Command.Connection = m_Connection;
            m_DataAdapter = new SqlDataAdapter(m_Command);
            this.Clear();
            m_DataAdapter.Fill(this);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);
            try
            {
                this.m_DataAdapter.Update(this);
            }
            catch (SqlException e)
            {
                if (e.ToString().Contains("Cannot insert duplicate key"))
                {
                    MessageBox.Show("Trùng mã, không thể thêm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (e.ToString().Contains("DELETE statement conflicted with COLUMN REFERENCE"))
                {
                    MessageBox.Show("Dữ liệu đã được tham chiếu, không thể xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //return false;
            }
            return true;
        }

        /// <summary>
        /// ExecuteNonQuery(SqlCommand cmd)
        /// Thuc thi cau lenh SQL va tra ve so dong bi anh huong
        /// </summary>
        /// <param name="cmd">Cau lenh SQL</param>
        /// <returns>So dong bi anh huong</returns>
        public int ExecuteNonQuery(SqlCommand cmd)
        {
            int result = 0;
            SqlTransaction tr = null;
            try
            {
                tr = m_Connection.BeginTransaction();
                cmd.Connection = m_Connection;
                cmd.Transaction = tr;
                result = cmd.ExecuteNonQuery();
                this.AcceptChanges();
                tr.Commit();
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                //throw;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public object ExecuteScalar(SqlCommand cmd)
        {
            //OpenConnection();
            object result = null;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteScalar();

                this.AcceptChanges();

                tr.Commit();

                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch(Exception e)
            {
                if (tr != null) tr.Rollback();
                //throw;
            }
            //CloseConnection();
            return result;
        }
    }
}
