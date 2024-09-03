using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZodiacApp.Models;
using System;

namespace lab_1_zodiac.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty(SupportsGet = true)]
    public int? Year { get; set; }
    public string ZodiacSign { get; set; }
    public bool DisplayError { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        if (Year.HasValue && Year >= 1900 && Year <= DateTime.Now.Year + 1)
        {
            ZodiacSign = Utils.GetZodiac(Year.Value);
            DisplayError = false;
        }
        else if (Year.HasValue)
        {
            DisplayError = true;
            ZodiacSign = null;
        }
    }

    public void OnPost()
    {
        if (Year.HasValue && Year >= 1900 && Year <= DateTime.Now.Year + 1)
        {
            ZodiacSign = Utils.GetZodiac(Year.Value);
            DisplayError = false;
        }
        else
        {
            DisplayError = true;
            ZodiacSign = null;
        }
    }

    public void OnPostClear()
    {
        Year = null;
        ZodiacSign = null;
        DisplayError = false;
    }
}
