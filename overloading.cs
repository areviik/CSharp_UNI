
class Program
{
    static void Main(string[] args)
    {
        Vector2D v1 = new Vector2D(1, 2);
        Vector2D v2 = new Vector2D(1, 2);
        
        Vector2D sum = v1 + v2;
        WriteLine(sum);

        Vector2D diff = v1 - v2;
        WriteLine(diff);


        Vector2D neg = -v1;
        WriteLine(neg);

        if (v1 == v2)
        {
            WriteLine("v1 == v2");
        }
        else
        {
            WriteLine("v1 != v2");
        }
    }
}