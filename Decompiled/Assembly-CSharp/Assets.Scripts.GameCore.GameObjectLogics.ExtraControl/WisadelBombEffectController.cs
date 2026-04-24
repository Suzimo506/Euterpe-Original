using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x2000770")]
public class WisadelBombEffectController : MonoBehaviour, IPause
{
	[SerializeField]
	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_VfxBomb;

	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem m_VfxBombInTouhou;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002762")]
	private ParticleSystem m_ShowVfxInstance;

	[Token(Token = "0x1700068E")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60045AC")]
	[Address(RVA = "0x4AC360", Offset = "0x4AAB60", Length = "0x25A")]
	public void Init()
	{
	}

	[Address(RVA = "0x4AC5C0", Offset = "0x4AADC0", Length = "0x45")]
	[Token(Token = "0x60045AD")]
	public void InvokeEffect()
	{
	}

	[Token(Token = "0x60045AE")]
	[Address(RVA = "0x4AC650", Offset = "0x4AAE50", Length = "0x1D")]
	public void StopEffect()
	{
	}

	[Token(Token = "0x60045AF")]
	[Address(RVA = "0x4AC610", Offset = "0x4AAE10", Length = "0x1D")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x60045B0")]
	[Address(RVA = "0x4AC630", Offset = "0x4AAE30", Length = "0x1D")]
	public void Resume()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60045B1")]
	public void Release()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60045B2")]
	public WisadelBombEffectController()
	{
	}
}
