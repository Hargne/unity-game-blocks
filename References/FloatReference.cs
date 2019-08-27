namespace GameBlocks.References
{
	[System.Serializable]
	public class FloatReference : Base.ScriptableObjectReference<float, Variables.FloatVariable>
	{
		public void IncreaseBy(float number) 
		{
			this.SetValue(this.Value + number);
		}
		public void DecreaseBy(float number) 
		{
			this.SetValue(this.Value - number);
		}
	}
}