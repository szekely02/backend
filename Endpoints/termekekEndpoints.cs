using GameStore.Data;
using GameStore.DTOS;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class termekekEndpoints
{
    const string GetTermekekEndpointName = "GetTermekek"; 
    public static RouteGroupBuilder MapTermekekEndpoints(this WebApplication app)
    {
        //Get /termekek
        var group = app.MapGroup("termekek").WithParameterValidation();

        group.MapGet("/", async (netContext dbContext) =>
         await dbContext.termekek.Include(termek => termek.Mufaj)
                        .Select(termek => termek.ToTermekekDetailsDto())
                        .AsNoTracking().ToListAsync());

        // Get /termekek/1
        group.MapGet("/{id}", async (int id, netContext dbContext) =>
        {
            Termekek? termek = await dbContext.termekek.FindAsync(id);

            return termek is null ? Results.NotFound() : Results.Ok(termek.ToTermekekDetailsDto());
        });

        //Post /termekek
        group.MapPost("/", async (createtermekekDto newTermekek, netContext dbContext) =>
        {
            Termekek termek = newTermekek.ToEntity();

            dbContext.termekek.Add(termek);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetTermekekEndpointName, new { id = termek.Jatek_ID }, termek.ToTermekekDetailsDto());
        });

        // Put /termekek/1
        group.MapPut("/{id}", async (int id, updatedTermekekDto updatedTermekek, netContext dbContex) =>
        {
            var existingTermekek = await dbContex.termekek.FindAsync(id);
            if (existingTermekek is null)
            {
                return Results.NotFound();
            }

            dbContex.Entry(existingTermekek).CurrentValues.SetValues(updatedTermekek.ToEntity(id));
            await dbContex.SaveChangesAsync();
            return Results.NoContent();
        });

        // Delete /termekek/1

        group.MapDelete("/{id}", async (int id, netContext dbContex) =>
        {
           await dbContex.termekek.Where(termek => termek.Jatek_ID == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}