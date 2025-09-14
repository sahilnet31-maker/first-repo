using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<Destination> Destinations { get; set; } = new();

    public async Task OnGetAsync()
    {
        using var http = new HttpClient();
        var json = await http.GetStringAsync("https://localhost:5001/destinations");
        Destinations = JsonSerializer.Deserialize<List<Destination>>(json);
    }

    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}