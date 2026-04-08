namespace GameStore.DTOS;

public record class createRendelesekDto(
    int Vasarlo_ID,
    int termek_ID,
    DateTime Rendeles_datuma,
    string fizetesi_mod,
    string szallitasi_mod
);