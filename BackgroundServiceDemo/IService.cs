using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceDemo
{
    public interface IService
    {
        void Start();
        void Stop();
    }
}
