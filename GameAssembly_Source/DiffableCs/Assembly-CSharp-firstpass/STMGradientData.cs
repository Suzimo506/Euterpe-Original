//Type is in global namespace

[CreateAssetMenu]
public class STMGradientData : ScriptableObject
{
	internal enum GradientDirection
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public Gradient gradient; //Field offset: 0x18
	public float gradientSpread; //Field offset: 0x20
	public float scrollSpeed; //Field offset: 0x24
	public GradientDirection direction; //Field offset: 0x28
	public bool smoothGradient; //Field offset: 0x2C

	public STMGradientData() { }

}

