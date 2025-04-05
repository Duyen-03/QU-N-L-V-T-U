using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_QLIVETAU
{
    internal class KETNOI_DULIEU
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_DuLieu()
        {
            string strKetNoi = @"Data Source = LAPTOP-A26M6F6I\MAYAO;Initial Catalog  = QLI_VETAU; Integrated Security = True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DuLieuBang(string Sql)
        {
            KetNoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;

        }

        public void ThucThi(string sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}

