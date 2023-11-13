using TemplatePattern;

class Program
{
    public static void Main()
    {
        Document document = new Document();
        document.GetUserInput();


        Return ret = new Return();
        ret.GetUserInput();
    }
}