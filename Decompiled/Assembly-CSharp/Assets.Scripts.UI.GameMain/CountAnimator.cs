using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x2000894")]
public class CountAnimator : MonoBehaviour, IRelease, IPause
{
	[Token(Token = "0x4002CA5")]
	[FieldOffset(Offset = "0x18")]
	public CountType countType;

	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0x20")]
	public State[] states;

	[Token(Token = "0x17000877")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6004DD5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004DCF")]
	[Address(RVA = "0x5ABF30", Offset = "0x5AA730", Length = "0x23F")]
	public void Init()
	{
	}

	[Address(RVA = "0x5ABF10", Offset = "0x5AA710", Length = "0x1B")]
	[Token(Token = "0x6004DD0")]
	private uint GetEventType()
	{
		return default(uint);
	}

	[Address(RVA = "0x5AC170", Offset = "0x5AA970", Length = "0x85")]
	[Token(Token = "0x6004DD1")]
	private void OnCountChanged(int count)
	{
	}

	[Address(RVA = "0x5AC380", Offset = "0x5AAB80", Length = "0xC1")]
	[Token(Token = "0x6004DD2")]
	public void Release(bool isEditor)
	{
	}

	[Token(Token = "0x6004DD3")]
	[Address(RVA = "0x5AC200", Offset = "0x5AAA00", Length = "0x172")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6004DD4")]
	[Address(RVA = "0x5AC450", Offset = "0x5AAC50", Length = "0x172")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004DD6")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CountAnimator()
	{
	}
}
