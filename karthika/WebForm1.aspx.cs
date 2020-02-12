using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HansonEntities h = new HansonEntities();
            Employe E = new Employe();
            E.FirstName = TextBox1.Text;
            E.age = int.Parse(TextBox2.Text);
            E.LoginName = TextBox3.Text;
            E.password = TextBox4.Text;
            E.Experience = int.Parse(TextBox6.Text);
            E.salary = int.Parse(TextBox7.Text);
            h.Employes.Add(E);
            h.SaveChanges();
        }

    }
}