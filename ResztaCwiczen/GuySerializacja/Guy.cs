using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuySerializacja
{
    class Guy
    {
        public Guy(string name, int age, decimal cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
            TrumpCard = Card.RandomCard();
        }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int Age { get; private set; }
        [DataMember]
        public decimal Cash { get; private set; }

        [DataMember(Name = "MyCard")]
        public Card TrumpCard { get; set; }

        public override string ToString()
        {
            return String.Format("Mam na imię {0}, mam {1}, i {2} złotych w kieszeni, "
                + "i moją atutową kartą jest {3}", Name, Age, Cash, TrumpCard);
        }
    }
}
