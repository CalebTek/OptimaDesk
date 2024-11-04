namespace OptimaDesk.Common.Contracts
{
    public interface IBaseEntity
    {
        string Id { get; }
        public bool IsDeleted { get; }
        public string? CreatedBy { get; }
        public DateTime CreatedAt { get; }
        public string? UpdatedBy { get; }
        public DateTime? UpdatedAt { get; }
        public int? Version { get; }
    }
}
