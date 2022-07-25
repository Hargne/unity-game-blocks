namespace GameBlocks
{
	[System.Serializable]
	public class IntReference : Base.ScriptableObjectReference<int, IntVariable>
	{
		public void IncreaseBy(int number) 
		{
			this.SetValue(this.value + number);
		}
		public void DecreaseBy(int number) 
		{
			this.SetValue(this.value - number);
		}
	}
}