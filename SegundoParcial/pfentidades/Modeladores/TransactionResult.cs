using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfentidades.Modeladores
{
   public class TransactionResult
    {
        private bool isOk;
        private string error;
        private int id;


        public TransactionResult()
        { }

        public int ID { get=>id; set=> id=value; }
        public string Error { get => error; set => error=value; }
        public bool Isok { get => isOk; set => isOk = value; }
    }
}
