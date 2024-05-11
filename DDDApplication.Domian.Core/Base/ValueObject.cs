namespace DDDApplication.Domian.Core.Base;

public abstract class ValueObject<TKey>  where  TKey :ValueObject<TKey>
{
    public override bool Equals(object? obj)
    {
        var ValueObject = obj as TKey;
        if (ReferenceEquals(ValueObject,null))
        {
            return false;
        }

        return Equalcore(ValueObject);
    }

    public static bool operator ==(ValueObject<TKey> a, ValueObject<TKey> b)
    {
        if (ReferenceEquals(a,null)&& ReferenceEquals(b,null))
        {
            return true;
        }

        if (ReferenceEquals(a,null) || ReferenceEquals(b, null))
        {
            return false;
        }

        return a.Equals(b);
    }
    public static bool operator !=(ValueObject<TKey> a, ValueObject<TKey> b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return GetHachCodeCore();
    }

    protected abstract bool Equalcore(TKey other);
    protected abstract int GetHachCodeCore();

} 