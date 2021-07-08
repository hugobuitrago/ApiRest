using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
