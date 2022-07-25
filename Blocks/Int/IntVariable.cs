using UnityEngine;

namespace GameBlocks
{
	[CreateAssetMenu(fileName = "IntVariable", menuName = "GameBlocks/Variables/Int")]
	public class IntVariable : Base.ScriptableObjectVariable<int>
	{
		public void ApplyChange(int amount)
		{
			value += amount;
		}

		public void ApplyChange(IntVariable amount)
		{
			value += amount.value;
		}
	}
}