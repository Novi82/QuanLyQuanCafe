using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.BLL
{
    public abstract class BllBase : BindableBase
    {
        public abstract void Load();
    }
}