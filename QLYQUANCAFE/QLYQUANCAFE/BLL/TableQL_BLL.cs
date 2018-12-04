using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLYQUANCAFE.DTO;
using QLYQUANCAFE.Connect;
using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;

namespace QLYQUANCAFE.BLL
{
    class TableQL_BLL
    {
        ConnectDB conn = new ConnectDB();
        public void RemoveProducts(TableQL_DTO pr)
        {
            conn.Connect();
            string a = "RemoveTable('" + pr.Tenban + "')";
            conn.KetNoi(a);
        }
        public void InsertTable(TableQL_DTO pr)
        {
            conn.Connect();
            string a = "InsertTable('"+pr.Tenban+"',"+pr.Socho+")";
            conn.KetNoi(a);
        }
        public void UpdateTable(TableQL_DTO pr)
        {
            conn.Connect();
            string a = "UpdateTable('" + pr.Id + "','" + pr.Tenban + "'," + pr.Socho + ",'" + pr.Check + "')";
            conn.KetNoi(a);

        }

    }
}
