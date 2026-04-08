using System.ComponentModel.DataAnnotations;

public record class UpdaterendelesekDto(
    int Vasarlo_ID,
    int termek_ID,
    DateTime Rendeles_datuma,
    string fizetesi_mod,
    string szallitasi_mod
);