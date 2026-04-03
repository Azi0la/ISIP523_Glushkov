using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_PC_Builder
{
    public partial class basepart_
    {
        public string Typename 
        {
            get
            {
                switch (parttypeid)
                {
                    case 1:
                        return "Процессор";
                    case 2:
                        return "Видеокарата";
                    case 3:
                        return "ОЗУ";
                    case 4:
                        return "Материнская плата";
                    case 5:
                        return "Корпус";
                    case 6:
                        return "Блок питания";
                    case 7:
                        return "Охлаждение";
                    case 8:
                        return "Память";
                    default:
                        return "Пусто";

                }
            }
        }
    }


}
