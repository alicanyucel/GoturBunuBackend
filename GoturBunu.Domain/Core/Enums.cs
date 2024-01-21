namespace GoturBunu.Domain.Entities
{
    public enum ERegisteryRequestStatus
    {
        Pending = 0,
        Rejected = 1,
        Approved = 2
    }

    public enum ECarrierOfferResponse
    {
        Pending = 0,
        Rejected = 1,
        Accepted = 2
    }

    public enum EOfferStageStatus
    {
        Pending = 0,
        Sent = 1,
        MovedToNext = 2,
        Done = 3
    }
}
