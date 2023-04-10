namespace Prototype {
    public sealed class ColorManager {
        private Dictionary<string, ColorPrototype> _colors = new();
        
        public ColorPrototype this[string key] {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
