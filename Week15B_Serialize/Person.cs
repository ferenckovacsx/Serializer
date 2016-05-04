using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week15B_Serialize
{
    [Serializable]
    class Person : IDeserializationCallback
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }
        public DateTime DateOfRecording { get; set; }

        [NonSerialized] public int SerialNumber;


        public void OnDeserialization(object sender)
        {

        }
    }
}
