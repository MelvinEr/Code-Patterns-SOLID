namespace ConsoleApp1
{
    public interface IPet
    {
        bool IsAttending { get; set; }
        string Name { get; set; }
        string Owner { get; set; }
    }
}