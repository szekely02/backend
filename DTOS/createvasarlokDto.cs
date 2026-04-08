using System.ComponentModel.DataAnnotations;

public record class createvasarlokDto(
    [Required]string Nev,
    [Required]string Email,
    [StringLength(11)] string telefonszam,
    [Required]string szallitasi_cim
);