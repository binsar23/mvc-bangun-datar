namespace mvc_bangun_datar.Models;

public class Persegi : BangunDatar
{
    public double Sisi { get; set; }

    public override double HitungLuas()
    {
        return Sisi * Sisi;
    }
}
