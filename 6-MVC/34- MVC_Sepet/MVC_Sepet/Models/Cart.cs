using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sepet.Models
{
    public class Cart
    {

        //List<CartItem> _myCart = new List<CartItem>();
        Dictionary<int,CartItem> _myCart = new Dictionary<int,CartItem>(); //2 değer bekliyor. İstediğimiz tipleri verebiliriz. Birincisi anahtar deger olacak. Onunla içerisinde arama işlemlerini yapabiliriz...

        public List<CartItem> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }
        public void AddItem(CartItem cartItem)
        {
            if (_myCart.ContainsKey(cartItem.Id)) // anahtar değer ile getirme işlemi yaptık.. 
            {
                _myCart[cartItem.Id].Quantity += cartItem.Quantity;
                return;
            }
            _myCart.Add(cartItem.Id, cartItem);
        }

        public void DeleteItem(int id)
        {
            if (_myCart.ContainsKey(id))
            {
                _myCart.Remove(id);
            }
        }
    }
}