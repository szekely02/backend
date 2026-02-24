using GameStore.Data;
using GameStore.DTOS;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class rendelesekEndpoints
{
    const string GetRendelesekEndpointName = "GetRendelesek"; 
    public static RouteGroupBuilder MapRendelesekEndpoints(this WebApplication app)
    {
        //Get /rendelesek
        var group = app.MapGroup("rendelesek").WithParameterValidation();


        group.MapGet("/", async (netContext dbContext) =>
         await dbContext.rendelesek.Select(rendeles => rendeles.ToRendelesekDetailsDto())
                        .AsNoTracking().ToListAsync());

        // Get /rendelesek/1
        group.MapGet("/{id}", async (int id, netContext dbContext) =>
        {
            Rendelesek? rendeles = await dbContext.rendelesek.FindAsync(id);

            return rendeles is null ? Results.NotFound() : Results.Ok(rendeles.ToRendelesekDetailsDto());
        });

        //Post /rendelesek
        group.MapPost("/", async (createRendelesekDto newRendelesek, netContext dbContext) =>
        {
            Rendelesek rendeles = newRendelesek.ToEntity();

            dbContext.rendelesek.Add(rendeles);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetRendelesekEndpointName, new { id = rendeles.Rendelesek_ID }, rendeles.ToRendelesekDetailsDto());
        });

        // Put /rendelesek/1
        group.MapPut("/{id}", async (int id, UpdaterendelesekDto updatedRendelesek, netContext dbContex) =>
        {
            var existingRendelesek = await dbContex.rendelesek.FindAsync(id);
            if (existingRendelesek is null)
            {
                return Results.NotFound();
            }

            dbContex.Entry(existingRendelesek).CurrentValues.SetValues(updatedRendelesek.ToEntity(id));
            await dbContex.SaveChangesAsync();
            return Results.NoContent();
        });

        // Delete /rendelesek/1

        group.MapDelete("/{id}", async (int id, netContext dbContex) =>
        {
           await dbContex.rendelesek.Where(rendeles => rendeles.Rendelesek_ID == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}
