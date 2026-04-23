using Assets.Scripts.GameCore.Managers;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using PeroTools2.Pool;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;

[Token(Token = "0x2000763")]
[Attribute(Name = "RequireComponent", RVA = "0x9C950", Offset = "0x9BD50")]
public class CharacterMoveTraceController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400272A")]
	private SpriteRenderer m_SpriteRenderer;

	[Token(Token = "0x400272B")]
	[FieldOffset(Offset = "0x20")]
	private UnityGameManager.Looper m_FixedUpdateLooper;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400272C")]
	[SerializeField]
	private GameObject m_TracePoint;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400272D")]
	private Vector3 m_Offset;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400272E")]
	[Attribute(Name = "RangeAttribute", RVA = "0xCF40", Offset = "0xC340")]
	[SerializeField]
	private float m_WidthAddRate;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400272F")]
	[SerializeField]
	private float m_Height;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4002730")]
	private bool m_IsChangedToMove;

	[Token(Token = "0x4002731")]
	[FieldOffset(Offset = "0x48")]
	private TaoistGirlManager m_GirlMgr;

	[Token(Token = "0x4002732")]
	[FieldOffset(Offset = "0x50")]
	private Color m_TraceColor;

	[Token(Token = "0x6004567")]
	[Address(RVA = "0x49BBF0", Offset = "0x49A3F0", Length = "0x28F")]
	public void InitTraceWithTracePoint(GameObject tracePoint)
	{
	}

	[Token(Token = "0x6004568")]
	[Address(RVA = "0x49C300", Offset = "0x49AB00", Length = "0xB8")]
	public void SetVisible(bool isVisible)
	{
	}

	[Token(Token = "0x6004569")]
	[Address(RVA = "0x49C160", Offset = "0x49A960", Length = "0x194")]
	private void ResetState()
	{
	}

	[Token(Token = "0x600456A")]
	[Address(RVA = "0x49B5A0", Offset = "0x499DA0", Length = "0x186")]
	private void Awake()
	{
	}

	[Token(Token = "0x600456B")]
	[Address(RVA = "0x49BEE0", Offset = "0x49A6E0", Length = "0x27B")]
	private void OnFixedUpdate(float deltaTime)
	{
	}

	[Address(RVA = "0x49BB10", Offset = "0x49A310", Length = "0xD4")]
	[Token(Token = "0x600456C")]
	private void InitTraceColor()
	{
	}

	[Token(Token = "0x600456D")]
	[Address(RVA = "0x49B960", Offset = "0x49A160", Length = "0x7E")]
	private void CheckTraceCanMove()
	{
	}

	[Token(Token = "0x600456E")]
	[Address(RVA = "0x49B730", Offset = "0x499F30", Length = "0x221")]
	private void CheckIsOverScreenEdge()
	{
	}

	[Token(Token = "0x600456F")]
	[Address(RVA = "0x49B9E0", Offset = "0x49A1E0", Length = "0x12F")]
	private Pool<CharacterMoveTraceController> GetPool()
	{
		return null;
	}

	[Token(Token = "0x6004570")]
	[Address(RVA = "0x49BE80", Offset = "0x49A680", Length = "0x57")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004571")]
	[Address(RVA = "0x49C3C0", Offset = "0x49ABC0", Length = "0x15")]
	public CharacterMoveTraceController()
	{
	}
}
