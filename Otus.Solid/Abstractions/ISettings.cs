namespace Otus.Solid.Abstractions
{
    public interface ISettings
    {
        int TotalNumberAttempts { get; }
        int MinNumber { get; }
        int MaxNumber { get; }

        ISettings SetTotatNumberAttempts(int value);
        ISettings SetMinNumber(int value);
        ISettings SetMaxNumber(int value);
    }
}
