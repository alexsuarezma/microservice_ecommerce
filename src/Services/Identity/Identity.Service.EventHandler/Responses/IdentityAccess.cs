namespace Identity.Service.EventHandler.Responses
{
    public class IdentityAccess
    {
        public bool Succeeded { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public string AccessToken { get; set; }
    }
}
