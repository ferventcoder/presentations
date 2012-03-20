namespace DropkicKExample.domain
{
    public class SampleUser : BaseDomainObjectLong
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}