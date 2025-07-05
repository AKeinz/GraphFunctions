using Model;
using System.ComponentModel;

namespace ViewModel
{
    public abstract class IViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Graph currentGraph = Graph.GetGraph();
        public Graph CurrentGraph
        {
            get => currentGraph;
            set { currentGraph = value; }
        }


        public delegate void MessageHandler(string message);
        
    }
}
