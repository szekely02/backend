using GameStore.Data;
using GameStore.DTOS;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class vasarlokEndpoints
{
    const string GetVasarlokEndpointName = "GetVasarlok"; 
    public static RouteGroupBuilder MapVasarlokEndpoints(this WebApplication app)
    {
        //Get /vasarlok
        var group = app.MapGroup("vasarlok").WithParameterValidation();
        group.MapGet("/", async (netContext dbContext) =>
         await dbContext.vasarlok.Select(vasarlo => vasarlo.TovasarlokDetailsDto())
                        .AsNoTracking().ToListAsync());
        // Get /vasarlok/1
        group.MapGet("/{id}", async (int id, netContext dbContext) =>
        {
            Vasarlok? vasarlo = await dbContext.vasarlok.FindAsync(id);

            return vasarlo is null ? Results.NotFound() : Results.Ok(vasarlo.TovasarlokDetailsDto());
        });

        //Post /vasarlok
        group.MapPost("/", async (createRendelesekDto newVasarlok, netContext dbContext) =>
        {
            Vasarlok vasarlo = newVasarlok.ToEntity();

            dbContext.vasarlok.Add(vasarlo);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetVasarlokEndpointName, new { id = vasarlo.Vasarlo_ID }, vasarlo.TovasarlokDetailsDto());
        });

        // Put /vasarlok/1
        group.MapPut("/{id}", async (int id, updatevasarlokDto updatedVasarlok, netContext dbContex) =>
        {
            var existingVasarlok = await dbContex.vasarlok.FindAsync(id);
            if (existingVasarlok is null)
            {
                return Results.NotFound();
            }

            dbContex.Entry(existingVasarlok).CurrentValues.SetValues(updatedVasarlok.ToEntity(id));
            await dbContex.SaveChangesAsync();
            return Results.NoContent();
        });

        // Delete /vasarlok/1

        group.MapDelete("/{id}", async (int id, netContext dbContex) =>
        {
           await dbContex.vasarlok.Where(vasarlo => vasarlo.Vasarlo_ID == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}