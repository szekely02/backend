using System;
using GameStore.DTOS;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class RendelesekMapping
{
    public static Rendelesek ToEntity(this createRendelesekDto rendeles)
    {
        return new Rendelesek()
        {
            Vasarlo_ID = rendeles.Vasarlo_ID,
            termek_ID = rendeles.termek_ID,
            Rendeles_datuma = rendeles.Rendeles_datuma,
            fizetesi_mod = rendeles.fizetesi_mod,
            szallitasi_mod = rendeles.szallitasi_mod

        };
    }   
    
    public static Rendelesek ToEntity(this UpdaterendelesekDto rendeles, int id)
    {
        return new Rendelesek()
        {
            Rendelesek_ID = id,
            Vasarlo_ID = rendeles.Vasarlo_ID,
            termek_ID = rendeles.termek_ID,
            Rendeles_datuma = rendeles.Rendeles_datuma,
            fizetesi_mod = rendeles.fizetesi_mod,
            szallitasi_mod = rendeles.szallitasi_mod

        };
    }

    public static Rendelesek ToRendelesekDetailsDto(this Rendelesek rendeles)
    {
        return new Rendelesek()
        {
            Rendelesek_ID = rendeles.Rendelesek_ID,
            Vasarlo_ID = rendeles.Vasarlo_ID,
            termek_ID = rendeles.termek_ID,
            Rendeles_datuma = rendeles.Rendeles_datuma,
            fizetesi_mod = rendeles.fizetesi_mod,
            szallitasi_mod = rendeles.szallitasi_mod
        };
    }  
}
