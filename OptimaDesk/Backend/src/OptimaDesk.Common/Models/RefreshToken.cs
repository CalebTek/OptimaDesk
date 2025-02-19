namespace OptimaDesk.Common.Models
{
    public class RefreshToken
    {
        public long ExpiresIn { get; set; }

        public string RefreshAccessToken { get; set; }
    }
}
