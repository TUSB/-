using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ハルのコマンド抽出ツール.Lib
{
    class DimentionConvert
    {
        public string GetDimentionName(int DimentionID)
        {
            string Str = null;
            switch (DimentionID)
            {
                case 0:
                    Str = "OverWorld";
                    break;
                case 1:
                    Str = "The End";
                    break;
                case -1:
                    Str = "Nether";
                    break;
            }
            return Str;
        }

        public int GetDimentionId(string DimentionName)
        {
            int id = 0;
            switch (DimentionName)
            {
                case "OverWorld":
                    id = 0;
                    break;
                case "The End":
                    id = 1;
                    break;
                case "Nether":
                    id = -1;
                    break;
            }

            return id;
        }
    }
}
