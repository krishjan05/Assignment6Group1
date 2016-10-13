using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Group1
{
    class VM : INotifyPropertyChanged
    {
        public double Mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged(); }
        }
        private double _mass;
        public double Velocity
        {
            get { return _velocity; }
            set { _velocity = value; OnPropertyChanged(); }
        }private double _velocity;

        public double KE
        {
            get { return _KE; }
            set { _KE = value; OnPropertyChanged(); }
        }private double _KE;

        public double CalcKineticEnergy(int mass, int velocity)
        {
            double KE = (0.5 * mass) * (velocity * velocity);
            return KE;
        }
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = "")
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}
