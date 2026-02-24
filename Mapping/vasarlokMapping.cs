using System;
using GameStore.DTOS;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class VasarlokMapping
{
        public static Vasarlok ToEntity(this createvasarlokDto vasarlo)
        {
            return new Vasarlok()
            {
                Nev = vasarlo.Nev,
                Email = vasarlo.Email,
                telefonszam = vasarlo.telefonszam,
                szallitasi_cim = vasarlo.szallitasi_cim
            };
        }       

    public static vasarlokdetailsDto TovasarlokDetailsDto(this Vasarlok vasarlo)
    {
        return new vasarlokdetailsDto(
            vasarlo.Nev,
            vasarlo.Email,
            vasarlo.telefonszam,
            vasarlo.szallitasi_cim
        );
    }   

    public static Vasarlok ToEntity(this updatevasarlokDto vasarlo, int id)
    {
        return new Vasarlok()
        {
            Vasarlo_ID = id,
            Nev = vasarlo.Nev,
            Email = vasarlo.Email,
            telefonszam = vasarlo.telefonszam,
            szallitasi_cim = vasarlo.szallitasi_cim
        };
    }
}
