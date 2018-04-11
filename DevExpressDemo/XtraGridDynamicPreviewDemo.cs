 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpressDemo
{
    public partial class XtraGridDynamicPreviewDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridDynamicPreviewDemo()
        {
            InitializeComponent();

            List<Order> orders = new List<Order>();
            orders.AddRange(new Order[]{
                    new Order(DateTime.Now,
                        new OrderLine("zhao",3,8.99m),
                        new OrderLine("qian",3,1.99m)),
                   new Order(DateTime.Now.AddDays(1),
                        new OrderLine("sun",2,4.99m),
                        new OrderLine("li",1,1.99m))
            });
            gridControl1.DataSource = orders;
        }
    }


    public class OrderLine
    {
        public OrderLine(string product, int count, decimal price)
        {
            this.product = product;
            this.count = count;
            this.price = price;
        }

        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    public class Order
    {
        public Order(DateTime timeStamp, params OrderLine[] orderLines)
        {        
            this.timeStamp = timeStamp;
            this.lines = new List<OrderLine>(orderLines);
        }

        private DateTime timeStamp;
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        private List<OrderLine> lines;
        public List<OrderLine> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        private decimal CalcValue()
        {
            decimal result = 0m;
            foreach (OrderLine line in lines)
            {
                result += line.Count + line.Price;
            }
            return result;
        }
    }
}