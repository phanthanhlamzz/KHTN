using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loi_Chao_WEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Th_Dong_y.ServerClick += (Th, Ts) =>
            {

                var Ho_Ten = Th_Ho_ten.Value;
                var Loi_Chao = "Xin Chào " + Ho_Ten + "<br />"
                   + "Đây là chương trình C# đầu tiên của tui";
                Th_Loi_chao.InnerHtml = Loi_Chao;
            };

            
        }
    }
}