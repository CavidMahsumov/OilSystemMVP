using OilSystemWithDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilSystemWithDB.Wiew
{
    public interface IMainWiew
    {
        EventHandler<EventArgs> ComboBoxSelectCahnnged { get; set; }
       
        EventHandler<EventArgs> LitrTxtBoxChanged { get; set; }
        EventHandler<EventArgs> MeblegTxtBoxChanged { get; set; }
        EventHandler<EventArgs> BuyBtnClicked { get; set; }
        EventHandler<EventArgs> RadioBtnCheckedChanged { get; set; }
        string OilTotalLbltextChanged { get; set; }
         int ComboboxSelectedIndex { get; set; }
        string meblegText { get; set; }
        string Litrtext { get; set; }
        List<Oil> Oils { get; set; }
        List<Cafe> cafes { set; }

    }
}
