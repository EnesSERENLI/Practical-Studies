using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Bunu yazmamız gerekiyor yoksa Setting metodunu yazamıyoruz...

namespace WFA_McManOOP
{
    public abstract class Menus
    {
        public virtual decimal Price { get; set; }

        //Methods
        public static void Settings(ComboBox cmb, FlowLayoutPanel flp)
        {
            cmb.DataSource = Hambuger.hambugerList.ToList();
            for (int i = 0; i < Extra.extraList.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Text = Extra.extraList[i].ExtraName;
                flp.Controls.Add(chk);
            }
        }
        public abstract void Add(object obj);
        public abstract void Delete(object obj);
        public abstract void Update(object obj,string name,decimal price);    
    }
}
