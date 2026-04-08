using System.ComponentModel.DataAnnotations;

public record class VasarlokDetailsDto(
    int Vasarlo_ID,
    string Nev,
    string Email,
    string telefonszam,
    string szallitasi_cim
);