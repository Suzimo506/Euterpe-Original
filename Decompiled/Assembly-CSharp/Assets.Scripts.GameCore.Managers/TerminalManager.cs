using System;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.Structs;
using Assets.Scripts.Structs.Network;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000755")]
public class TerminalManager : Singleton<TerminalManager>
{
	[Token(Token = "0x2000CF1")]
	private delegate TResult HandlerCallback<T, out TResult>(ref T args);

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40026C5")]
	private Action m_Callback;

	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x18")]
	private Action m_FailCallback;

	[Token(Token = "0x17000679")]
	private string uid
	{
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x7DB290", Offset = "0x7D9A90", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60044F4")]
	[Address(RVA = "0x7D9E00", Offset = "0x7D8600", Length = "0x10B")]
	public void Exchange(string code, Action callback, Action failCallback)
	{
	}

	[Token(Token = "0x60044F5")]
	[Address(RVA = "0x7DA3D0", Offset = "0x7D8BD0", Length = "0x9D")]
	public void InitAfterInstancing()
	{
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0x7DA7E0", Offset = "0x7D8FE0", Length = "0x7")]
	private void RestoreTerminalItemsAfterLogin()
	{
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0x7D9A70", Offset = "0x7D8270", Length = "0x381")]
	public void ExchangeClear()
	{
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0x7D9F10", Offset = "0x7D8710", Length = "0x22B")]
	private void Exchange(string code, string userId)
	{
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0x7DA390", Offset = "0x7D8B90", Length = "0x3C")]
	private string GetThirdPlatformID()
	{
		return null;
	}

	[Token(Token = "0x60044FA")]
	[Address(RVA = "0x7D9150", Offset = "0x7D7950", Length = "0x3A0")]
	private void Callback(JObject jObj)
	{
	}

	[Token(Token = "0x60044FB")]
	[Address(RVA = "0x7D9680", Offset = "0x7D7E80", Length = "0x26A")]
	private void CompleteExchange(ExchangeItem[] args, bool showTip)
	{
	}

	[Token(Token = "0x60044FC")]
	[Address(RVA = "0x7DA7F0", Offset = "0x7D8FF0", Length = "0xBE")]
	private void ShowCompleteTip(ref ExchangeItem args)
	{
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0x7DA140", Offset = "0x7D8940", Length = "0xC4")]
	private void FailCallback(NetworkRequest request)
	{
	}

	[Token(Token = "0x60044FE")]
	[Address(RVA = "0x7DA470", Offset = "0x7D8C70", Length = "0x30")]
	private void InvokeFailCallback()
	{
	}

	[Token(Token = "0x60044FF")]
	[Address(RVA = "0x7DA8B0", Offset = "0x7D90B0", Length = "0x11C")]
	private void ShowError(int code, string errorMsg)
	{
	}

	[Token(Token = "0x6004500")]
	[Address(RVA = "0x7D8E60", Offset = "0x7D7660", Length = "0x16B")]
	private bool BackgroundHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004501")]
	[Address(RVA = "0x7DA4A0", Offset = "0x7D8CA0", Length = "0x132")]
	private bool LoadingHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004502")]
	[Address(RVA = "0x7DB0D0", Offset = "0x7D98D0", Length = "0x177")]
	private bool WelcomeHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Address(RVA = "0x7DA5E0", Offset = "0x7D8DE0", Length = "0xA8")]
	[Token(Token = "0x6004503")]
	private bool PackageHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0x7D9500", Offset = "0x7D7D00", Length = "0x177")]
	private bool CharacterHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0x7D98F0", Offset = "0x7D80F0", Length = "0x177")]
	private bool ElfinHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	private bool SongHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004507")]
	[Address(RVA = "0x7DA210", Offset = "0x7D8A10", Length = "0x172")]
	private bool FeverHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Address(RVA = "0x7D8FD0", Offset = "0x7D77D0", Length = "0x172")]
	[Token(Token = "0x6004508")]
	private bool BattleSfxHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004509")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	private bool OtherHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x600450A")]
	[Address(RVA = "0x7D8DA0", Offset = "0x7D75A0", Length = "0xB1")]
	private bool AllHandler(ref ExchangeItem args)
	{
		return default(bool);
	}

	[Token(Token = "0x600450B")]
	[Address(RVA = "0x7DAD10", Offset = "0x7D9510", Length = "0x201")]
	public void TerminalRestore()
	{
	}

	[Token(Token = "0x600450C")]
	[Address(RVA = "0x7DA690", Offset = "0x7D8E90", Length = "0x14C")]
	private void Private_TerminalRestore(string userId)
	{
	}

	[Token(Token = "0x600450D")]
	[Address(RVA = "0x7DA9F0", Offset = "0x7D91F0", Length = "0x17D")]
	private void TerminalRestoreCallback(JObject jObj)
	{
	}

	[Token(Token = "0x600450E")]
	[Address(RVA = "0x7DAB70", Offset = "0x7D9370", Length = "0x19B")]
	private void TerminalRestoreFailCallback(NetworkRequest request)
	{
	}

	[Address(RVA = "0x7DB250", Offset = "0x7D9A50", Length = "0x38")]
	[Token(Token = "0x600450F")]
	public TerminalManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
