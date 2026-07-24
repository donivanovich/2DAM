using Wpf06_ProyectoLiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Wpf06_ProyectoLiga.MVVM.Model;

namespace Wpf06_ProyectoLiga.Services
{
    /// <summary>
    /// Servicio responsable de comunicarse con la API remota de un club de futbol.
    /// Expone  metodos asincronos (async) que devuelven ls modelos ya deserializados.
    /// </summary>
    public class ApiService
    {
        // HttpClient es thread-safe y se recomienda usar la misma
        // instancia durante toda la vida de la aplicacion
        private readonly HttpClient _http;

        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public ApiService()
        {
            _http = new HttpClient
            {
                //BaseAddress = new Uri("https://chetosfs.com/server/"), PARA ClasificacionView
                BaseAddress = new Uri("https://chetosfs.com/server/resultados"),
                // Opcional: ajustar Timeout si se quiere un control distinto
                // Al por defecto
                Timeout = TimeSpan.FromSeconds(15)
            };
        }

        public async Task<List<EquipoModel>> ObtenerClasificacionActual(CancellationToken cancellationToken = default)
        {
            string json = await _http.GetStringAsync("liga-tabla.php", cancellationToken)
                .ConfigureAwait(false);

            //Deserializamos el JSON en objetos C# usando System.Text.Json
            var lista = JsonSerializer.Deserialize<List<EquipoModel>>(json);

            return lista ?? new List<EquipoModel>();
        }

        public async Task<List<ResultadoModel>> ObtenerResultadosPartidos(CancellationToken cancellationToken = default)
        {
            string json = await _http.GetStringAsync("liga-tabla.php", cancellationToken)
                .ConfigureAwait(false);

            var listaResultados = JsonSerializer.Deserialize<List<ResultadoModel>>(json, _jsonOptions);

            return listaResultados ?? new List<ResultadoModel>();
        }


    }
}