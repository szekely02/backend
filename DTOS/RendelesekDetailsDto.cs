using System.ComponentModel.DataAnnotations;

public record class rendelesekdetailsDto(
    int Rendelesek_ID,
    int Vasarlo_ID,
    int termek_ID,
    int Darabszam,
    DateTime Rendeles_datuma,
    string fizetesi_mod,
    string szallitasi_mod
);//szia csizi
