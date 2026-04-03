using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_PC_Builder
{
    public partial class basepart_
    {
        public string preview
        {
            get
            {
                if (id == 0)
                {
                    return $"{name}";
                }
                else
                {
                    switch (parttypeid)
                    {
                        case 1:
                            return $"{name} \n" +
                                $"Сокет: {cpu_.socket_.name} \n" +
                                $"{cpu_.numberofcores} ядер \n" +
                                $"{cpu_.basecorefrequency}ГГц- " +
                                $"{cpu_.maxcorefrequency} макс. ГГц \n" +
                                $"L3: {cpu_.cachel3} " +
                                $"IGPU: {cpu_.hasigpu} {cpu_.igpu_.name} \n" +
                                $"Thermal power: {cpu_.thermalpower} \n" +
                                $"Производитель: {manufacturer_.name} \n" +
                                $"Цена: {price}";
                        case 2:
                            return $"{name} \n" +
                                $"{gpu_.gpuinterface_.name} \n" +
                                $"{gpu_.chipfrequency} ГГц \n" +
                                $"{gpu_.videomemory} Гб \n" +
                                $"{gpu_.memorybus}  \n" +
                                $"Рекомендуемое кол-во ватт: {gpu_.recommendpower}  \n" +
                                $"Производитель: {manufacturer_.name} \n" +
                                $"Цена: {price}";
                        case 3:
                            return $"{name} {ram_.memorytype_.name} \n" +
                                $"{ram_.capacity}Гб \n" +
                                $"Кол-во плашек: {ram_.count}  \n" +
                                $"Частота: {ram_.ghz}  \n" +
                                $"{ram_.timings}  \n" +
                                $"Производитель: {manufacturer_.name} \n" +
                                $"Цена: {price}";
                        case 4:
                            return $"{name} \n" +
                                $"Сокет:{motherboard_.socket_.name} \n" +
                                $"Форм-фактор: {motherboard_.formfactor_.name} \n" +
                                $"Слотов памяти: {motherboard_.memoryslots} \n" +
                                $"Тип памяти: {motherboard_.memorytype_.name}  \n" +
                                $"Слотов psi: {motherboard_.pcislots}  \n" +
                                $"Сата-порты: {motherboard_.sataports}  \n" +
                                $"USB-порты: {motherboard_.usbports}   \n" +
                                $"Производитель: {manufacturer_.name}   \n" +
                                $"Цена: {price}";
                        case 5:
                            return $"{name} Размер: {case_.casesize_.name} \n" +
                                $"Слотов расширения: {case_.expansionslots}   \n" +
                                $"Вентиляторы:{case_.fans}   \n" +
                                $"Производитель: {manufacturer_.name}   \n" +
                                $"Цена: {price}";
                        case 6:
                            return $"{name} {powersupply_.certificate_.name} \n" +
                                $"{powersupply_.power} Ватт \n" +
                                $"Размеры:{powersupply_.fandimension_.name}   \n" +
                                $"Производитель: {manufacturer_.name}   \n" +
                                $"Цена: {price}";
                        case 7:
                            return $"{name} Размеры:{processorcooler_.fandimension_.name} \n" +
                                $"Тепловые трубки: {processorcooler_.heatpipes} \n" +
                                $"Мин. скорость: {processorcooler_.minspeed} \n" +
                                $"Макс. скорость: {processorcooler_.maxspeed} \n" +
                                $"Уровень шума: {processorcooler_.noiselevel}  \n" +
                                $"Производитель: {manufacturer_.name} \n" +
                                $"Цена: {price}";
                        case 8:
                            switch (storagedevice_.storagedevicetype_.name)
                            {
                                case "HDD":
                                    return $"{name} {storagedevice_.storagedevicetype_.name} \n" +
                                        $"Скорость оборотов: {storagedevice_.hdd_.rotationspeed} \n" +
                                        $"Вместимость:{storagedevice_.capacity}  \n" +
                                        $"Производитель: {manufacturer_.name}  \n" +
                                        $"Цена: {price}";
                                case "SSD":
                                    return $"{name} {storagedevice_.storagedevicetype_.name} \n" +
                                        $"TBW: {storagedevice_.ssd_.tbw}  \n" +
                                        $"Вместимость:{storagedevice_.capacity}  \n" +
                                        $"Производитель: {manufacturer_.name}  \n" +
                                        $"Цена: {price}";
                                default:
                                    return $"Пусто";
                            }
                        default:
                            return $"Выберите деталь";
                    };


                }
            }
        }
    }
}
