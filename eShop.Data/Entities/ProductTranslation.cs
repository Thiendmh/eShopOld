namespace eShop.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string Description { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Language Language { get; set; }

    }




}
