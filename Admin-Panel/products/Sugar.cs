using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel.products
{
    class Sugar:Product
    {
        public Sugar() : base(99999.99f,"Сахар") { }//В поддержку санкций
    }
}
