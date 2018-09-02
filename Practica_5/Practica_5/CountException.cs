using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class CountException: Exception
    {
        protected string txtbox_ProductName = null;
        public void ContarLetras(string txtbox_ProductName)
        {
            this.txtbox_ProductName = txtbox_ProductName;
            if (txtbox_ProductName.Length > 15)
            {
                throw new CountException();
            }
        }
    }
}
