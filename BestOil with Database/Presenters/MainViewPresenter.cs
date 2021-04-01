using BestOil_with_Database.Data;
using BestOil_with_Database.Models;
using BestOil_with_Database.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_with_Database.Presenters
{
    public class MainViewPresenter
    {
        private readonly PaymentContext _db;
        private IMainView _view;
        public MainViewPresenter(IMainView view)
        {
            _view = view;
            _view.AddButtonClicked += ViewAddButtonClicked;
            _view.LoadButtonClicked += ViewLoadButtonClicked;
            _db = new PaymentContext();
            Payment payment = new Payment
            {
                Name = "AI-95"
            };
            Payment payment2 = new Payment
            {
                Name = "AI-92"
            };
            Payment payment3 = new Payment
            {
                Name = "Premium"
            };
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add(payment);
            comboBox1.Items.Add(payment2);
            comboBox1.Items.Add(payment3);

        }
        private void ViewAddButtonClicked(object sender, EventArgs e)
        {
            Payment payment = new Payment
            {
                Name = _view.NameText,
                Liter = double.Parse(_view.LiterText),
                Pay = double.Parse(_view.PayText),
                PaymentDateTime = DateTime.Parse(_view.PaymentDateTimeText)
            };
            _db.Payments.Add(payment);
            _db.SaveChanges();
        }
        private void ViewLoadButtonClicked(object sender, EventArgs e)
        {
            var list = _db.Payments.ToList();
            _view.payments = list;

        }

    }
}
