namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }

        public string Claim { get; set; }

        public DateTime Expiration { get; set; }
    }
}
