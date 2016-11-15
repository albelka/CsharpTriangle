using Nancy;
using TriangleThing.Objects;

namespace TriangleThing
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["form.cshtml"];
      Get["/result"] = _ => {
        Triangle myTriangle = new Triangle(int.Parse(Request.Query["side1"]), int.Parse(Request.Query["side2"]), int.Parse(Request.Query["side3"]));

        string result = myTriangle.TypeOfTriangle();
        return View["result.cshtml", result];
      };
    }
  }
}
