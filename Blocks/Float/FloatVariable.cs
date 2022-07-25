using UnityEngine;

namespace GameBlocks
{
	[CreateAssetMenu(fileName = "FloatVariable", menuName = "GameBlocks/Variables/Float")]
	public class FloatVariable : Base.ScriptableObjectVariable<float>
	{
		public void ApplyChange(float amount)
		{
			SetValue(value + amount);
		}

		public void ApplyChange(FloatVariable amount)
		{
			SetValue(value + amount.value);
		}
	}
}