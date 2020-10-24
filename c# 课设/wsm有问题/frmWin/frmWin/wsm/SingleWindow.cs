using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.wsm
{
    /// <summary>
    /// 专门用来生成窗体，保持窗体的唯一性
    /// public表示可以在别的包中调用
    /// </summary>
    class SingleWindow
    {
        ////登录窗体唯一性
        public static FrmLogin lf = new FrmLogin();
    }
}
