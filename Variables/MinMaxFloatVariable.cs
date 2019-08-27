using UnityEngine;

namespace GameBlocks.Variables
{
	[System.Serializable]
	public struct MinMaxFloat
	{
		public float min;
		public float max;
		public float value;
	}

	[CreateAssetMenu(fileName = "MinMaxFloatVariable", menuName = "GameBlocks/Variables/MinMaxFloat")]
	public class MinMaxFloatVariable : Base.ScriptableObjectVariable<MinMaxFloat>
	{
	}
}