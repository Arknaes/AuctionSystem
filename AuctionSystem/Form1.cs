using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AuctionSystem
{
    /// <summary>
    /// Som udgangspunkt er bids sat til at være +5kr 
    /// Udgangsprisen er fastsat i koden
    /// </summary>
    public partial class Form1 : Form
    {
        int Price = 0;
        int BitValue = 5;

        Thread bidder1;
        Thread bidder2;
        delegate void StringArgReturningVoidDelegate(string text);
        public Form1()
        {
            InitializeComponent();
            SetText($"{Price} DKK");
        }
        private void SetText(string text)
        {
            if (this.priceLbl.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.priceLbl.Text = text;
            }
        }
        private void bitBtn1_Click(object sender, EventArgs e)
        {
            SetText($"{Price += BitValue} DKK");
        }
        private void lostUpdatesSimBtn_Click(object sender, EventArgs e)
        {
            bidder1 = new Thread(new ThreadStart(this.unsafeUpdate));
            bidder2 = new Thread(new ThreadStart(this.unsafeUpdate));
            bidder1.Start();
            bidder2.Start();

        }
        private void unsafeUpdate()
        {
            forloop();
        }
        private void bitBtnBoth_Click(object sender, EventArgs e)
        {
            bidder1 = new Thread(new ThreadStart(this.safeUpdate));
            bidder2 = new Thread(new ThreadStart(this.safeUpdate));
            bidder1.Start();
            bidder2.Start();
        }
        static readonly object _locker = new object();
        private void safeUpdate()
        {
            lock (_locker)
            {
                forloop();
            }
        }
        private void forloop()
        {
            for (int i = 0; i < 20000; i++)
            {
                SetText($"{Price += BitValue} DKK");
            }
        }
        

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Price = 0;
            priceLbl.Text = $"{Price} DKK";
        }
    }
}
