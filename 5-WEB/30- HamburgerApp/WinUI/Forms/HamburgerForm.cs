using BLL;
using BLL.CreaditCardRepository;
using BLL.Repository;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Forms
{
    public partial class HamburgerForm : Form
    {
        public HamburgerForm()
        {
            InitializeComponent();
        }
        BaseRepository<Hamburger> hamburgerRepository = new BaseRepository<Hamburger>();
        ProjectContext db = new ProjectContext();
        List<Extra> extraList = new List<Extra>();
        List<Order_Detail> odList = new List<Order_Detail>();
        List<Order> oList = new List<Order>();
        //Credit Card
        List<CreditCardBuilder> cardList = new List<CreditCardBuilder>();
        //Variables
        decimal basketPrice = 0;
        private void HamburgerForm_Load(object sender, EventArgs e)
        {
            //sadece true olan hamburgerler ve extralar sipariş ekranında gösterilecek. Silinen hambugerler ve extalar false a çekilecek silinmiş gösterilip listeden kaldıralacak. Ancak daha önce satılanlar hala satış raporlarında kalacak. Tekrar true yapmak istersek güncellememiz gerekecek.
            var result = db.Hamburgers.Where(x=>x.IsActive == true).ToList();
            cmbMenu.DisplayMember = "Name";
            cmbMenu.ValueMember = "ID";
            cmbMenu.DataSource = result;

            foreach (Extra ekstra in db.Extras)
            {
                if (ekstra.ID != 1) //Id=1 olan extra, extra alımı yapılmayan(extra=>none) menüler için.  
                {
                    if (ekstra.IsActive == true)
                    {
                        CheckBox chk = new CheckBox();
                        chk.Text = ekstra.Name;
                        chk.Tag = ekstra;
                        flpExtra.Controls.Add(chk);
                    }
                }
            }

            //CreditCard
            
            UseCreditCard useCreditCard = new UseCreditCard();

            CreditCardBuilder maximumCard = new Maximum();
            useCreditCard.UseCard(maximumCard);
            cardList.Add(maximumCard);

            CreditCardBuilder axessCard = new Axess();
            useCreditCard.UseCard(axessCard);
            cardList.Add(axessCard);
            CreditCardBuilder worldCard = new WorldCard();
            useCreditCard.UseCard(worldCard);
            cardList.Add(worldCard);

            cmbPayment.DataSource = cardList.ToList();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value > 0) //sipariş adedi 0'dan büyükse satış yapılabilecek
            {                
                Order_Detail od = new Order_Detail();
                Order o = new Order();
                o.TotalPrice = 0;
                int hamburgerId = Convert.ToInt32(cmbMenu.SelectedValue);
                o.HamburgerId = hamburgerId;
                string boyut = "";
                if (rbSmall.Checked)
                {
                    od.DimensionId = 1;
                    boyut = rbSmall.Text;
                }
                else if (rbMiddle.Checked)
                {
                    od.DimensionId = 2;
                    boyut = rbMiddle.Text;
                }
                else if (rbLarge.Checked)
                {
                    od.DimensionId = 3;
                    boyut = rbLarge.Text;
                }
                string extraBilgi = "";
                foreach (CheckBox chk in flpExtra.Controls)
                {
                    if (chk.Checked)
                    {
                        Extra ekstra = (Extra)chk.Tag;
                        od.ExtraId = ekstra.ID;
                        o.TotalPrice += db.Extras.FirstOrDefault(x => x.ID == od.ExtraId).Price;
                        extraList.Add(ekstra);
                        extraBilgi += chk.Text + " ";
                    }
                }

                od.Quantity = Convert.ToInt16(nudQuantity.Value);
                o.Quantity = Convert.ToInt32(nudQuantity.Value);
                o.TotalPrice += db.Hamburgers.FirstOrDefault(x => x.ID == o.HamburgerId).Price;
                o.TotalPrice += db.Dimensions.FirstOrDefault(x => x.DimensionID == od.DimensionId).Price;
                o.TotalPrice = o.TotalPrice * od.Quantity;
                basketPrice += o.KDVPrice;

                CreditCardBuilder card = (CreditCardBuilder)cmbPayment.SelectedItem; //seçilen kartı belirliyoruz.
                if (card.Card.CardLimit>basketPrice)
                {
                    
                    db.Orders.Add(o);
                    oList.Add(o);
                    db.SaveChanges();
                    od.OrderId = o.OrderID;

                    lblListAmount.Text = basketPrice.ToString("C2");

                    string format = "";
                    if (!string.IsNullOrEmpty(extraBilgi)) //Extra seçilmişse listbox'a yazılacak format
                    {
                        format = $"Menü:{cmbMenu.Text}, Dimension: {boyut}, Extras: ({extraBilgi}), Quantity:{od.Quantity} ";
                    }
                    else //Extra seçilmemişse listbox'a yazılacak format
                    {
                        format = $"Menü:{cmbMenu.Text}, Dimension: {boyut}, Extras: None, Quantity:{od.Quantity} ";
                    }
                    listBox1.Items.Add(format);

                    if (extraList.Count > 0) //Extra seçilmişse Order Detail tablosu bu şekilde doldurulacak
                    {
                        foreach (Extra extra in extraList)
                        {
                            Order_Detail oDetail = new Order_Detail();
                            oDetail.OrderId = o.OrderID;
                            oDetail.DimensionId = od.DimensionId;
                            oDetail.ExtraId = extra.ID;
                            oDetail.Quantity = od.Quantity;
                            odList.Add(oDetail);
                        }
                        extraList.Clear();
                    }
                    else //Extra seçilmemişse order detail tablosu bu şekilde doldurulacak
                    {
                        Order_Detail oDetail = new Order_Detail();
                        oDetail.OrderId = o.OrderID;
                        oDetail.DimensionId = od.DimensionId;
                        oDetail.ExtraId = 1; //extra alımı yapılmamışsa none olarak gözükecek.
                        oDetail.Quantity = od.Quantity;
                        odList.Add(oDetail);
                    }                    
                }
                else
                {
                    MessageBox.Show("Your card limit is insufficient.");
                }
            }
            else
            {
                MessageBox.Show("Sipariş adedi giriniz!");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                DialogResult dr = MessageBox.Show("Siparişi tamamlamak istediğinize emin misinz ?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CreditCardBuilder card = (CreditCardBuilder)cmbPayment.SelectedItem;
                    card.Card.CardLimit = card.Card.CardLimit - basketPrice;
                    foreach (Order_Detail od in odList)
                    {
                        db.Order_Details.Add(od);
                    }
                    db.SaveChanges();
                    odList.Clear();
                    oList.Clear();
                    basketPrice = 0;
                    lblListAmount.Text = basketPrice.ToString("C2");
                    listBox1.Items.Clear();
                }
                else
                {
                    foreach (Order order in oList)
                    {
                        db.Orders.Remove(order);
                        db.SaveChanges();
                    }
                    basketPrice = 0;
                    lblListAmount.Text = basketPrice.ToString("C2");
                    listBox1.Items.Clear();
                    odList.Clear();
                    oList.Clear();
                }
            }
            else
            {
                MessageBox.Show("You didn't have ordered yet!");
            }           
        }
    }
}
