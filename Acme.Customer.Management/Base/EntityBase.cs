namespace Acme.Customer.Management.Base
{

    public enum EntityStateOption 
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public bool IsNew { get; protected set; }
        public bool HasChanged { get; set; }
        public bool IsValid => Validate();
        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();

    }
}