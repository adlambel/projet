using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.ViewModel
{
    public class ReserveViewModel
    {
        public Match MatchToEdit { get; set; }

        public ReserveViewModel(Match m)
        {
            MatchToEdit = m;
        }

    }
}
