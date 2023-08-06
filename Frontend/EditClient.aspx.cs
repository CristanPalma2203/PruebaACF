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
    Client client = null;
    MethodsAPI api =  new MethodsAPI();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string clientId = Request.QueryString["clientId"];
            var readData = api.Get(BaseURL, "Client/" + clientId);
            if (readData.IsSuccessStatusCode)
            {
                var result = readData.Content.ReadAsAsync<Client>();
                result.Wait();
                client = result.Result;
                LoadData(client);

            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string clientId = Request.QueryString["clientId"];
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        int age = int.Parse(txtAge.Text);

        var jsonData = new
        {
            id = clientId,
            firstName = firstName,
            lastName = lastName,
            age = age,
            createdDate = DateTime.Now 
        };
        string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);

        var response = api.Put(BaseURL, "Client/"+ clientId, jsonString);
        if (response.IsSuccessStatusCode)
        {
            Response.Redirect("Default.aspx");
        }

    }

    private void LoadData(Client client)
    {
        txtFirstName.Text = client.FirstName;
        txtLastName.Text=client.LastName;
        txtAge.Text = client.Age.ToString();
    }
}