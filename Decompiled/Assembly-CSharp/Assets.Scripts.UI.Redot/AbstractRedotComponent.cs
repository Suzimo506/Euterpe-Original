using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x200084B")]
public abstract class AbstractRedotComponent : MonoBehaviour, IRedot
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4002B48")]
	private string m_RedotId;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4002B49")]
	private string m_ParentRedotId;

	[SerializeField]
	[Token(Token = "0x4002B4A")]
	[FieldOffset(Offset = "0x30")]
	private bool m_InitOnAwake;

	[Token(Token = "0x1700085A")]
	public bool Result
	{
		[CompilerGenerated]
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		[Token(Token = "0x6004C2F")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700085B")]
	public string RedotId
	{
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085C")]
	public string ParentRedotId
	{
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C32")]
	[Address(RVA = "0x609000", Offset = "0x607800", Length = "0x1B6")]
	public virtual void InitRedot(string redotId, string parentRedotId = null)
	{
	}

	[Token(Token = "0x6004C33")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void UpdateRedotState();

	[Token(Token = "0x6004C34")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void AfterInitOnAwakeCallback()
	{
	}

	[Token(Token = "0x6004C35")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnAwake()
	{
	}

	[Address(RVA = "0x608FA0", Offset = "0x6077A0", Length = "0x53")]
	[Token(Token = "0x6004C36")]
	private void Awake()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004C37")]
	protected AbstractRedotComponent()
	{
	}
}
