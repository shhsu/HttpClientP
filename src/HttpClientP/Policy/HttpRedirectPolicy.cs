using System.Collections.Generic;
using System.Linq;

namespace HttpClientP.Policy
{
    public class HttpRedirectPolicy
    {
        private readonly IEnumerable<string> _whiteLists;
        private HttpRedirectPolicy(ICollection<string> whiteLists)
        {
            _whiteLists = whiteLists.Select(host => host.ToLower()).ToArray();
        }
    }
}
