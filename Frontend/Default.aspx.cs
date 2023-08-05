using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Headers;

public partial class _Default : Page
{
    string BaseURL = "https://localhost:7161/api/";

    MethodsAPI api =  new MethodsAPI(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    private void LoadData()
    {
        IEnumerable<Client> clients = null;

        var readData = api.Get(BaseURL,"Client");
        if (readData.IsSuccessStatusCode)
        {
            var result = readData.Content.ReadAsAsync<IList<Client>>();
            result.Wait();
            clients = result.Result;
            dt1.DataSource = clients;
            dt1.DataBind();
        }
       
    }

    protected void dt1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
           
            int clientId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Id"));
            LinkButton btnEdit = (LinkButton)e.Row.FindControl("btnEdit");
            LinkButton btnDelete = (LinkButton)e.Row.FindControl("btnDelete");
            btnEdit.CommandArgument = clientId.ToString();
            btnDelete.CommandArgument = clientId.ToString();
        }
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        LinkButton btnEdit = (LinkButton)sender;
        string clientId = btnEdit.CommandArgument;
        Response.Redirect($"EditClient.aspx?clientId={clientId}");
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        LinkButton btnDelete = (LinkButton)sender;
        string clientId = btnDelete.CommandArgument;
        api.Delete(BaseURL, "Client/" + clientId);
        LoadData();
    }
}