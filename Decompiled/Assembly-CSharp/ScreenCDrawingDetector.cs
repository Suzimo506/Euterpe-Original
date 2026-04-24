using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019A")]
public class ScreenCDrawingDetector : MonoBehaviour
{
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x43E60", Offset = "0x43260")]
	public float minDistance;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A22")]
	public float requiredAngle;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A23")]
	public float maxDrawTime;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A24")]
	private DragLineVisual m_Visual;

	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x38")]
	private List<Vector3> m_DrawnPoints;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A26")]
	private bool m_IsDrawing;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000A27")]
	private float m_DrawStartTime;

	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x48")]
	private DrawState m_CurrentState;

	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsActive;

	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_RequiredHideMusicUids;

	[Token(Token = "0x170000E1")]
	public MusicInfo CurrentMusicInfo
	{
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[Token(Token = "0x6000BA4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Address(RVA = "0x629080", Offset = "0x627880", Length = "0x4")]
	[Token(Token = "0x6000BA5")]
	public void SetDetectorActive(bool active)
	{
	}

	[Address(RVA = "0x6286E0", Offset = "0x626EE0", Length = "0x52")]
	[Token(Token = "0x6000BA6")]
	public bool CheckIsRequiredHideMusic(string musicUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x627FC0", Offset = "0x6267C0", Length = "0x15C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x629360", Offset = "0x627B60", Length = "0x35")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x628B30", Offset = "0x627330", Length = "0x378")]
	private void HandleInput()
	{
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x6291E0", Offset = "0x6279E0", Length = "0x124")]
	private void StartDrawing()
	{
	}

	[Address(RVA = "0x628740", Offset = "0x626F40", Length = "0x1BC")]
	[Token(Token = "0x6000BAB")]
	private void ContinueDrawing()
	{
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x628900", Offset = "0x627100", Length = "0x19C")]
	private void EndDrawing()
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x629310", Offset = "0x627B10", Length = "0x4D")]
	private void TimeoutDrawing()
	{
	}

	[Address(RVA = "0x628690", Offset = "0x626E90", Length = "0x4D")]
	[Token(Token = "0x6000BAE")]
	private void CheckDrawingProgress()
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x628440", Offset = "0x626C40", Length = "0x24C")]
	private bool CheckCShapeCompletion()
	{
		return default(bool);
	}

	[Address(RVA = "0x628120", Offset = "0x626920", Length = "0x318")]
	[Token(Token = "0x6000BB0")]
	private float CalculateTotalRotationAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x628EB0", Offset = "0x6276B0", Length = "0x1C4")]
	private bool IsCounterClockwise()
	{
		return default(bool);
	}

	[Address(RVA = "0x628AA0", Offset = "0x6272A0", Length = "0x85")]
	[Token(Token = "0x6000BB2")]
	private Vector3 GetMouseWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x6290B0", Offset = "0x6278B0", Length = "0x128")]
	private void SetSuccessState()
	{
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x629090", Offset = "0x627890", Length = "0x1B")]
	private void SetFailState(string reason)
	{
	}

	[Address(RVA = "0x6293A0", Offset = "0x627BA0", Length = "0x7E")]
	[Token(Token = "0x6000BB5")]
	public ScreenCDrawingDetector()
	{
	}
}
