namespace API.Entities.User
{
    public class UserInfoCard
    {
        public string SupplementalDisplayName { get; set; }
        public string IconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public int[] ApplicableMembershipTypes { get; set; }
        public bool IsPublic { get; set; }
        public int MembershipType { get; set; }
        private long _membershipId;
        public string MembershipId 
        { 
            get => _membershipId.ToString();
            set
            {
                long.TryParse(value, out _membershipId);
            }
        }
        public string DisplayName { get; set; }
        public string BungieGlobalDisplayName { get; set; }
        public short BungieGlobalDisplayNameCode { get; set; }

        public long GetMembershipId()
        {
            return _membershipId;
        }

        public void SetMembershipId(long MembershipId)
        {
            this.MembershipId = MembershipId.ToString();
        }
    }
}