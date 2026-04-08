using System.ComponentModel.DataAnnotations;

public record class updatedTermekekDto(
    string Cim,
    string Platform,
    string Kiado,
    string Mufaj,
    DateTime megjelenesi_datum,
    string korhatar_besorolas,
    string leiras,
    int ar,
    int akcios_ar,
    int Raktarkeszlet
);