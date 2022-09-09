using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_Log
    {
        private string acc;
        private string pass;


        public DTO_Log()
        {

        }
        public DTO_Log(string acc, string pass)
        {
            this.acc = acc;
            this.pass = pass;
        }

        public string Acc { get => acc; set => acc = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
