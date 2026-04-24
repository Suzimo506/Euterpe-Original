using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000762")]
public class AttackEffects : IPause
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400271E")]
	public string eventType;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400271F")]
	public bool isPro;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002720")]
	private Effect m_Effect;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002721")]
	public GameObject normal;

	[Token(Token = "0x4002722")]
	[FieldOffset(Offset = "0x30")]
	public GameObject gc;

	[Token(Token = "0x4002723")]
	[FieldOffset(Offset = "0x38")]
	public GameObject touhouBlack;

	[Token(Token = "0x4002724")]
	[FieldOffset(Offset = "0x40")]
	public GameObject djMax;

	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x9C560", Offset = "0x9B960")]
	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x48")]
	private SpecialAttackEffect m_LegendRoleAttackResEffect;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002726")]
	public int preload;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4002727")]
	public int capacity;

	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 position;

	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 rotation;

	[Token(Token = "0x1700068B")]
	public bool IsGlobal
	{
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004561")]
	[Address(RVA = "0x788680", Offset = "0x786E80", Length = "0x3A2")]
	public void Init()
	{
	}

	[Token(Token = "0x6004562")]
	[Address(RVA = "0x788A30", Offset = "0x787230", Length = "0xA2")]
	public void Invoke(object sender, object rev, params object[] pars)
	{
	}

	[Token(Token = "0x6004563")]
	[Address(RVA = "0x788B00", Offset = "0x787300", Length = "0x150")]
	public void Release()
	{
	}

	[Token(Token = "0x6004564")]
	[Address(RVA = "0x788AE0", Offset = "0x7872E0", Length = "0x11")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6004565")]
	[Address(RVA = "0x788C60", Offset = "0x787460", Length = "0x11")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004566")]
	[Address(RVA = "0x788C80", Offset = "0x787480", Length = "0x15")]
	public AttackEffects()
	{
	}
}
