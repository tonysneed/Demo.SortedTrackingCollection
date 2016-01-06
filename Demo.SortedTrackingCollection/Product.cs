using TrackableEntities.Client;

namespace Demo.SortedTrackingCollection
{
    public class Product : EntityBase
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged();
            }
        }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                NotifyPropertyChanged();
            }
        }

    }
}
