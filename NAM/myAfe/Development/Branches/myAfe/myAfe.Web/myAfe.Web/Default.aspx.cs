using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myAfe.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var naborEntityObj = new Nabors.Model.NaborEntity();
            naborEntityObj.Id = 1;
            naborEntityObj.Name = "Test USer";
            naborEntityObj.Description = "Testing for folder to Github repo migration";
            Response.Write("Id: " + naborEntityObj.Id + "\n" +
                "Name: " + naborEntityObj.Name + "\n" +
            "Description: " + naborEntityObj.Description + "\n");
        }
    }
}