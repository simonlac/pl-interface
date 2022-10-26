using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_plusieurs_Interfaces
{
    class Program
    {
        interface IControl
        {
            void Paint();
        }
        
        interface ISurface
        {
            void Paint();
        }

        class SampleClass : IControl, ISurface
        {
            // Implémentation de Paint
            public void Paint()
            {
                Console.WriteLine("Dessiner...");

            }
            
            // Implémenter le paint appelé par un objet IControl
            void IControl.Paint()
            {
                Console.WriteLine("IControle : Dessiner. ");
            }

            //Implémenter le paint appelé par un objet ISurface
            void ISurface.Paint()
            {
                Console.WriteLine("ISurface : Dessiner.");
            }
      

        }
        static void Main(string[] args)
        {
            // Appel de Paint 
            SampleClass mySampleClass = new SampleClass();
            mySampleClass.Paint();
            // Appel de Paint depuis IControl
            IControl myControl = new SampleClass();
            myControl.Paint();

            // Appel de Paint depuis ISurface
            ISurface mySurface = new SampleClass();
            mySurface.Paint();

            // Avec conversion
            IControl c = mySampleClass;
            c.Paint();

            ISurface s = mySampleClass;
            s.Paint();


            Console.ReadKey();
        }
    }
}
