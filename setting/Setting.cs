using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartMaker.setting
{
    /// <summary>
    /// 用户设置的存储对象
    /// </summary>
    class Setting
    {
        private static Setting instance;
        public static Setting Instance
        {
            get
            {
                if(instance == null) instance = new();
                return instance;
            }
        }

        public int fontsize = 18;
    }
}
