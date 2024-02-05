namespace EcommerceBlazorWebApp
{
    public class GlobalSetting
    {
        public const string DefaultEndpoint = "http://localhost:5063";

        public string ClientId { get; } = "xamarin";

        public string ClientSecret { get; } = "secret";

        public string AuthToken { get; set; } = string.Empty;

        public string ProductsEndpoint { get; set; } = string.Empty;

        public GlobalSetting()
        {
            ProductsEndpoint =  $"{DefaultEndpoint}/api/Product";
        }

        public static GlobalSetting Instance { get; } = new GlobalSetting();
    }
 
}
