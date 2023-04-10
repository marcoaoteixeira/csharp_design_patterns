namespace Singleton {
    public sealed class EagerLoadBalancer : ILoadBalacer {

        #region Simple singleton pattern (eager)

        private static readonly ILoadBalacer _instance = new EagerLoadBalancer();

        public static ILoadBalacer Instance => _instance;

        // prevent construction
        private EagerLoadBalancer() => Initialize();

        // Explicit static constructor to tell the C# compiler
        // not to mark type as beforefieldinit
        static EagerLoadBalancer() { }

        private void Initialize() {
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
            return _servers[rnd];
        }
    }
}
