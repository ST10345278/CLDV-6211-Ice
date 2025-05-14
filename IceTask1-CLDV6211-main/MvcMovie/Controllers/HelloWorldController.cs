// Import necessary librariers (tools and methods) for handling HTTP requests and responses
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// Define the namespace for this controller
// This groups the HelloWorldController class into a specific section of your code (like a folder for organization)
namespace MvcMovie.Controllers;

//This creates a controller class named HelloWorlController
public class HelloWorldController : Controller
    // The : Controller part means this class inherits from the base Controller class, which gives it the ability to handle web requests.
{
    // 
    // This method handles requests to the URL: /HelloWorld/
    // It responds to HTTP GET requests to which is used when someone visits the URL)
    // GET: /HelloWorld/ (when you Append /HelloWorld to the path in the address bar. The Index method returns a string.)
    public IActionResult Index()
    // This Index method runs the following statement which speicifies that the method shouls
    // Use a view template file to render a response to the browser
    {
        return View();
    }
    // 
    // This method handles requests to the URL: /HelloWorld/Welcome/
    // It also responds to HTTP GET requests generated when someone visits the URL
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    // The preceding code uses the C# optional-parameter feature to indicate that the numTimes paramater defaults to 1 if no value is passed for that parameter
    // Uses the HtmlEncoder.Default.Encode to protect the app from outsider input
    // Uses Interpolated Strings in $"Hello {name}, NumTimes is: {numTimes}".
}