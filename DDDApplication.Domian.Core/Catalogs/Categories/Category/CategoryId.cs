using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Category;

public  sealed class CategoryId:StronglyTypeid<CategoryId>
{
    public CategoryId(Guid value) : base(value)
    {
    }
}