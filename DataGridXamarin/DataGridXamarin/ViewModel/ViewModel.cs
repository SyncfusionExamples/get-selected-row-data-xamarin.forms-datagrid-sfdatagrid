using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridXamarin
{
    public class ViewModel : INotifyPropertyChanged
    {
        private OrderInfoRepository orderRepository;
        private ObservableCollection<OrderInfo> ordersInfo;

        public ViewModel()
        {
            orderRepository = new OrderInfoRepository();
            GenerateRows();
        }

        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set
            {
                ordersInfo = value;
                RaisePropertyChanged("OrdersInfo");
            }
        }

        private void GenerateRows()
        {
            ordersInfo = orderRepository.GenerateOrders(); 
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this,new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
