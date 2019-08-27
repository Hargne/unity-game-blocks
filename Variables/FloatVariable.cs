using UnityEngine;

namespace GameBlocks.Variables
{
	[CreateAssetMenu(fileName = "FloatVariable", menuName = "GameBlocks/Variables/Float")]
	public class FloatVariable : Base.ScriptableObjectVariable<float>
	{
		public void ApplyChange(float amount)
		{
			SetValue(Value + amount);
		}

		public void ApplyChange(FloatVariable amount)
		{
			SetValue(Value + amount.Value);
		}
	}
}