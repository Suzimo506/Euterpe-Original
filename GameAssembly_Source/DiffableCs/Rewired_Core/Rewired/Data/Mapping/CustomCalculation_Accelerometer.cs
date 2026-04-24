namespace Rewired.Data.Mapping;

public sealed class CustomCalculation_Accelerometer : CustomCalculation
{
	internal enum CalculationType
	{
		Pitch = 0,
		Roll = 1,
	}

	internal enum InputType
	{
		Acceleration = 0,
		UserAcceleration = 1,
		Gravity = 2,
	}

	internal enum OutputType
	{
		Axis = 0,
		Angle = 1,
	}

	public CalculationType _calculationType; //Field offset: 0x50
	public InputType _inputType; //Field offset: 0x54
	public OutputType _outputType; //Field offset: 0x58

	internal virtual DataType nzHslVsmGcFrcibqGPRtLDQyBOpT
	{
		internal get { } //Length: 6
	}

	public CustomCalculation_Accelerometer() { }

	internal virtual bool AqHpcTnEizGCdstWJbtLsxxoiXuR() { }

	private float dgugyzEXuTIePDYAgxBTNmScuEwDA() { }

	private float FDcGoLnpZILstdgOubLxqPLgYnut() { }

	private float fZVvDAbyGEjtKDyIxmrhssLHagAG(float unnamed_param_0) { }

	internal virtual DataType JqAclcFXAFIlIePKByHNvvfwnoUm() { }

}

