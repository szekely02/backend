using System.ComponentModel.DataAnnotations;

namespace GameStore.DTOS;

public record class createtermekekDto(
    [Required]string Cim,
    [Required]string Platform,
    [Required]string Kiado,
    [Required]string Mufaj,
    DateTime megjelenesi_datum,
    [Required]string korhatar_besorolas,
    string leiras,
    int ar,
    int akcios_ar,
    int Raktarkeszlet
);