namespace PCKonfiguratorBackend.Interface
{
    public interface IAuthService
    {
        public Guid GetNewToken();

        public bool ValidateToken(Guid token);
    }
}
