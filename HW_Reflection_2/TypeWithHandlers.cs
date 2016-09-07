using System;
using System.Reflection;

namespace HW_Reflection_2
{
    class TypeWithHandlers
    {
        public void AddEventHandlersUsingReflectionTo(TypeWithEvent typeWithEvent)
        {
            EventInfo eventInfo = typeWithEvent.GetType().GetEvent("SimpleEvent");

            MethodInfo staticHandlerInfo = this.GetType().GetMethod("StaticHandler", BindingFlags.Static | BindingFlags.NonPublic);

            eventInfo.AddEventHandler(typeWithEvent, Delegate.CreateDelegate(typeof(Action), this, "InstanceHandler"));
            eventInfo.AddEventHandler(typeWithEvent, Delegate.CreateDelegate(typeof(Action), staticHandlerInfo));
        }

        private void InstanceHandler()
        {
            Console.WriteLine("InstanceHandler: Added using reflection");
        }

        private static void StaticHandler()
        {
            Console.WriteLine("StaticHandler: Added using reflection");
        }
    }
}
