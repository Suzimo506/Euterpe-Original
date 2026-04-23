using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000889")]
public class PnlTipsManager : SerializedMonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002C78")]
	private static PnlTipsManager s_Instance;

	[Token(Token = "0x4002C79")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Dictionary<string, AbstractMessageBox> m_MessageBoxs;

	[Token(Token = "0x4002C7A")]
	[SerializeField]
	protected static AudioClip s_YesClip;

	[Token(Token = "0x4002C7B")]
	[SerializeField]
	protected static AudioClip s_NoClip;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002C7C")]
	public PnlSwitchConnectNetTip pnlSwitchConnectNetTip;

	[Token(Token = "0x17000873")]
	public static AudioClip yesClickSfx
	{
		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0x5FFDF0", Offset = "0x5FE5F0", Length = "0x36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000874")]
	public static AudioClip noClickSfx
	{
		[Address(RVA = "0x5FFDB0", Offset = "0x5FE5B0", Length = "0x36")]
		[Token(Token = "0x6004DAD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000875")]
	public static PnlTipsManager instance
	{
		[Address(RVA = "0x5FFD00", Offset = "0x5FE500", Length = "0xAC")]
		[Token(Token = "0x6004DAE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004DAF")]
	[Address(RVA = "0x5FF2F0", Offset = "0x5FDAF0", Length = "0x25E")]
	private void Init()
	{
	}

	[Token(Token = "0x6004DB0")]
	[Address(RVA = "0x5FFB60", Offset = "0x5FE360", Length = "0x19E")]
	private void Start()
	{
	}

	[Token(Token = "0x6004DB1")]
	[Address(RVA = "0x5FF550", Offset = "0x5FDD50", Length = "0x1AE")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004DB2")]
	[Address(RVA = "0x5FF930", Offset = "0x5FE130", Length = "0x229")]
	public GeneralMessageBox ShowMessageBox(string msg, string title = null, ButtonType showButtonType = ButtonType.Yes)
	{
		return null;
	}

	[Token(Token = "0x6004DB3")]
	[Address(RVA = "0x5FF790", Offset = "0x5FDF90", Length = "0x196")]
	public GeneralMessageBox ShowMessageBox(Action<GeneralMessageBox> msgBoxOptsAction)
	{
		return null;
	}

	[Address(RVA = "0x5FF240", Offset = "0x5FDA40", Length = "0xA7")]
	[Token(Token = "0x6004DB4")]
	public AbstractMessageBox GetMessageBox(string key)
	{
		return null;
	}

	[Token(Token = "0x6004DB5")]
	[Address(RVA = "0x91C6C0", Offset = "0x91AEC0", Length = "0x124")]
	public T GetMessageBox<T>(string key) where T : AbstractMessageBox
	{
		return null;
	}

	[Address(RVA = "0x5FF710", Offset = "0x5FDF10", Length = "0x7C")]
	[Token(Token = "0x6004DB6")]
	public void ReleaseMessageBox(AbstractMessageBox message)
	{
	}

	[Token(Token = "0x6004DB7")]
	[Address(RVA = "0x5FF700", Offset = "0x5FDF00", Length = "0xC")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6004DB8")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public PnlTipsManager()
	{
	}
}
