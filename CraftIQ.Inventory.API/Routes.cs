namespace CraftIQ.Inventory.API
{
    public class Routes
    {
        public class CategoryRoutes
        {
            public const string BaseUrl = "/category";
            public const string Delete = BaseUrl + "/{categoryId}";
            public const string ReadById = BaseUrl + "/{categoryId}";
            public const string Update = BaseUrl + "/{categoryId}";
        }
    }
}
