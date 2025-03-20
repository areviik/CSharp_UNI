using System;

enum ProgrammingLanguage
{
    CSharp,
    Java,
    Python,
    JavaScript
}

class Program
{
    static void GetSpheres(ProgrammingLanguage pl)
    {
        switch (pl)
        {
            case ProgrammingLanguage.CSharp:
                Console.WriteLine(@"CSharp is used in: Game Development,
                Desktop Applications, Web Development, Mobile Development,
                Software Tools, Cloud Development.");
                break;
            case ProgrammingLanguage.Java:
                Console.WriteLine(@"Java is used in: Web Development,
                Enterprise Solutions, Mobile Development, Big Data,
                Cloud Development, Embedded Systems, Scientific Computing.");
                break;
            case ProgrammingLanguage.Python:
                Console.WriteLine(@"Python is used in: Data Science, Web Development, Automation and Scripting,
                Scientific Computing, Software Development, Cybersecurity, IoT");
                break;
            default:
                Console.WriteLine("Not found in the list!");
                break;
        }
    }

        static void Main()
        {
            ProgrammingLanguage inputLang = ProgrammingLanguage.CSharp;
            GetSpheres(inputLang);
        }
}