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
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        // Obtener los valores ingresados en los campos
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        int age = int.Parse(txtAge.Text);

        var jsonData = new
        {
            firstName = firstName,
            lastName = lastName,
            age = age,
            createdDate = DateTime.Now // Puedes cambiarlo por el valor deseado
        };
        string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);

        var response = api.Post(BaseURL, "Client", jsonString);
        if (response.IsSuccessStatusCode) {
            Response.Redirect("Default.aspx");
        }
            
    }




}