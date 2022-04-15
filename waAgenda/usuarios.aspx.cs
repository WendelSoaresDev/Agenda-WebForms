using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSourceUsuario_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void SqlDataSourceUsuario_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {

        }

        protected void SqlDataSourceUsuario_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                iMsg.Text = "Inserindo um registro que já existe no banco de dados ou com campo(s) em branco!";
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSourceUsuario_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void SqlDataSourceUsuario_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                iMsg.Text = "Alterando um registro sem informar todos os campos!";
                e.ExceptionHandled = true;
            }
        }
    }
}