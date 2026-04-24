using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Specials.RotaenoSpecialMusic;

[Token(Token = "0x20001B7")]
public class PnlRotaenoSpecialUnlock : MonoBehaviour
{
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button m_BtnClose;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AA7")]
	[SerializeField]
	private Image m_ImgCover;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000AA8")]
	private Transform m_CoverParent;

	[SerializeField]
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x30")]
	private RotaenoDragListener m_DragListener;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x38")]
	private float m_TotalRotation;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x40")]
	private MusicInfo m_MusicInfo;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x48")]
	private IGyroscopeHandler m_GyroscopeHandler;

	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000AAD")]
	private InputField m_TxtSlideRotationSpeed;

	[SerializeField]
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x58")]
	private InputField m_TxtRotationAttribute;

	[SerializeField]
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x60")]
	private InputField m_TxtRotationAccuracy;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AB0")]
	private float m_RotationSpeed;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000AB1")]
	private float m_GyroRotationTargetValue;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000AB2")]
	private float m_GyroRotationSpeedValue;

	[Address(RVA = "0x4DC7A0", Offset = "0x4DAFA0", Length = "0xB5")]
	[Token(Token = "0x6000C33")]
	public void Show(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x4DC1A0", Offset = "0x4DA9A0", Length = "0x8")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x4DBF00", Offset = "0x4DA700", Length = "0x299")]
	private void RefreshUIElements()
	{
	}

	[Address(RVA = "0x4DBDA0", Offset = "0x4DA5A0", Length = "0x157")]
	[Token(Token = "0x6000C36")]
	private void Hide(bool withEase)
	{
	}

	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x4DBBE0", Offset = "0x4DA3E0", Length = "0x1A4")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4DBD90", Offset = "0x4DA590", Length = "0x7")]
	[Token(Token = "0x6000C38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x4DC440", Offset = "0x4DAC40", Length = "0x356")]
	private void RotateCoverWithGyroscope()
	{
	}

	[Address(RVA = "0x4DC1B0", Offset = "0x4DA9B0", Length = "0x287")]
	[Token(Token = "0x6000C3A")]
	private void RotateCoverWithDrag()
	{
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x4DC9C0", Offset = "0x4DB1C0", Length = "0x103")]
	private void UnlockMusic()
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlRotaenoSpecialUnlock()
	{
	}
}
