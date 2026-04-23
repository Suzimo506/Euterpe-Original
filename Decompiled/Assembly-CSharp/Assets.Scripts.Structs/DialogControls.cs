using System;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200056F")]
public class DialogControls : IPause, IRelease
{
	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0x10")]
	private int m_Index;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002004")]
	[SerializeField]
	private string m_Comment;

	[Token(Token = "0x4002005")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private DialogSubControl m_UpControl;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002006")]
	[SerializeField]
	private DialogSubControl m_DownControl;

	[SerializeField]
	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_Tf;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002008")]
	private bool m_ExcludeAnim;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002009")]
	private Bone m_Body;

	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x48")]
	private Transform m_SpineTf;

	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurControl;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400200C")]
	private Vector3 m_TfOffset;

	[Token(Token = "0x1700051D")]
	public bool excludeAnim
	{
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x654CA0", Offset = "0x6534A0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700051E")]
	public int controlIndex
	{
		[Address(RVA = "0x492770", Offset = "0x490F70", Length = "0x4")]
		[Token(Token = "0x6003841")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x654CB0", Offset = "0x6534B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700051F")]
	public bool IsGlobal
	{
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003843")]
	[Address(RVA = "0x654920", Offset = "0x653120", Length = "0x48")]
	public void Init(DialogMasterControl parent, int index)
	{
	}

	[Token(Token = "0x6003844")]
	[Address(RVA = "0x654B00", Offset = "0x653300", Length = "0x54")]
	public void SetSorting(string sort, int order)
	{
	}

	[Address(RVA = "0x654AF0", Offset = "0x6532F0", Length = "0x10")]
	[Token(Token = "0x6003845")]
	public void SetOffset(Vector3 offset)
	{
	}

	[Token(Token = "0x6003846")]
	[Address(RVA = "0x654B60", Offset = "0x653360", Length = "0x134")]
	public void UpdatePosition()
	{
	}

	[Address(RVA = "0x60B340", Offset = "0x609B40", Length = "0x36")]
	[Token(Token = "0x6003847")]
	public void SetBone(Bone bone, Transform tf)
	{
	}

	[Address(RVA = "0x654970", Offset = "0x653170", Length = "0x44")]
	[Token(Token = "0x6003848")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6003849")]
	[Address(RVA = "0x654A60", Offset = "0x653260", Length = "0x33")]
	public void Resume()
	{
	}

	[Token(Token = "0x600384A")]
	[Address(RVA = "0x654900", Offset = "0x653100", Length = "0x1E")]
	public DialogSubControl GetControl(int index = -1)
	{
		return null;
	}

	[Address(RVA = "0x6549C0", Offset = "0x6531C0", Length = "0x93")]
	[Token(Token = "0x600384C")]
	public void Release(bool isEditor)
	{
	}

	[Token(Token = "0x600384D")]
	[Address(RVA = "0x654AA0", Offset = "0x6532A0", Length = "0x44")]
	public void SetHide(bool hide)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600384E")]
	public DialogControls()
	{
	}
}
