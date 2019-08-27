using UnityEngine;

namespace GameBlocks.Base
{
    public abstract class ScriptableObjectVariable<T> : ScriptableObject
    {
        [Multiline]
        public string DeveloperDescription = "";
        
        public T Value;

        public void SetValue(T value)
        {
            Value = value;
        }
    }
}