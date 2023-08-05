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
            // Obtener el ID del cliente desde la URL
            string clientId = Request.QueryString["clientId"];

            // Utilizar el ID del cliente para cargar los detalles del cliente y permitir la edición.
            // Aquí puedes implementar la lógica para cargar los detalles del cliente en controles de edición, etc.
        }
    }

    
    

}