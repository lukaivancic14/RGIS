using namespace RDuporabnik{

    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    app.MapGet("/", () => "Pozdravjeln World!");

    app.Run();

}