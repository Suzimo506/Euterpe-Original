using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UI.Specials.RotaenoSpecialMusic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000196")]
public class StageBtnPlaySpecial : SingletonMonoBehaviour<StageBtnPlaySpecial>, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F6")]
	public Image btnPress;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x20")]
	private float m_StartSchedule;

	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x24")]
	private float m_MaxSchedule;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009F9")]
	private bool m_IsBtnDown;

	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsBeginHoldAnim;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurPressTimer;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009FC")]
	private Vector2 m_MousePositon;

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x38")]
	public float m_DeadDistance;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009FE")]
	private PnlStage m_PnlStage;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009FF")]
	private PnlRotaenoSpecialUnlock m_RotaenoSpecialUnlock;

	[Address(RVA = "0x515D70", Offset = "0x514570", Length = "0x31")]
	[Token(Token = "0x6000B76")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Address(RVA = "0x515DB0", Offset = "0x5145B0", Length = "0x7")]
	[Token(Token = "0x6000B77")]
	public void OnPointerUp(PointerEventData data)
	{
	}

	[Address(RVA = "0x515CA0", Offset = "0x5144A0", Length = "0xC0")]
	[Token(Token = "0x6000B78")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x515E40", Offset = "0x514640", Length = "0x47")]
	private void Start()
	{
	}

	[Address(RVA = "0x515E90", Offset = "0x514690", Length = "0x111")]
	[Token(Token = "0x6000B7A")]
	private void Update()
	{
	}

	[Address(RVA = "0x5159C0", Offset = "0x5141C0", Length = "0x2D1")]
	[Token(Token = "0x6000B7B")]
	private void HandleHideBms()
	{
	}

	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x515DC0", Offset = "0x5145C0", Length = "0x7E")]
	private void ResetInputData()
	{
	}

	[Address(RVA = "0x515FB0", Offset = "0x5147B0", Length = "0x4D")]
	[Token(Token = "0x6000B7D")]
	public StageBtnPlaySpecial()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
