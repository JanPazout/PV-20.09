using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV
{
    internal class Zlomek
    {
        public int citatel;
        public int jmenovatel;
        private int v;

        public int Citatel
        {
            get { return citatel; }
            set { citatel = value; }
        }

        public int Jmenovatel
        {

            get { return jmenovatel; }
            set { jmenovatel = value; }
        }
        public Zlomek(int citatel, int jmenovatel)
        {
            this.citatel = citatel;
            this.jmenovatel = jmenovatel;
        }

        public Zlomek(int v)
        {
            this.v = v;
        }

        public static Zlomek create(int citatel, int jmenovatel)
        {
            if (jmenovatel == 0)
            {
                throw new Exception();
            }
            return new Zlomek(citatel, jmenovatel);
        }



          public static Zlomek scitani(Zlomek z, Zlomek z2)
          {
              Zlomek zlomek = new Zlomek(z.citatel * z2.jmenovatel + z2.citatel * z.jmenovatel, z.jmenovatel * z2.jmenovatel);
              return zlomek;
          }
        public static Zlomek odcitani(Zlomek z, Zlomek z2)
        {
            Zlomek zlomek = new Zlomek(z.citatel * z2.jmenovatel - z2.citatel * z.jmenovatel, z.jmenovatel * z2.jmenovatel);
            return zlomek;  
        }
        public static Zlomek nasobeni(Zlomek z, Zlomek z2)
        {
            Zlomek zlomek = new Zlomek(z.citatel * z2.citatel, z.jmenovatel * z2.jmenovatel);
            return zlomek;
        }
        public static Zlomek deleni(Zlomek z, Zlomek z2)
        {
            Zlomek zlomek = new Zlomek(z.citatel * z2.jmenovatel, z.jmenovatel * z2.citatel);
            return zlomek;
        }
        public override string ToString()
        {
            return citatel + "/" + jmenovatel;
        }
        public void Kraceni()
        {
            citatel /= NSD(citatel, jmenovatel);
            jmenovatel /= NSD(citatel, jmenovatel);
        }
        public static int NSD(int a, int b)
        {
            int c;
            while(b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            return a;
        }


    }
}
