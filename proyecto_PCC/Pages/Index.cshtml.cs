using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace proyecto_PCC.Pages;

public class IndexModel : PageModel
{
    public List<CasoEmpresa> Empresas { get; private set; } = [];
    public List<TabuladorSalarial> Tabuladores { get; private set; } = [];
    public List<VacanteLocal> VacantesAgs { get; private set; } = [];
    public List<PasoCompilacion> FlujoDotNet { get; private set; } = [];

    public void OnGet()
    {
        FlujoDotNet =
        [
            new("1. Declaración del Proyecto", "proyecto_PCC.csproj",
                "Archivo XML basado en Microsoft.NET.Sdk.Web donde se declaran el TargetFramework (net10.0), opciones de compilación (Nullable, ImplicitUsings) y los paquetes NuGet."),
            new("2. Host y Pipeline Web", "Program.cs",
                "Configura el contenedor de inyección de dependencias (AddRazorPages), middlewares HTTP (HTTPS, archivos estáticos, enrutamiento) y arranca el servidor Kestrel."),
            new("3. Compilación Roslyn a CIL", "bin/Debug/.../proyecto_PCC.dll",
                "Al ejecutar dotnet build, el compilador Roslyn verifica sintaxis y tipos, generando un ensamblado .dll con código intermedio (CIL) y metadatos."),
            new("4. Ejecución CLR + RyuJIT", "Runtime de .NET",
                "El CLR carga proyecto_PCC.dll, valida seguridad de tipos con el CTS, RyuJIT compila a código nativo del CPU y el Garbage Collector gestiona la memoria.")
        ];

        VacantesAgs =
        [
            new("Link-Worldwide", ".NET Core", "$16,000 – $18,000 MXN/mes", "Aguascalientes (local)"),
            new("Link-Worldwide", "C# / VB.NET / SQL", "$25,000 MXN/mes", "Aguascalientes (local)"),
            new("4.2 TR network", "Desarrollo .NET", "$22,000 MXN/mes", "Aguascalientes (local)")
        ];

        Tabuladores =
        [
            new("ags", "Aguascalientes (MXN / mes)",
                "Estimación a partir de vacantes locales publicadas ($16k–$25k) y promedios nacionales.",
                "$12,000 – $18,000", "Vacantes locales no siempre separan nivel; rango de entrada.",
                "$20,000 – $30,000", "Referencia local observada entre $22,000 y $25,000 MXN.",
                "$32,000 – $50,000", "Las vacantes Senior suelen ser remotas o vía consultoras."),
            new("mx", "México Nacional (MXN / mes)",
                "Rangos nacionales publicados en bolsas de trabajo (OCC y promedios del sector).",
                "$10,354 – $22,713", "Promedio nacional de $15,336 MXN/mes.",
                "$25,000 – $40,000", "Promedio base ~$18,700; perfiles con experiencia suben a $25k–$40k.",
                "$24,000 – $50,000+", "Anual $288k–$600k (prom. $396k). Ofertas top en OCC llegan a $75,000 – $85,000."),
            new("remoto", "Remoto LATAM / EE. UU. (USD / mes)",
                "Contratación internacional (contractor); casi todas exigen inglés avanzado (C1).",
                "$600 – $800 USD", "Puestos Jr remotos son escasos (ej. residentes Perú, Colombia o Ecuador).",
                "$4,500 – $6,000 USD", "Perfiles Mid con 3+ años de experiencia e inglés conversacional.",
                "$5,000 – $9,000 USD", "Rangos desde $2.5k–$6k; con +10 años de experiencia alcanzan $6,000 – $9,000 USD."),
            new("usa", "Extranjero en EE. UU. (USD / año)",
                "Sueldos anuales reportados en mercado estadounidense (Payscale / Salary.com).",
                "$40,000 – $70,000", "Promedio Payscale: $53,466 USD/año (Salary.com: $65,160 USD).",
                "$89,447 USD/año", "Promedio anual para desarrollador .NET Mid-Level en EE. UU.",
                "$90,000 – $137,000", "Promedio $110,920 USD/año; en Nueva York promedia $158,600 USD/año.")
        ];

        Empresas =
        [
            // Industrial / Manufactura
            new("Cerveza Corona (Grupo Modelo)", "Industrial / Manufactura", "Aguascalientes", "Programación / Sistemas",
                "Vacantes de programador de tiempo completo para soporte y operación en planta Aguascalientes."),
            new("Link-Worldwide", "Industrial / Manufactura", "Aguascalientes", ".NET Core / C# / SQL",
                "Contratación local de desarrolladores .NET Core (3 años exp.) y perfiles C#/VB.NET/SQL ($16k–$25k MXN)."),
            new("Capgemini & Softtek (Bebidas)", "Industrial / Manufactura", "Aguascalientes", "C# / .NET",
                "Consultoras con vacantes activas en C# en Aguascalientes, incluyendo proyectos dedicados a la industria de bebidas."),
            new("4.2 TR network", "Industrial / Manufactura", "Aguascalientes", "Desarrollo .NET",
                "Desarrollo de software empresarial y soluciones .NET en Aguascalientes (ofertas locales de $22,000 MXN)."),
            new("Ruhrpumpen, Impresos Cometa y Gulfstream Aerospace", "Industrial / Manufactura", "N. L. / Gto. / Mexicali", "C# / .NET",
                "Manufactura pesada (García, N.L.), artes gráficas (León, Gto.) e industria aeroespacial (Mexicali) usando C#."),

            // Salud
            new("Grupo Diagnóstico Aries", "Salud", "México", "C# / .NET Senior",
                "Sector diagnóstico y laboratorios clínicos; destaca entre las empresas que mejor remuneran perfiles Senior en .NET."),
            new("Audioclinic", "Salud", "CDMX", "C# / .NET",
                "Desarrollo de sistemas para el sector salud en Ciudad de México con rangos publicados de $30,000 a $35,000 MXN/mes."),
            new("AstroSirens LLC", "Salud", "Remoto LATAM", "C# / .NET / FinTech",
                "Empresa con contratación remota para Latinoamérica desarrollando proyectos tecnológicos en salud y fintech."),

            // Banca, seguros y consultoras
            new("BBVA", "Banca, Seguros y Consultoras", "México / Híbrido", "C# / .NET / Microservicios",
                "Institución financiera con alta demanda de ingeniería de software empresarial, APIs y seguridad en .NET."),
            new("Capgemini (Sector Seguros) & IDS Comercial", "Banca, Seguros y Consultoras", "CDMX / México", "C# / .NET",
                "Desarrollo de plataformas core para aseguradoras y banca con ecosistema Microsoft .NET."),
            new("Softtek & BairesDev", "Banca, Seguros y Consultoras", "Aguascalientes / LATAM", "C# / ASP.NET Core",
                "Dos de las principales firmas de consultoría TI con mayor volumen de vacantes en C# y .NET."),
            new("Nortal, CodeRoad, Nearsure e ioet", "Banca, Seguros y Consultoras", "Remoto LATAM", "C# / .NET / Azure",
                "Empresas internacionales que contratan talento .NET en toda Latinoamérica bajo modalidad remota."),

            // Entretenimiento
            new("Estudio de eSports (EE. UU.)", "Entretenimiento", "Remoto LATAM", "Senior Back-end C# / .NET",
                "Empresa estadounidense de deportes electrónicos con vacantes Senior Back-end C#/.NET remotas para LATAM (sin vacantes locales con nombre propio en Ags).")
        ];
    }

    public IActionResult OnPostEvaluarPerfil([FromBody] SolicitudEvaluacion datos)
    {
        var resultado = datos switch
        {
            { InglesAvanzado: true, AniosExperiencia: >= 5, SabeNube: true } => new
            {
                Nivel = "Senior .NET Remoto (EE. UU. / LATAM)",
                SueldoEstimado = "$5,000 – $9,000 USD/mes (~3x a 5x más que local)",
                Detalle = "Con inglés C1, +5 años, Azure, SQL Server y microservicios accedes a los topes internacionales (o $6k–$9k USD con +10 años)."
            },
            { InglesAvanzado: true, AniosExperiencia: >= 3 } => new
            {
                Nivel = "Mid-Level .NET Remoto Internacional",
                SueldoEstimado = "$4,500 – $6,000 USD/mes",
                Detalle = "El inglés avanzado (C1) y experiencia en .NET Core / microservicios te permiten brincar del mercado local al remoto en dólares."
            },
            { AniosExperiencia: >= 5 } => new
            {
                Nivel = "Senior .NET México / Consultoría",
                SueldoEstimado = "$32,000 – $50,000 MXN/mes (hasta $75k–$85k en ofertas top)",
                Detalle = "En Aguascalientes y México las vacantes Senior se concentran en consultoras (Softtek, Capgemini) y banca."
            },
            { AniosExperiencia: >= 2 } => new
            {
                Nivel = "Mid-Level .NET (Aguascalientes / Nacional)",
                SueldoEstimado = "$20,000 – $30,000 MXN/mes (hasta $40,000 nacional)",
                Detalle = "En Aguascalientes las vacantes publicadas rondan los $22,000 – $25,000 MXN/mes en empresas como Link-Worldwide o 4.2 TR network."
            },
            _ => new
            {
                Nivel = "Junior C# / .NET",
                SueldoEstimado = "$12,000 – $18,000 MXN/mes (Prom. nacional: $15,336 MXN)",
                Detalle = "Los puestos Jr remotos en USD son escasos ($600–$800 USD); conviene iniciar en vacantes locales o consultoras en México."
            }
        };

        return new JsonResult(resultado);
    }

    public record PasoCompilacion(string Titulo, string Archivo, string Explicacion);
    public record VacanteLocal(string Empresa, string Stack, string Sueldo, string Ubicacion);
    public record TabuladorSalarial(
        string Id, string Region, string Nota,
        string JrRango, string JrDetalle,
        string MidRango, string MidDetalle,
        string SrRango, string SrDetalle);
    public record CasoEmpresa(string Nombre, string Sector, string Ubicacion, string Tecnologia, string Descripcion);
    public record SolicitudEvaluacion(int AniosExperiencia, bool SabeNube, bool InglesAvanzado);
}

