using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp_Bunifu_UI
{
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }
        public bubble(string message,string time,msgtype messagetype)
        {
            InitializeComponent();
            lblmessgae.Text = message;
            lbltime.Text = time;

            if(messagetype.ToString()=="In")
            {
                //incoming message
                this.BackColor = Color.FromArgb(0, 164, 147);
            }
            else
            {
                //Outgoing Message
                this.BackColor = Color.Gray;
            }

            Setheight();
        }



      



        //lets add the function which adjusts the bubble height


        void Setheight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblmessgae.Text, lblmessgae.Font, lblmessgae.Width);

           
            lblmessgae.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lbltime.Top = lblmessgae.Bottom+10;
            this.Height = lbltime.Bottom + 10;
            
        }

        private void bubble_Resize(object sender, EventArgs e)
        {
            Setheight();
        }
    }
    public enum msgtype
    {
        In,
        Out
    }
}
