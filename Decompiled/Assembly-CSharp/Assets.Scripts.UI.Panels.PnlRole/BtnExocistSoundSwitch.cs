using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200095D")]
public class BtnExocistSoundSwitch : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400331D")]
	[FieldOffset(Offset = "0x18")]
	private PnlRole m_Parent;

	[Token(Token = "0x400331E")]
	[FieldOffset(Offset = "0x20")]
	private Button m_BtnExocistSoundSwitch;

	[Token(Token = "0x400331F")]
	private static bool s_ShowExorcistSoundSwitch;

	[SerializeField]
	[Token(Token = "0x4003320")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ExocistSoundSwitchOn;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003321")]
	private GameObject m_ExocistSoundSwitchOff;

	[Token(Token = "0x170008F2")]
	private bool m_IsUseBuroTaoist
	{
		[Token(Token = "0x6005529")]
		[Address(RVA = "0x6386B0", Offset = "0x636EB0", Length = "0xA7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600552A")]
	[Address(RVA = "0x638480", Offset = "0x636C80", Length = "0x225")]
	private void Start()
	{
	}

	[Token(Token = "0x600552B")]
	[Address(RVA = "0x6381D0", Offset = "0x6369D0", Length = "0x175")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x637EF0", Offset = "0x6366F0", Length = "0x1AE")]
	[Token(Token = "0x600552C")]
	private void ExocistSoundSwitch()
	{
	}

	[Address(RVA = "0x637E50", Offset = "0x636650", Length = "0x9A")]
	[Token(Token = "0x600552D")]
	private void ApplyRoleEnd()
	{
	}

	[Token(Token = "0x600552E")]
	[Address(RVA = "0x6380A0", Offset = "0x6368A0", Length = "0x12E")]
	private void FancyScrollViewOnItemIndexChange()
	{
	}

	[Token(Token = "0x600552F")]
	[Address(RVA = "0x638350", Offset = "0x636B50", Length = "0x127")]
	private void SetExocistSoundSwitchShow(bool isOn = true, bool isDisableAll = false)
	{
	}

	[Token(Token = "0x6005530")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BtnExocistSoundSwitch()
	{
	}
}
