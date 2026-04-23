using System;
using System.Text;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using Steamworks;
using UnityEngine;

[DisallowMultipleComponent]
[Token(Token = "0x200006D")]
public class SteamManager : SingletonMonoBehaviour<SteamManager>
{
	[Token(Token = "0x40002FB")]
	protected static bool s_EverInitialized;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x18")]
	protected bool m_bInitialized;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x19")]
	protected bool m_OpenSteamKeyBoard;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x20")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FF")]
	private Callback<FloatingGamepadTextInputDismissed_t> m_GamepadTextInputDismissed;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x30")]
	private bool m_DoSomething1;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x31")]
	private bool m_DoSomething3;

	[Token(Token = "0x17000055")]
	public static bool Initialized
	{
		[Address(RVA = "0x51B890", Offset = "0x51A090", Length = "0x3E")]
		[Token(Token = "0x600032B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000056")]
	public static bool OpenSteamKeyBoard
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x51B8D0", Offset = "0x51A0D0", Length = "0x3E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000057")]
	public bool dlcHasJustAsPlanVerify
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x51B910", Offset = "0x51A110", Length = "0xC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000058")]
	public bool dlcHasMusePlus
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x51B920", Offset = "0x51A120", Length = "0xC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000059")]
	public bool isHasDLC
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x51B930", Offset = "0x51A130", Length = "0x30")]
		get
		{
			return default(bool);
		}
	}

	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6F1E0", Offset = "0x6E5E0")]
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x51B7D0", Offset = "0x519FD0", Length = "0x51")]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[Address(RVA = "0x51B4D0", Offset = "0x519CD0", Length = "0x56")]
	[Token(Token = "0x600032E")]
	private static void InitOnPlayMode()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x51A880", Offset = "0x519080", Length = "0x23D")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x51B5C0", Offset = "0x519DC0", Length = "0x128")]
	protected virtual void OnEnable()
	{
	}

	[Address(RVA = "0x51B5B0", Offset = "0x519DB0", Length = "0xE")]
	[Token(Token = "0x6000331")]
	protected virtual void OnDestroy()
	{
	}

	[Address(RVA = "0x51B840", Offset = "0x51A040", Length = "0xE")]
	[Token(Token = "0x6000332")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x51B550", Offset = "0x519D50", Length = "0x60")]
	public void JumpToStore()
	{
	}

	[Address(RVA = "0x51B6F0", Offset = "0x519EF0", Length = "0x5")]
	[Token(Token = "0x6000334")]
	private void OnFloatingGamepadTextInputDismissed(FloatingGamepadTextInputDismissed_t pCallback)
	{
	}

	[Address(RVA = "0x51B700", Offset = "0x519F00", Length = "0xC1")]
	[Token(Token = "0x6000335")]
	public void OpenKeyBoard()
	{
	}

	[Address(RVA = "0x51AC40", Offset = "0x519440", Length = "0x7")]
	[Token(Token = "0x6000336")]
	public void CloseKeyboard()
	{
	}

	[Address(RVA = "0x51B530", Offset = "0x519D30", Length = "0x7")]
	[Token(Token = "0x6000337")]
	public static bool IsSteamDeck()
	{
		return default(bool);
	}

	[Address(RVA = "0x51B540", Offset = "0x519D40", Length = "0x7")]
	[Token(Token = "0x6000338")]
	public static bool IsSteamInBigPictureMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x51B830", Offset = "0x51A030", Length = "0x7")]
	private void SuffixInit()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x51AC50", Offset = "0x519450", Length = "0x2F7")]
	public void DLCVerify()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x51AAC0", Offset = "0x5192C0", Length = "0x175")]
	private void CheckMPVerify()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x51B2B0", Offset = "0x519AB0", Length = "0x1CB")]
	private DateTime GetDlcUnlockTime(AppId_t appID)
	{
		return default(DateTime);
	}

	[Address(RVA = "0x51AF50", Offset = "0x519750", Length = "0x35A")]
	[Token(Token = "0x6000340")]
	private bool DoSomething1()
	{
		return default(bool);
	}

	[Address(RVA = "0x51B490", Offset = "0x519C90", Length = "0x31")]
	[Token(Token = "0x6000341")]
	private bool HasCheckDLC()
	{
		return default(bool);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x51B480", Offset = "0x519C80", Length = "0x7")]
	public CSteamID GetUserId()
	{
		return default(CSteamID);
	}

	[Address(RVA = "0x51B850", Offset = "0x51A050", Length = "0x38")]
	[Token(Token = "0x6000343")]
	public SteamManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
