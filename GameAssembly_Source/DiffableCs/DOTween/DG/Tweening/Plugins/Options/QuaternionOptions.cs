namespace DG.Tweening.Plugins.Options;

public struct QuaternionOptions : IPlugOptions
{
	public RotateMode rotateMode; //Field offset: 0x0
	public AxisConstraint axisConstraint; //Field offset: 0x4
	public Vector3 up; //Field offset: 0x8

	public override void Reset() { }

}

