using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tweetinvi;
using Tweetinvi.Models;

namespace HanahirakebaFuuuOshi.Config {
    internal class ConfigStatefulService{
        internal TwitterClient appClient { get; set; }
        internal TwitterClient userClient { get; set; }

        internal IAuthenticationRequest initialCredential { get; set; }
    }
}
