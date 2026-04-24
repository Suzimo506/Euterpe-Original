namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class ButtonLoopSet : UpdateLoopDataSet<ButtonData>
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class ButtonData
	{
		public readonly UpdateLoopType updateLoop; //Field offset: 0x10
		public readonly Boolean[] values; //Field offset: 0x18
		public readonly Boolean[] wasTrueThisFrame; //Field offset: 0x20
		private Boolean[] OcQjcpNUKloWWEccWktHKOQxgzBx; //Field offset: 0x28
		private int DfvFqYOcbtzJYZUPBHJVUzsAflhr; //Field offset: 0x30
		private readonly Boolean[] ssDfBqeYhjHxJEQmPXgqaZZVeUHuA; //Field offset: 0x38
		private readonly Boolean[] DAcwQFJqIRTsnfMxyBkGeyvyAHwUA; //Field offset: 0x40

		public Boolean[] effectiveValue
		{
			 get { } //Length: 42
		}

		public ButtonData(int unnamed_param_0, UpdateLoopType unnamed_param_1) { }

		public void Clear() { }

		public void ClearWasTrueThisFrame() { }

		public Boolean[] get_effectiveValue() { }

		public void Import(ButtonData source) { }

		public void SetValue(int index, bool value) { }

		private void vVwgKWPyfCWNLRcWztaezNcTkUuD() { }

	}

	public readonly int buttonCount; //Field offset: 0x38

	public ButtonLoopSet(UpdateLoopSetting unnamed_param_0, int unnamed_param_1) { }

	public void Clear() { }

	public void Import(ButtonLoopSet set) { }

	public void SetValue(int index, bool value, double timestamp) { }

}

