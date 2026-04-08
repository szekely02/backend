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
    public string leiras { get; set; }
    public int ar { get; set; }
    public int akcios_ar { get; set; }
    public int Raktarkeszlet { get; set; }
}