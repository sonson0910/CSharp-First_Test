using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
    public class Apartment
    {
        string address, direction, status;
        int price, bedroom, toilet, discount;

        public Apartment(string address, string direction, string status, int price, int bedroom, int toilet, int discount = 0)
        {
            this.address = address;
            this.direction = direction;
            this.status = status;
            this.price = price;
            this.bedroom = bedroom;
            this.toilet = toilet;
            this.discount = discount;
            if (direction.Equals("West"))
            {
                this.discount = -10;
            }
            else if (direction.Equals("North West"))
            {
                this.discount = -5;
            }
            else if (direction.Equals("South West"))
            {
                this.discount = -2;
            }
            else if (direction.Equals("South East"))
            {
                this.discount = 1;
            }
        }

        public int getDiscountPrice()
        {
            return price - (this.discount * price) /100;
        }

        public string Address { get => address; set => address = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Status { get => status; set => status = value; }
        public int Price { get => price; set => price = value; }
        public int Bedroom { get => bedroom; set => bedroom = value; }
        public int Toilet { get => toilet; set => toilet = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
