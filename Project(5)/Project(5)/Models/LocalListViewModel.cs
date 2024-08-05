using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace Project_5_.Models
{
    public class LocalListViewModel
    {
        public List<LocalList> LocalLists { get; set; }
        public User LoggedInUser { get; set; }
        public Dictionary<int?, List<LocalListCandidate>> CandidatesByList { get; set; }

    }
}
