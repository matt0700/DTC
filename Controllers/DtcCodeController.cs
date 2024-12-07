using Microsoft.AspNetCore.Mvc;

public class DtcCodeController : Controller
{
    private readonly DtcCodeTranslatorService _translatorService;

    public DtcCodeController(DtcCodeTranslatorService translatorService)
    {
        _translatorService = translatorService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(); // Returns the Index view from Views/DtcCode/Index.cshtml
    }

    [HttpPost]
    public IActionResult Translate(string dtcCode)
    {
        if (string.IsNullOrEmpty(dtcCode))
        {
            ModelState.AddModelError("", "Please enter a DTC code.");
            return View("Index"); // Return the Index view again if there is an error
        }

        var result = _translatorService.TranslateDtcCode(dtcCode.ToUpper());
        ViewBag.DtcResult = result;
        return View("Index"); // Return the Index view with the result
    }
}
