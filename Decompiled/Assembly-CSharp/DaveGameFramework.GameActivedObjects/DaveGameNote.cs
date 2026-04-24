using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DaveGameFramework.GameInstanceData;
using DaveGameFramework.Interfaces;
using GameLogic;
using UnityEngine;

namespace DaveGameFramework.GameActivedObjects;

[Token(Token = "0x20004D9")]
public abstract class DaveGameNote : MonoBehaviour, IUpdateController
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A65")]
	protected DaveGameNoteData m_NoteData;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A66")]
	protected DaveGameManager m_DaveGameManager;

	[Token(Token = "0x170004FB")]
	public bool IsActived
	{
		[CompilerGenerated]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		[Token(Token = "0x6003609")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		[Token(Token = "0x600360A")]
		protected set
		{
		}
	}

	[Token(Token = "0x170004FC")]
	public DaveGameNoteData NoteData
	{
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x470620", Offset = "0x46EE20", Length = "0x174")]
	[Token(Token = "0x600360C")]
	public void Init(MusicData musicData)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600360D")]
	protected virtual void OnInitComplete()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600360E")]
	public abstract void ExcuteNoteAction();

	[Address(RVA = "0x4707A0", Offset = "0x46EFA0", Length = "0x3D")]
	[Token(Token = "0x600360F")]
	public virtual void ResetNoteState()
	{
	}

	[Address(RVA = "0x4707E0", Offset = "0x46EFE0", Length = "0x2D")]
	[Token(Token = "0x6003610")]
	public virtual void SetVisible(bool visible)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003611")]
	public virtual void OnUpdate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003612")]
	public virtual void OnFixedUpdate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003613")]
	public virtual void OnLateUpdate()
	{
	}

	[Address(RVA = "0x4704F0", Offset = "0x46ECF0", Length = "0x12B")]
	[Token(Token = "0x6003614")]
	private void InitNoteData(MusicData musicData)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6003615")]
	protected DaveGameNote()
	{
	}
}
