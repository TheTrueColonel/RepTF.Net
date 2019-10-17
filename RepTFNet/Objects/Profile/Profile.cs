using System;

namespace RepTFNet.Objects.Profile {
    /*
     * Commented fields are unclear as to what they are, because of lack of documentation on RepTF's end
     */
    public class Profile {
        public string SteamId { get; set; }
        //public int CommunityVisibilityState { get; set; }
        //public int ProfileState { get; set; }
        public string PersonaName { get; set; }
        public DateTime LastLogoff { get; set; }
        //public int CommentPermission { get; set; }
        public string ProfileUrl { get; set; }
        public string Avatar { get; set; }
        public string AvatarMedium { get; set; }
        public string AvatarFull { get; set; }
        //public string PersonaState { get; set; }
        public string RealName { get; set; }
        public string PrimaryClanId { get; set; }
        public DateTime TimeCreated { get; set; }
        //public int PersonaStateFlags { get; set; }
        public string LocCountryCode { get; set; }
        public string LocStateCode { get; set; }
    }
}