using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialize
{
    [Serializable]
    public class sinhvien
    {
        public string Ma { get; set; }
        public string ten { get; set; }
        public float nmm { get; set; }
        public float lthdt { get; set; }
        public float csdl { get; set; }
        public float dtb { get; set; }  
        public override string ToString()
        {
            return Ma.ToString() + "-" + ten.ToString() + " Điểm trung bình:" + dtb.ToString()  ;
        }
    }
}
