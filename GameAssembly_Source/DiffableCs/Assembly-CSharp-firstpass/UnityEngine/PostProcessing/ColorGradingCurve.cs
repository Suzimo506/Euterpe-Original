namespace UnityEngine.PostProcessing;

public sealed class ColorGradingCurve
{
	public AnimationCurve curve; //Field offset: 0x10
	[SerializeField]
	private bool m_Loop; //Field offset: 0x18
	[SerializeField]
	private float m_ZeroValue; //Field offset: 0x1C
	[SerializeField]
	private float m_Range; //Field offset: 0x20
	private AnimationCurve m_InternalLoopingCurve; //Field offset: 0x28

	public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	public void Cache() { }

	public float Evaluate(float t) { }

}

