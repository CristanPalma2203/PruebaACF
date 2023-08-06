using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.Text;

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

    public HttpResponseMessage Post(string baseUrl,string path, string jsonData)
    {

        HttpClient hc = new HttpClient();
        hc.BaseAddress = new Uri(baseUrl);
        hc.DefaultRequestHeaders.Accept.Clear();
        hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var getData = hc.PostAsync(path, content);
        getData.Wait();
        return getData.Result;
    }

    public HttpResponseMessage Put(string baseUrl, string path, string jsonData)
    {

        HttpClient hc = new HttpClient();
        hc.BaseAddress = new Uri(baseUrl);
        hc.DefaultRequestHeaders.Accept.Clear();
        hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var getData = hc.PutAsync(path, content);
        getData.Wait();
        return getData.Result;
    }
}