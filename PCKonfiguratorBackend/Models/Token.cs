namespace PCKonfiguratorBackend.Models
{
    public class Token
    {
        public Guid token { get; set; }
        public DateTime createTime { get; set; }

        public Token()
        {
            token = Guid.NewGuid();
            createTime = DateTime.Now;
        }

        public Token(Guid _token, DateTime _createTime)
        {
            token = _token;
            createTime = _createTime;
        }
    }
}
