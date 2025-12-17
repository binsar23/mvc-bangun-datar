namespace mvc_bangun_datar.Models;

public class Lingkaran : BangunDatar
{
    public double JariJari { get; set; }

    public override double HitungLuas()
    {
        return Math.PI * JariJari * JariJari;
    }
}
