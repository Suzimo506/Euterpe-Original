using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Networking;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x20006A4")]
public static class WebUtils
{
	[Token(Token = "0x6003E8B")]
	[Address(RVA = "0x9399A0", Offset = "0x9381A0", Length = "0x89")]
	public static string ToUrl(this string url)
	{
		return null;
	}

	[Token(Token = "0x6003E8C")]
	[Address(RVA = "0x939360", Offset = "0x937B60", Length = "0x634")]
	public static UnityWebRequest SendToUrl(string url, string method = "GET", Dictionary<string, object> datas = null, Action<DownloadHandler> callback = null, Action<long, string> faillCallback = null, Dictionary<string, string> headers = null, int failTime = 0, bool autoSend = true)
	{
		return null;
	}
}
