using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Interfaces
{
    public interface Iservice
    {
        public void Create();
        public void Delete();
        public void GetAll();
        public void GetById();
        public void Update();
    }
}
