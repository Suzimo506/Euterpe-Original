using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;
using Cpp2ILInjected;
using PeroTools2.Pool;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000733")]
public class TaoistGirlManager : GeneralGirlManager
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40025D8")]
	public Pool<CharacterMoveTraceController> tracePool;

	[Token(Token = "0x40025D9")]
	[FieldOffset(Offset = "0xA0")]
	private string m_ResourceName;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40025DA")]
	private GameObject m_TracePoint;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40025DB")]
	private bool m_CanCreateNew;

	[Token(Token = "0x40025DC")]
	[FieldOffset(Offset = "0xB8")]
	private string m_FixedUpdateUid;

	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 m_TracePointTempPos;

	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0xCC")]
	private Vector2 m_TracePointOffset;

	[Token(Token = "0x60042FB")]
	[Address(RVA = "0x7D3B80", Offset = "0x7D2380", Length = "0x353")]
	public override void InstanceGirl()
	{
	}

	[Token(Token = "0x60042FC")]
	[Address(RVA = "0x7D41C0", Offset = "0x7D29C0", Length = "0xCC")]
	public override void SetJumpingAction(bool value)
	{
	}

	[Token(Token = "0x60042FD")]
	[Address(RVA = "0x7D3EE0", Offset = "0x7D26E0", Length = "0x7D")]
	public bool IsDoubleClickOrPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60042FE")]
	[Address(RVA = "0x7D4140", Offset = "0x7D2940", Length = "0x73")]
	public override void Release()
	{
	}

	[Token(Token = "0x60042FF")]
	[Address(RVA = "0x7D3960", Offset = "0x7D2160", Length = "0xC9")]
	private void CheckAndCreateTrace(bool isJump)
	{
	}

	[Token(Token = "0x6004300")]
	[Address(RVA = "0x7D3F60", Offset = "0x7D2760", Length = "0x10C")]
	private void OnFixedUpdate(float arg0)
	{
	}

	[Token(Token = "0x6004301")]
	[Address(RVA = "0x7D3A90", Offset = "0x7D2290", Length = "0xE2")]
	private CharacterMoveTraceController CreateTrace()
	{
		return null;
	}

	[Address(RVA = "0x7D4070", Offset = "0x7D2870", Length = "0x9F")]
	[Token(Token = "0x6004302")]
	private void OnPop(CharacterMoveTraceController ctrl)
	{
	}

	[Address(RVA = "0x7D4110", Offset = "0x7D2910", Length = "0x22")]
	[Token(Token = "0x6004303")]
	private void OnPush(CharacterMoveTraceController ctrl)
	{
	}

	[Token(Token = "0x6004304")]
	[Address(RVA = "0x7D3A30", Offset = "0x7D2230", Length = "0x51")]
	private void ClearTrace(CharacterMoveTraceController obj)
	{
	}

	[Token(Token = "0x6004305")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	public TaoistGirlManager()
	{
	}
}
