namespace GoogleMusicApi.Authentication
{
    public sealed class UserDetails
    {
        public string AndroidId { get; }

        public string Email { get; }

        public string Password { get; private set; }

        public UserDetails(string email, string password, string androidId)
        {
            Email = email;
            Password = password;
            AndroidId = androidId;
        }

        public void ClearPassword()
        {
            Password = null;
        }

        public long GetDeviceId()
        {
            return long.Parse(AndroidId, System.Globalization.NumberStyles.HexNumber);
        }
    }
}