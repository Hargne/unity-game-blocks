using UnityEngine;

namespace GameBlocks.Variables
{
	[CreateAssetMenu(fileName = "IntVariable", menuName = "GameBlocks/Variables/Int")]
	public class IntVariable : Base.ScriptableObjectVariable<int>
	{
		public void ApplyChange(int amount)
		{
			Value += amount;
		}

		public void ApplyChange(IntVariable amount)
		{
			Value += amount.Value;
		}
	}
}