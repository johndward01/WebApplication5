using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication5.Models.Aviation;

namespace WebApplication5.Controllers;
public class Aviation : Controller
{
    public IActionResult Index()
    {
        var client = new HttpClient();
        var root = new CustomRoot();
        var url = "http://api.aviationstack.com/v1/flights?access_key=14e0430e92634dc857caa1f837598e0d";
        var response = client.GetStringAsync(url).Result;
        var step1 = JObject.Parse(response);
        root.flight_date = step1["data"][0]["flight_date"].ToString();
        root.flight_status = step1["data"][0]["flight_status"].ToString();
        return View(root);
    }
}
