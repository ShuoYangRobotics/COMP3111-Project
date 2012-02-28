using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }
    protected void HeadLoginView_ViewChanged(object sender, EventArgs e)
    {
        return;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var myText = TextBox1.Text;
        var url = "items.aspx?search="+myText;
        Page.Response.Redirect(url, false);
    }
}
