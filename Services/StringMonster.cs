using System;
using System.Collections.Generic;
using System.Text;

namespace MvCrossTestingOne.Core.Services
{
    public class StringMonster:IStringMonster
    {
        public string MonsterString(string str)
        {
            return "THIS IS A MONSTER STRING OF "+str;
        }
    }
}
