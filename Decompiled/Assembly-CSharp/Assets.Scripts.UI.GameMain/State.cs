using System;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using TMPro;
using UnityEngine.UI;

namespace Assets.Scripts.UI.GameMain;

[Serializable]
[Token(Token = "0x2000893")]
public class State : IPause
{
	[Token(Token = "0x4002C93")]
	[FieldOffset(Offset = "0x10")]
	public TxtAnimatorType txtType;

	[Token(Token = "0x4002C94")]
	[FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x4002C95")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro textMeshPro;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C96")]
	public TextMeshProUGUI textMeshProUgui;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C97")]
	public int rangeMin;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4002C98")]
	public int rangeMax;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002C99")]
	public StateAnim txtAnim;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002C9A")]
	public StateAnim otherAnim;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002C9B")]
	public bool overrideLayer;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002C9C")]
	public string overrideLayerName;

	[Token(Token = "0x4002C9D")]
	[FieldOffset(Offset = "0x58")]
	public int overrideLayerOrder;

	[Token(Token = "0x4002C9E")]
	[FieldOffset(Offset = "0x5C")]
	public bool resetStandby;

	[Token(Token = "0x4002C9F")]
	[FieldOffset(Offset = "0x60")]
	private int prevCount;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4002CA0")]
	private bool invokeAnimator;

	[Token(Token = "0x4002CA1")]
	private const int count_in = 0;

	[Token(Token = "0x4002CA2")]
	private const int count_standby = 1;

	[Token(Token = "0x4002CA3")]
	private const int count_end = 2;

	[Token(Token = "0x4002CA4")]
	private const int count_off = 3;

	[Token(Token = "0x17000876")]
	public bool IsGlobal
	{
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x5B7E10", Offset = "0x5B6610", Length = "0x1A7")]
	[Token(Token = "0x6004DC8")]
	public void Init()
	{
	}

	[Address(RVA = "0x5B81A0", Offset = "0x5B69A0", Length = "0xCC")]
	[Token(Token = "0x6004DC9")]
	private void SetText(int count)
	{
	}

	[Address(RVA = "0x5B78C0", Offset = "0x5B60C0", Length = "0x542")]
	[Token(Token = "0x6004DCA")]
	public void Execute(int count)
	{
	}

	[Token(Token = "0x6004DCB")]
	[Address(RVA = "0x5B7FC0", Offset = "0x5B67C0", Length = "0xE7")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6004DCC")]
	[Address(RVA = "0x5B80B0", Offset = "0x5B68B0", Length = "0xE7")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004DCE")]
	[Address(RVA = "0x5B8270", Offset = "0x5B6A70", Length = "0x8C")]
	public State()
	{
	}
}
