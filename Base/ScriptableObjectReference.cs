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

		public T Value
		{
			get { return UseConstant ? ConstantValue : Variable.Value; }
		}

		public void SetValue(T value)
		{
			if (UseConstant)
			{
				ConstantValue = value;
			} else
			{
				Variable.Value = value;
			}
			
		}

		public static implicit operator T(ScriptableObjectReference<T, V> reference)
		{
			return reference.Value;
		}

		public bool IsSet()
		{
			return !this.Value.Equals(null);
		}
	}
}