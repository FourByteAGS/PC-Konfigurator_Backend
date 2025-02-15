using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Service;

public class ProductSessionService: IProductSessionRepository
{
    public ProductCollection GetOrCreateCollection()
    {
        throw new NotImplementedException();
    }

    public void UpdateCollection<T>(Func<ProductCollection, T?> getProperty, Action<ProductCollection, T?> setProperty, T? value)
    {
        throw new NotImplementedException();
    }

    public void RemoveCollection()
    {
        throw new NotImplementedException();
    }
}