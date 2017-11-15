using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Demon
{
    public double Health { get; set; }

    public double Damage { get; set; }

    public Demon(double h, double d)
    {
        this.Health = h;

        this.Damage = d;
    }
}
class Task03NetherRealms
{
    static void Main(string[] args)
    {

        Dictionary<string, Demon> dataBase = new Dictionary<string, Demon>();

        Regex demonReg = new Regex(@"[^ ,]+(?=(,| |))");

        Regex healthReg = new Regex(@"[^0-9\+\.\*\/-]");

        Regex damageReg = new Regex(@"[\+\-]?[0-9]*\.?[0-9]+");

        string input = Console.ReadLine();

        var demons = demonReg.Matches(input).Cast<Match>().Select(n => n.Value).ToList();

        foreach (var demon in demons)
        {
            var currentHealth = CalculateTheHealth(healthReg, demon);

            var currentDamage = CalculateTheDamage(damageReg,demon);

            var currentDemon = new Demon(currentHealth,currentDamage);

            dataBase[demon] = currentDemon;
        }

        foreach (var demon in dataBase.OrderBy(n=>n.Key))
        {
            Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
        }
    }

    private static double CalculateTheDamage(Regex damageReg, string demon)
    {
        double sum = 0;

        var digits = damageReg.Matches(demon).Cast<Match>().Select(n => double.Parse(n.Value)).ToList();

        sum = digits.Sum();

        for (int i = 0; i < demon.Length; i++)
        {
            if (demon[i]=='*')
            {
                sum *= 2;
            }
            if (demon[i] == '/')
            {
                sum /= 2;
            }
        }
        return sum;
    }

    private static double CalculateTheHealth(Regex healthReg, string demon)
    {
        double sum = 0;

        var letters = string.Join("",healthReg.Matches(demon).Cast<Match>().Select(n => n.Value).ToList());

        sum = letters.ToCharArray().Select(n => (int)(n)).Sum();

        return sum;
    }
}

