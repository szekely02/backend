using System.ComponentModel.DataAnnotations;

public record class updatevasarlokDto(
    string Nev,
    string Email,
    [StringLength(11)] string telefonszam,
    string szallitasi_cim
);