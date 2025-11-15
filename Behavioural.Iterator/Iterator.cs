namespace Behavioural.Iterator
{
    internal interface Iterator<T>
    {
        T Next();
        bool HasNext();
        T Value { get; }
    }
}
