using Microsoft.AspNetCore.Mvc;

namespace PCKonfiguratorBackend.Interface
{
    public interface IComponentRepository
    {
        public IActionResult GetAll(Guid token);
        
        public IActionResult SetComponentAsSelected(Guid token, Guid componentId);
    }
}
