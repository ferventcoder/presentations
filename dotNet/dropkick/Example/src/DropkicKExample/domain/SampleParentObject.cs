namespace DropkicKExample.domain
{
    using System.Collections.Generic;

    public class SampleParentObject : BaseDomainObjectLong
    {
        public SampleParentObject()
        {
            Children = new HashSet<SampleChildObject>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<SampleChildObject> Children { get; set; }
    }
}