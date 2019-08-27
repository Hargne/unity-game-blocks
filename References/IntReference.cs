namespace GameBlocks.References
{
	[System.Serializable]
	public class IntReference : Base.ScriptableObjectReference<int, Variables.IntVariable>
	{
		public void IncreaseBy(int number) 
		{
			this.SetValue(this.Value + number);
		}
		public void DecreaseBy(int number) 
		{
			this.SetValue(this.Value - number);
		}
	}
}