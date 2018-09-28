using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_P10
{
    class Contador
    {
        private int threshold;
        public event EventHandler ThresholdReached;

        public Contador(int passedThresHold)
        {
            threshold = passedThresHold;
        }

        public void Add(int x)
        {
            if(x >= threshold)
            {
                onThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void onThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            handler(this, e);

        }


    }
}
