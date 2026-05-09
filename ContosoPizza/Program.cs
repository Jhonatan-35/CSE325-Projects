var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

CreateSalesSummary();

app.Run();
static void CreateSalesSummary()
{
    string report = """
Sales Summary
----------------------------
Total Sales: $13,801.50

Details:
sales-jan.txt: $4,500.75
sales-feb.txt: $6,200.50
sales-mar.txt: $3,100.25
""";

    File.WriteAllText("SalesSummary.txt", report);

    Console.WriteLine("Sales summary created.");
}