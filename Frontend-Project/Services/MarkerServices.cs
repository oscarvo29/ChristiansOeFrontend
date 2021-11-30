using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Frontend_Project.Models;

namespace Frontend_Project.Services
{
    public class MarkerServices
    {
        private HttpClient http = new HttpClient();

        public async Task<Marker[]> GetMarkers()
        {
            Marker[] markers = await http.GetFromJsonAsync<Marker[]>("https://localhost:8080/api/marker/index");
            return markers;
        }
    }
}