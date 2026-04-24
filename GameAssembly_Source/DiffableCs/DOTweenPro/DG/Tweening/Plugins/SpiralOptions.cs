namespace DG.Tweening.Plugins;

public struct SpiralOptions : IPlugOptions
{
	public float depth; //Field offset: 0x0
	public float frequency; //Field offset: 0x4
	public float speed; //Field offset: 0x8
	public SpiralMode mode; //Field offset: 0xC
	public bool snapping; //Field offset: 0x10
	internal float unit; //Field offset: 0x14
	internal Quaternion axisQ; //Field offset: 0x18

	public override void Reset() { }

}

