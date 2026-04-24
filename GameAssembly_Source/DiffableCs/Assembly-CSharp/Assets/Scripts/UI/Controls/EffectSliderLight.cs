namespace Assets.Scripts.UI.Controls;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EffectSliderLight : MonoBehaviour
{
	public Slider slider; //Field offset: 0x18
	public Color from; //Field offset: 0x20
	public Color to; //Field offset: 0x30
	public float duration; //Field offset: 0x40
	public AnimationCurve curve; //Field offset: 0x48
	private Material m_Mtr; //Field offset: 0x50
	private int m_IdColor; //Field offset: 0x58
	private int m_IdXOffset; //Field offset: 0x5C
	private TweenerCore<Color, Color, ColorOptions> m_Tween; //Field offset: 0x60
	private bool init; //Field offset: 0x68

	public Color color
	{
		 get { } //Length: 58
		 set { } //Length: 50
	}

	public EffectSliderLight() { }

	[CompilerGenerated]
	private Color <Awake>b__10_0() { }

	[CompilerGenerated]
	private void <Awake>b__10_1(Color value) { }

	[CompilerGenerated]
	private Color <ResetTween>b__11_0() { }

	[CompilerGenerated]
	private void <ResetTween>b__11_1(Color value) { }

	private void Awake() { }

	public Color get_color() { }

	private void OnDestroy() { }

	private void OnTrigger(object sender, object reciever, Object[] args) { }

	public void Play() { }

	public void ResetTween() { }

	public void set_color(Color value) { }

	public void SetXOffset(float value) { }

}

