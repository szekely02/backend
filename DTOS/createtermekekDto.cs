using System.ComponentModel.DataAnnotations;

namespace GameStore.DTOS;

public record class createtermekekDto(
    [Required]string Cim,
    [Required]string Platform,
    [Required]string Kiado,
    [Required]string Mufaj,
    DateTime megjelenesi_datum,
    [Required]string korhatar_besorolas,
    int leiras,
    decimal ar,
    decimal akcios_ar,
    int Raktarkeszlet
);