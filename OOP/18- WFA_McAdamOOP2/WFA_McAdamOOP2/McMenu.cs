using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdamOOP2
{
    public abstract class McMenu
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
                RadioButton rb = new RadioButton();
            }
        }
        public abstract void Add(object obj);
        public abstract void Delete(object obj);
        public abstract void Update(object obj, string name, decimal price);
    }
}
