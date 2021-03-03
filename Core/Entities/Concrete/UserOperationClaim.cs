namespace Core.Entities.Concrete
{
    class UserOperationClaim :IEntity
    {
        public int id { get; set; }
        public int MyProperty { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
