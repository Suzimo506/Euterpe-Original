using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200017F")]
public class RandomMovement : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000971")]
	[SerializeField]
	protected RectTransform m_Rect;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000972")]
	protected float m_Speed;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x28")]
	protected RectTransform m_Uiroot;

	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x30")]
	protected float m_ScreenWidthHalf;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000975")]
	protected float m_ScreenHeightHalf;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000976")]
	protected Vector3 m_Direction;

	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x44")]
	protected float m_WidthBound;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x48")]
	protected float m_HeightBound;

	[Address(RVA = "0x56BC80", Offset = "0x56A480", Length = "0x13B")]
	[Token(Token = "0x6000AF6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x56BE60", Offset = "0x56A660", Length = "0x77")]
	private void Update()
	{
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x56BC80", Offset = "0x56A480", Length = "0x13B")]
	protected void Init()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000AF9")]
	protected virtual void Move()
	{
	}

	[Address(RVA = "0x56BDC0", Offset = "0x56A5C0", Length = "0x9B")]
	[Token(Token = "0x6000AFA")]
	protected Vector3 GetRandomPosition(float bound)
	{
		return default(Vector3);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000AFB")]
	public RandomMovement()
	{
	}
}
