using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;

/// <summary>
/// Descripción breve de MethodsAPI
/// </summary>
public class MethodsAPI
{
    public HttpResponseMessage Get(string baseUrl,string path)
    {

        HttpClient hc = new HttpClient();
        hc.BaseAddress = new Uri(baseUrl);
        hc.DefaultRequestHeaders.Accept.Clear();
        hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var getData = hc.GetAsync(path);
        getData.Wait();
        return getData.Result;
    }

    public HttpResponseMessage Delete(string baseUrl, string path)
    {

        HttpClient hc = new HttpClient();
        hc.BaseAddress = new Uri(baseUrl);
        hc.DefaultRequestHeaders.Accept.Clear();
        hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var getData = hc.DeleteAsync(path);
        getData.Wait();
        return getData.Result;
    }
}