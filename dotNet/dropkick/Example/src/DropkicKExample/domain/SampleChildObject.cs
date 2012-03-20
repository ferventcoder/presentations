namespace DropkicKExample.domain
{
    public class SampleChildObject : BaseDomainObjectLong
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual SampleParentObject ParentObject { get; set; }
        public long ParentObjectId { get; set; }
    }
}