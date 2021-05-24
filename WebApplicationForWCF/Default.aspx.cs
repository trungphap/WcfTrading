using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModels;


namespace WebApplicationForWCF
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            //using (var client = new QueueServiceClient())
            //{
            //    TextBox3.Text = client.Add(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text)).ToString();
            //    TextBox4.Text = client.GetCircle().Name;
            //}         
        }
        protected void ButtonCmd_Click(object sender, EventArgs e)
        {
            //var v = new ProducerConsumer();
            //TextBox5.Text = v.Consummer2.StatusExecutable. ToString();
            //using (var client = ServiceReferenceCmd.())
            //{
            //    var globalShell = client.GetShell(true);
            //    IShell ishell = globalShell.iShell;
            //    TextBox5.Text = ishell.StatusExecutable.ToString();
            //    var v = new ProducerConsumer();
            //}
        }


    }
}