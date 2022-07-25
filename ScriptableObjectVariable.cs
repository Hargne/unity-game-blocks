using UnityEngine;

namespace GameBlocks.Base
{
	public abstract class ScriptableObjectVariable<T> : ScriptableObject
	{
		[Multiline]
		public string DeveloperDescription = "";
		
		public T value;

		public void SetValue(T newValue)
		{
			value = newValue;
		}
	}
}