namespace RepTFNet.Objects.Ban {
    public class BanInfo {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Ban SteamBans { get; set; }
        public Ban StfBans { get; set; }
        public Ban MpBans { get; set; }
        public Ban BzBans { get; set; }
        public Ban PpmBans { get; set; }
        public Ban HgBans { get; set; }
        public Ban NhsBans { get; set; }
        public StBan StBans { get; set; }
        public Ban FogBans { get; set; }
        public Ban Etf2lBans { get; set; }
        public Ban BptfBans { get; set; }
        public Ban SrBans { get; set; }
    }
}