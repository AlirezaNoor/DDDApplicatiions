namespace DDDApplication.Domian.Core.Base;

public abstract class StronglyTypeid<T> : ValueObject<StronglyTypeid<T>>
{
    private Guid _id;

    public Guid GuidValue
    {
        get { return _id; }
        private set
        {
            if (value==Guid.Empty)
            {
                throw new BesineceExption("id most not emty");
            }

            _id = GuidValue;
        }
    }

    protected StronglyTypeid(Guid value)
    {
        GuidValue = value;
    }

    protected override bool Equalcore(StronglyTypeid<T> other)
    {
        return GuidValue == other.GuidValue;
    }

    protected override int GetHachCodeCore()
    {
        unchecked
        {
            return GuidValue.GetHashCode();
        }
    }
}