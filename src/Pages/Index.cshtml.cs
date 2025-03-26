using System.Collections.Generic;
using ExampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ExampleApp.Pages;

public class IndexModel : PageModel
{
    private readonly ProductRepository _repository;
    private readonly IConfiguration _configuration;
    private readonly ILogger<IndexModel> _logger;
    private readonly string _message;

    public IndexModel(ProductRepository repository, IConfiguration configuration, ILogger<IndexModel> logger)
    {
        _logger = logger;
        _repository = repository;
        _configuration = configuration;
        _message = configuration["MESSAGE"] ?? "Essential Docker for ASP.NET Core";
    }

    public IList<Product> Products { get; set; }

    public ActionResult OnGet()
    {
        ViewData["Message"] = _message;
        Products = _repository.Products;

        return Page();
    }
}