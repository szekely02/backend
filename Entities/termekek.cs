using System;

namespace GameStore.Entities;

public class Termekek
{
    public int Jatek_ID { get; set; }
    public string Cim { get; set; }
    public string Platform { get; set; }
    public string Kiado { get; set; }
    public string Mufaj { get; set; }
    public DateTime megjelenesi_datum { get; set; }
    public string korhatar_besorolas { get; set; }
    public int leiras { get; set; }
    public decimal ar { get; set; }
    public decimal akcios_ar { get; set; }
    public int Raktarkeszlet { get; set; }
}