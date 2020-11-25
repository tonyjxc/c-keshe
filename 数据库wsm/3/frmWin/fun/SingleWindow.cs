using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmWin.building;
using frmWin.dorm;
using frmWin.dormType;
using keshe;

namespace frmWin.fun
{
    /// <summary>
    /// 专门用来生成窗体，保持窗体的唯一性
    /// public表示可以在别的包中调用
    /// </summary>
    class SingleWindow
    {
        ////登录窗体唯一性
        public static FrmLogin lf = new FrmLogin();

        //保持dormType包中的窗体唯一性
        public static dormTypeManageForm dtmf = new dormTypeManageForm();
        public static dormTypeInsertForm dtif = new dormTypeInsertForm();
        public static dormTypeUpdateForm dyuf = new dormTypeUpdateForm();

        //保持dorm包中的窗体唯一性
        public static dormManageForm dmf = new dormManageForm();
        public static dormInsertForm dif = new dormInsertForm();
        public static dormUpdateForm duf = new dormUpdateForm();
        public static dormViewForm dvf = new dormViewForm();

        //保持building包中的窗体唯一性
        public static buildingManagerForm bmf = new buildingManagerForm();
        public static buildingInsertForm bif = new buildingInsertForm();
        public static buildingUpdateForm buf = new buildingUpdateForm();
    }
}
