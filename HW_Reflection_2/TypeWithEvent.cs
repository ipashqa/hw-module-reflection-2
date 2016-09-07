using System;

namespace HW_Reflection_2
{
    class TypeWithEvent
    {
        public event Action SimpleEvent;

        public void TriggerEvent()
        {
            this.SimpleEvent?.Invoke();
        }
    }
}
