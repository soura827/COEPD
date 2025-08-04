var builder = WebApplication.CreateBuilder(args);

// ✅ Configure Kestrel to listen on port 5002
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5003); // Ensure it matches your Docker mapping
});

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
