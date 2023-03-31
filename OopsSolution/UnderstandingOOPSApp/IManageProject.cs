using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApp
{
    internal interface IManageProject
    {
        void StopProject();
        void CheckStatus();
        void ChangeScope();
    }
}
