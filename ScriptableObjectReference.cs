using UnityEngine;

namespace GameBlocks.Base
{
	public abstract class ScriptableObjectReference<T, V> where V : ScriptableObjectVariable<T>
	{
		public bool UseConstant = true;
		public T ConstantValue;
		public V Variable;

		public ScriptableObjectReference() { }

		public ScriptableObjectReference(T value)
		{
			UseConstant = true;
			ConstantValue = value;
		}

		public T value
		{
			get { return UseConstant ? ConstantValue : Variable.value; }
		}

		public void SetValue(T newValue)
		{
			if (UseConstant)
			{
				ConstantValue = newValue;
			} else
			{
				Variable.value = newValue;
			}
			
		}

		public static implicit operator T(ScriptableObjectReference<T, V> reference)
		{
			return reference.value;
		}

		public bool IsSet()
		{
			return !this.value.Equals(null);
		}
	}
}