namespace GameBlocks
{
	[System.Serializable]
	public class FloatReference : Base.ScriptableObjectReference<float, FloatVariable>
	{
		public void IncreaseBy(float number) 
		{
			this.SetValue(this.value + number);
		}
		public void DecreaseBy(float number) 
		{
			this.SetValue(this.value - number);
		}
	}
}