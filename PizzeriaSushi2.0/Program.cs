﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzeriaSushi2._0.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Database>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Database>();
    db.Database.EnsureCreated();
}

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

