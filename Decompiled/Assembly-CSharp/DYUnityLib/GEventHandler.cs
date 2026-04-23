using System.Runtime.CompilerServices;
using Assets.Scripts.Managers;
using Cpp2ILInjected;

namespace DYUnityLib;

[Token(Token = "0x20004E6")]
public class GEventHandler<T> : AbstractEventHandler
{
	[Token(Token = "0x170004FE")]
	public uint id
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x600363E")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600363F")]
		private set
		{
		}
	}

	[Token(Token = "0x14000041")]
	public event TriggerHandler<T> Trigger
	{
		[CompilerGenerated]
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x135C3C0", Offset = "0x135ABC0", Length = "0xBC")]
		add
		{
		}
		[Address(RVA = "0x135C480", Offset = "0x135AC80", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600363D")]
		remove
		{
		}
	}

	[Token(Token = "0x6003640")]
	[Address(RVA = "0x924A40", Offset = "0x923240", Length = "0x12")]
	public override void ClearEvent()
	{
	}

	[Address(RVA = "0x1D8DA90", Offset = "0x1D8C290", Length = "0xC7")]
	[Token(Token = "0x6003641")]
	internal override void Play(object[] args = null)
	{
	}

	[Address(RVA = "0x1D8DD40", Offset = "0x1D8C540", Length = "0x51")]
	[Token(Token = "0x6003642")]
	public GEventHandler(uint id)
	{
	}

	[Address(RVA = "0x1D8DD00", Offset = "0x1D8C500", Length = "0x33")]
	[Token(Token = "0x6003643")]
	public void RaiseEvent(T arg)
	{
	}
}
