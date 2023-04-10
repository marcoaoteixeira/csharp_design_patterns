namespace Singleton {
    public sealed class LazyLoadBalancer : ILoadBalacer {

        #region Simple singleton pattern (lazy)

        private static readonly object _lock = new();
        private static ILoadBalacer? _instance;

        public static ILoadBalacer GetInstance() {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new LazyLoadBalancer();
                }
            }
            return _instance;
        }

        // prevent construction
        private LazyLoadBalancer() {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        #endregion

        private readonly List<string> _servers = new();
        private readonly Random _random = new();

        public string GetServer() {
            var rnd = _random.Next(_servers.Count);
            return _servers[rnd].ToString();
        }
    }
}
