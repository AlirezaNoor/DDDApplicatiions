using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Feature.Events;

public record class SendToCustomerEvent : DoaminEvent
{
    public FeatureId FeatureId { get; init ; }

    public SendToCustomerEvent(FeatureId featureId)
    {
        FeatureId = featureId;
        AgrigateId = featureId.GuidValue;
    }
}