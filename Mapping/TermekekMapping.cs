using System;
using GameStore.DTOS;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class TermekekMapping
{
    public static Termekek ToEntity(this createtermekekDto termek)
    {
        return new Termekek()
        {
            Cim = termek.Cim,
            Platform = termek.Platform,
            Kiado = termek.Kiado,
            Mufaj = termek.Mufaj,
            megjelenesi_datum = termek.megjelenesi_datum,
            korhatar_besorolas = termek.korhatar_besorolas,
            leiras = termek.leiras,
            ar = termek.ar,
            akcios_ar = termek.akcios_ar,
            Raktarkeszlet = termek.Raktarkeszlet
        };
    }   
    public static termekekdetailsDto ToTermekekDetailsDto(this Termekek termek)
    {
        return new termekekdetailsDto(
            termek.Jatek_ID,
            termek.Cim,
            termek.Platform,
            termek.Kiado,
            termek.Mufaj,
            termek.megjelenesi_datum,
            termek.korhatar_besorolas,
            termek.leiras,
            termek.ar,
            termek.akcios_ar,
            termek.Raktarkeszlet
        );
    }

        public static Termekek ToEntity(this updatedTermekekDto termek, int id)
        {
            return new Termekek()
            {   
                Jatek_ID = id,
                Cim = termek.Cim,
                Platform = termek.Platform,
                Kiado = termek.Kiado,
                Mufaj = termek.Mufaj,
                megjelenesi_datum = termek.megjelenesi_datum,
                korhatar_besorolas = termek.korhatar_besorolas,
                leiras = termek.leiras,
                ar = termek.ar,
                akcios_ar = termek.akcios_ar,
                Raktarkeszlet = termek.Raktarkeszlet
            };
        }


     
}
