using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Combat
{
    internal class ACombat
    {
        protected List<string> BombType { get; }
        protected List<string> EfficientVS { get; }
        protected string ActivatedBy { get; }

        protected ACombat(List<string> bombType, List<string> efficientVS, string activatedBy)
        {
            BombType = bombType;
            EfficientVS = efficientVS;
            ActivatedBy = activatedBy;
        }
    }
}
