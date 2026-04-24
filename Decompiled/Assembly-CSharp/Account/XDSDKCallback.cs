using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using xdsdk;

namespace Account;

[Token(Token = "0x2000563")]
public class XDSDKCallback : XDCallback
{
	[Token(Token = "0x4001FD2")]
	public static bool isInited;

	[Token(Token = "0x14000042")]
	public static event Action onInitSucceed
	{
		[Address(RVA = "0x780C80", Offset = "0x77F480", Length = "0xEB")]
		[Token(Token = "0x60037D4")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x781770", Offset = "0x77FF70", Length = "0xEB")]
		[Token(Token = "0x60037D5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000043")]
	public static event Action<string> onInitFailed
	{
		[CompilerGenerated]
		[Address(RVA = "0x780B80", Offset = "0x77F380", Length = "0xFE")]
		[Token(Token = "0x60037D6")]
		add
		{
		}
		[Address(RVA = "0x781670", Offset = "0x77FE70", Length = "0xFE")]
		[Token(Token = "0x60037D7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000044")]
	public static event Action<string> onLoginSucceed
	{
		[Address(RVA = "0x780F70", Offset = "0x77F770", Length = "0xFE")]
		[CompilerGenerated]
		[Token(Token = "0x60037D8")]
		add
		{
		}
		[Address(RVA = "0x781A60", Offset = "0x780260", Length = "0xFE")]
		[Token(Token = "0x60037D9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000045")]
	public static event Action<string> onLoginFailed
	{
		[Address(RVA = "0x780E70", Offset = "0x77F670", Length = "0xFE")]
		[Token(Token = "0x60037DA")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60037DB")]
		[CompilerGenerated]
		[Address(RVA = "0x781960", Offset = "0x780160", Length = "0xFE")]
		remove
		{
		}
	}

	[Token(Token = "0x14000046")]
	public static event Action onLogout
	{
		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x781070", Offset = "0x77F870", Length = "0xFE")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x781B60", Offset = "0x780360", Length = "0xFE")]
		remove
		{
		}
	}

	[Token(Token = "0x14000047")]
	public static event Action onLoginCancell
	{
		[CompilerGenerated]
		[Token(Token = "0x60037DE")]
		[Address(RVA = "0x780D70", Offset = "0x77F570", Length = "0xFE")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x781860", Offset = "0x780060", Length = "0xFE")]
		remove
		{
		}
	}

	[Token(Token = "0x14000048")]
	public static event Action onPayCompleted
	{
		[Token(Token = "0x60037E0")]
		[CompilerGenerated]
		[Address(RVA = "0x781270", Offset = "0x77FA70", Length = "0xFE")]
		add
		{
		}
		[Token(Token = "0x60037E1")]
		[CompilerGenerated]
		[Address(RVA = "0x781D60", Offset = "0x780560", Length = "0xFE")]
		remove
		{
		}
	}

	[Token(Token = "0x14000049")]
	public static event Action<string> onPayFailed
	{
		[Token(Token = "0x60037E2")]
		[Address(RVA = "0x781370", Offset = "0x77FB70", Length = "0xFE")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x781E60", Offset = "0x780660", Length = "0xFE")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400004A")]
	public static event Action onPayCanceled
	{
		[CompilerGenerated]
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x781170", Offset = "0x77F970", Length = "0xFE")]
		add
		{
		}
		[Address(RVA = "0x781C60", Offset = "0x780460", Length = "0xFE")]
		[CompilerGenerated]
		[Token(Token = "0x60037E5")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004B")]
	public static event Action onRealNameSucceed
	{
		[CompilerGenerated]
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x781570", Offset = "0x77FD70", Length = "0xFE")]
		add
		{
		}
		[Token(Token = "0x60037E7")]
		[CompilerGenerated]
		[Address(RVA = "0x782060", Offset = "0x780860", Length = "0xFE")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004C")]
	public static event Action onRealNameFailed
	{
		[CompilerGenerated]
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x781470", Offset = "0x77FC70", Length = "0xFE")]
		add
		{
		}
		[Token(Token = "0x60037E9")]
		[CompilerGenerated]
		[Address(RVA = "0x781F60", Offset = "0x780760", Length = "0xFE")]
		remove
		{
		}
	}

	[Address(RVA = "0x7802F0", Offset = "0x77EAF0", Length = "0x78")]
	[Token(Token = "0x60037EA")]
	public override void OnInitSucceed()
	{
	}

	[Token(Token = "0x60037EB")]
	[Address(RVA = "0x780270", Offset = "0x77EA70", Length = "0x75")]
	public override void OnInitFailed(string msg)
	{
	}

	[Address(RVA = "0x780460", Offset = "0x77EC60", Length = "0x75")]
	[Token(Token = "0x60037EC")]
	public override void OnLoginSucceed(string token)
	{
	}

	[Address(RVA = "0x7803E0", Offset = "0x77EBE0", Length = "0x75")]
	[Token(Token = "0x60037ED")]
	public override void OnLoginFailed(string msg)
	{
	}

	[Address(RVA = "0x780370", Offset = "0x77EB70", Length = "0x67")]
	[Token(Token = "0x60037EE")]
	public override void OnLoginCanceled()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60037EF")]
	public override void OnGuestBindSucceed(string token)
	{
	}

	[Address(RVA = "0x7804E0", Offset = "0x77ECE0", Length = "0x67")]
	[Token(Token = "0x60037F0")]
	public override void OnLogoutSucceed()
	{
	}

	[Address(RVA = "0x7805C0", Offset = "0x77EDC0", Length = "0x67")]
	[Token(Token = "0x60037F1")]
	public override void OnPayCompleted()
	{
	}

	[Address(RVA = "0x780630", Offset = "0x77EE30", Length = "0x75")]
	[Token(Token = "0x60037F2")]
	public override void OnPayFailed(string msg)
	{
	}

	[Token(Token = "0x60037F3")]
	[Address(RVA = "0x780550", Offset = "0x77ED50", Length = "0x67")]
	public override void OnPayCanceled()
	{
	}

	[Token(Token = "0x60037F4")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void RestoredPayment(List<Dictionary<string, string>> resultList)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60037F5")]
	public override void OnExitConfirm()
	{
	}

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void OnExitCancel()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60037F7")]
	public override void OnWXShareSucceed()
	{
	}

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0x780720", Offset = "0x77EF20", Length = "0x67")]
	public override void OnRealNameSucceed()
	{
	}

	[Address(RVA = "0x7806B0", Offset = "0x77EEB0", Length = "0x67")]
	[Token(Token = "0x60037F9")]
	public override void OnRealNameFailed(string msg)
	{
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public XDSDKCallback()
	{
	}
}
