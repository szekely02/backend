namespace GameStore.DTOS;

public record class createRendelesekDto(
    string Vasarlo_ID,
    int termek_ID,
    DateOnly Rendeles_datuma,
    string fizetesi_mod,
    string szallitasi_mod
);