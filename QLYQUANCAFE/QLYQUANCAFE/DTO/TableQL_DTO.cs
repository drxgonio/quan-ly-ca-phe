using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANCAFE.DTO
{
    class TableQL_DTO
    {
        private string tenban;
        private int socho;
        private bool check;
        private object id;

        public string Tenban { get => tenban; set => tenban = value; }
        public int Socho { get => socho; set => socho = value; }
        public bool Check { get => check; set => check = value; }
        public object Id { get => id; set => id = value; }
    }
}
