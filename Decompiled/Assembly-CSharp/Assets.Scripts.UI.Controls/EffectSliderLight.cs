using Cpp2ILInjected;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Attribute(Name = "RequireComponent", RVA = "0x429B0", Offset = "0x41DB0")]
[Token(Token = "0x20008AA")]
public class EffectSliderLight : MonoBehaviour
{
	[Token(Token = "0x4002D50")]
	[FieldOffset(Offset = "0x18")]
	public Slider slider;

	[Token(Token = "0x4002D51")]
	[FieldOffset(Offset = "0x20")]
	public Color from;

	[Token(Token = "0x4002D52")]
	[FieldOffset(Offset = "0x30")]
	public Color to;

	[Token(Token = "0x4002D53")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002D54")]
	public AnimationCurve curve;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002D55")]
	private Material m_Mtr;

	[Token(Token = "0x4002D56")]
	[FieldOffset(Offset = "0x58")]
	private int m_IdColor;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4002D57")]
	private int m_IdXOffset;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002D58")]
	private TweenerCore<Color, Color, ColorOptions> m_Tween;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002D59")]
	private bool init;

	[Token(Token = "0x17000883")]
	public Color color
	{
		[Token(Token = "0x6004E85")]
		[Address(RVA = "0x5ADC60", Offset = "0x5AC460", Length = "0x3A")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x5ADCA0", Offset = "0x5AC4A0", Length = "0x32")]
		set
		{
		}
	}

	[Token(Token = "0x6004E81")]
	[Address(RVA = "0x5AD700", Offset = "0x5ABF00", Length = "0x225")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004E82")]
	[Address(RVA = "0x5ADAC0", Offset = "0x5AC2C0", Length = "0x160")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x6004E83")]
	[Address(RVA = "0x5AD930", Offset = "0x5AC130", Length = "0x9D")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5AD9D0", Offset = "0x5AC1D0", Length = "0xE1")]
	[Token(Token = "0x6004E84")]
	private void OnTrigger()
	{
	}

	[Token(Token = "0x6004E87")]
	[Address(RVA = "0x5ADC30", Offset = "0x5AC430", Length = "0x27")]
	public void SetXOffset(float value)
	{
	}

	[Token(Token = "0x6004E88")]
	[Address(RVA = "0x5AD9D0", Offset = "0x5AC1D0", Length = "0xE1")]
	public void Play()
	{
	}

	[Token(Token = "0x6004E89")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public EffectSliderLight()
	{
	}
}
