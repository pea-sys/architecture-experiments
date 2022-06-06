using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Future
{
    internal class FutureData : Data
    {
        private RealData realdata = null;
        private bool ready = false;
        private object lockObj = new object();
        public  void SetRealData(RealData realdata)
        {
            lock(lockObj)
            {
                if (ready)
                {
                    return;
                }
                this.realdata = realdata;
                this.ready = true;
                Monitor.PulseAll(lockObj);
            }
            
        }
        
        public string GetContent()
        {
            lock(lockObj)
            {
                while (!ready)
                {
                    Monitor.Wait(lockObj);
                }
                return realdata.GetContent();
            }
        }
    }
}
