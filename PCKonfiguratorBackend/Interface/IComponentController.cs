using Microsoft.AspNetCore.Mvc;

namespace PCKonfiguratorBackend.Interface
{
    public interface IComponentController
    {
        public IActionResult GetAll(Guid token);
    }
}
