using Microsoft.AspNetCore.Authentication.Cookies;
using Netflix.Solution.Controllers.Areas.Netflix.Services.Account;
using Netflix.Solution.Controllers.Areas.Netflix.Services.Content;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<IContentService, ContentService>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.Cookie.Name = "NETFLIX_AUTH";
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();

app.Run();
