using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Pr_PC_Builder
{
    public class Assemble
    {
        public List<basepart_> partlist = new List<basepart_> 
        {
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 1, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 2, image = "/Images/monke.jpg", price = 0}, 
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 3, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 4, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 5, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 6, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 7, image = "/Images/monke.jpg", price = 0},
            new basepart_ {name = "Пусто", manufacturerid = 100, parttypeid = 8, image = "/Images/monke.jpg", price = 0}
        };

        //лист в классе, из которого будут делаться 2 экземпляра: 1 для сборки, 2 статичный 
        //в классе должны быть описаны методы для работы с деталями, по типу выбора, замены, удаления

    }
}
