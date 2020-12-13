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
        public static FrmLogin2 lf = new FrmLogin2();

        //保持dormType包中的窗体唯一性
        public static dormTypeManageFrm2 dtmf = new dormTypeManageFrm2(new MyGlobal());
        public static dormTypeInsertFrm2 dtif = new dormTypeInsertFrm2();
        public static dormTypeUpdateFrm2 dyuf = new dormTypeUpdateFrm2("");

        //保持dorm包中的窗体唯一性
        public static dormManageFrm2 dmf = new dormManageFrm2();
        public static dormInsertFrm2 dif = new dormInsertFrm2();
        public static dormUpdateFrm2 duf = new dormUpdateFrm2("","","");
        public static dormViewForm dvf = new dormViewForm();

        //保持building包中的窗体唯一性
        public static buildingManagerFrm2 bmf = new buildingManagerFrm2(new MyGlobal());
        public static buildingInsertFrm2 bif = new buildingInsertFrm2();
        public static buildingUpdateFrm2 buf = new buildingUpdateFrm2("");
    }
}
