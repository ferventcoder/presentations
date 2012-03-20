namespace DropkicKExample.domain
{
    public interface IDomainObject
    {
        int? GetKeyAsInteger();
        void SetInitialInsertProperties();
        void SetUpdateProperties();
    }
}