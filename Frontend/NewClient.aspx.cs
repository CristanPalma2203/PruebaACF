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


        // Aquí puedes realizar cualquier otra lógica que necesites con los valores ingresados.
        // Por ejemplo, puedes guardarlos en la base de datos o realizar alguna otra operación.

        // Redireccionar a la página principal (por ejemplo, Default.aspx)
        Response.Redirect("Default.aspx");
    }




}