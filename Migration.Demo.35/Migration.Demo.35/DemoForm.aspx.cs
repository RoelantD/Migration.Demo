using Migration.Demo._35.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Migration.Demo._35
{
    public partial class DemoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoLabel.Text = SqlHelper.GetValueFromDatabase().ToString();
        }
    }
}