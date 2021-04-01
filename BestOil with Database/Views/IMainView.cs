using BestOil_with_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_with_Database.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        string NameText { get; }
        string LiterText { get; set; }
        string PayText { get; set; }
        string PaymentDateTimeText { get; set; }
        List<Payment> payments { set; }
    }
}
