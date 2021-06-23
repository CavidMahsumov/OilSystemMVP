using OilSystemWithDB.Data;
using OilSystemWithDB.Model;
using OilSystemWithDB.Wiew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilSystemWithDB.Presenters
{
    public class MainPresenter
    {
        private readonly OilContext _dbOil;
        private readonly CafeContext _dbCafe;
        private IMainWiew _wiew;
        public MainPresenter(IMainWiew wiew)
        {
            _dbOil = new OilContext();
            _dbCafe = new CafeContext();
            _wiew = wiew;
            _wiew.BuyBtnClicked += WiewByBtnClicked;

        }
        private void WiewByBtnClicked(object sender,EventArgs e)
        {
            Oil oil = new Oil {
                Name = _wiew.Oils[_wiew.ComboboxSelectedIndex].Name,
                Price = _wiew.Oils[_wiew.ComboboxSelectedIndex].Price
                 
            
            };
            _dbOil.Oils.Add(oil);
            _dbOil.SaveChanges();


        }

    }
}
