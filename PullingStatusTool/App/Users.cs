using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    static class Users
    {
       static bool flag;

        public static bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}
