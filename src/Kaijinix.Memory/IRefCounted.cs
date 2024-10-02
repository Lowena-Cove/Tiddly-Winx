namespace Kaijinix.Memory
{
    public interface IRefCounted
    {
        void IncrementReferenceCount();
        void DecrementReferenceCount();
    }
}
