using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CCA.Util;

public partial class ccavRequestHandler : System.Web.UI.Page
{
    CCACrypto ccaCrypto = new CCACrypto();
    //string workingKey = "9BB933D7EB6EE50A319459B8723511A9"; 
    string workingKey = "CD704861D788AB1F35E610C70E2613FE";//put in the 32bit alpha numeric key in the quotes provided here
    string ccaRequest = "";
    public string strEncRequest = "";
    //public string strAccessCode = "AVFA71EG75AK99AFKA";
    public string strAccessCode = "AVEI80FJ77AB29IEBA";// put the access key in the quotes provided here.
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (string name in Request.Form)
            {
                if (name != null)
                {
                    if (!name.StartsWith("_"))
                    {
                        ccaRequest = ccaRequest + name + "=" + Request.Form[name] + "&";
                        /* Response.Write(name + "=" + Request.Form[name]);
                          Response.Write("</br>");*/
                    }
                }
            }
            strEncRequest = ccaCrypto.Encrypt(ccaRequest, workingKey);
        }
    }
}