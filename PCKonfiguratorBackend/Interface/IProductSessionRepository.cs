using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Interface;

public interface IProductSessionRepository
{
    public ProductCollection GetOrCreateCollection();

    public void UpdateCollection<T>(Func<ProductCollection, T?> getProperty, Action<ProductCollection, T?> setProperty, T? value);
    
    public void RemoveCollection();
}