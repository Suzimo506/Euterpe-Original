namespace Rewired.Data.Mapping;

public class HardwareButtonInfo : IDeepCloneable
{
	[SerializeField]
	internal bool _excludeFromPolling; //Field offset: 0x10
	[SerializeField]
	internal bool _isPressureSensitive; //Field offset: 0x11

	public bool excludeFromPolling
	{
		 get { } //Length: 5
	}

	public bool isPressureSensitive
	{
		 get { } //Length: 5
	}

	public HardwareButtonInfo() { }

	[CustomObfuscation]
	internal HardwareButtonInfo(bool unnamed_param_0, bool unnamed_param_1) { }

	public override object DeepClone() { }

	public bool get_excludeFromPolling() { }

	public bool get_isPressureSensitive() { }

}

