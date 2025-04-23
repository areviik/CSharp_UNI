class Grade
{
    public string Subj { get; set; }
    public int Score { get; set; }
}

class Student
{
    private Grade[] g = new Grade[5];

    public Grade this[int i]
    {
        get
        {
            if (i >= 0 && i < g.Length)
                return g[i];
            return null;
        }
        set
        {
            if (i >= 0 && i < g.Length)
                g[i] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s[0] = new Grade { Subj = "Math", Score = 95 };
        s[1] = new Grade { Subj = "Physics", Score = 88 };

        for (int i = 0; i < 5; i++)
        {
            if (s[i] != null)
                Console.WriteLine($"Subject: {s[i].Subj}, Score: {s[i].Score}");
        }
    }
}
