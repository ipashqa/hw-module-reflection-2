using System;
using System.Reflection;

namespace HW_Reflection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeWithEvent typeWithEvent = new TypeWithEvent();
            TypeWithHandlers typeWithHandlers = new TypeWithHandlers();

            typeWithEvent.SimpleEvent += () => Console.WriteLine("Pam-pam 1");
            typeWithEvent.SimpleEvent += () => Console.WriteLine("Pam-pam 2");

            typeWithHandlers.AddEventHandlersUsingReflectionTo(typeWithEvent);

            typeWithEvent.TriggerEvent();
        }
    }
}
