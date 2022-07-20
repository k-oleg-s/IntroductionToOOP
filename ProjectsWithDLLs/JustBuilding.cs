using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04;
/// <summary>
/// класс без фабрики
/// </summary>
public  class JustBuilding
{
    //уникальный номер здания, высота,
    //этажность, количество квартир, подъездов
    private static int _LastNumber;
    private  int Number { get;  set; }

    public  int Height { get;  set; } 
    public int Flors { get; set; }
    public int Flats { get; set; }
    public int Sections { get;  set; }


    public JustBuilding()
    {
        _LastNumber++;
        Number = _LastNumber;
    }


    //методы вычисления высоты этажа, количества квартир в
    //подъезде, количества квартир на этаже
    public float GetFlorH()
    {
        return Height / Flors;
    }

    public int GetFlatsInSection()
    {
        return Flats / Sections;
    }

    public int GetFlatsAtFlor()
    {
        return Flats / Flors;
    }

}
