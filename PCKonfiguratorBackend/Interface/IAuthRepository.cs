namespace PCKonfiguratorBackend.Interface
{
    public interface IAuthRepository
    {
        public Guid GetNewToken();

        public bool ValidateToken(Guid token);
    }
}
