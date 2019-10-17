namespace RepTFNet.Objects.Ban {
    public class Ban {
        public string Banned { get; set; }
        public string Message { get; set; }

        public bool GetBanned () => 
            string.Equals(Banned, "good");
    }
}