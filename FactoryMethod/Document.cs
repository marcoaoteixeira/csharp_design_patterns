namespace FactoryMethod {
    public abstract class Document {

        protected List<Page> Pages { get;set; } = new();

        protected Document() {
            CreatePages();
        }

        // Factory Method
        protected abstract void CreatePages();

        public IEnumerable<Page> GetPages() => Pages;
    }
}
