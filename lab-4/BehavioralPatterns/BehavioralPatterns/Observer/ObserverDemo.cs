using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer
{
    public class ObserverDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n>> Observer Demo:\n");

            ObservableLightElementNode button = new ObservableLightElementNode("button");

            button.AddEventListener("mouseover", () => Console.WriteLine("Наведено курсор на кнопку!"));
            button.AddEventListener("click", () => Console.WriteLine("Кнопка була натиснута!"));
            
            button.DispatchEvent("mouseover");
            button.DispatchEvent("click");
        }
    }
}
