using System.ComponentModel.DataAnnotations;

public record class VasarlokdetailsDto(
    string Nev,
    string Email,
    string telefonszam,
    string szallitasi_cim
);