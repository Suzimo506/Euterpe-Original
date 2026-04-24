using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Structs.Network;

[Token(Token = "0x2000595")]
internal class NintendoNetworkRequest : NetworkRequest
{
	[Token(Token = "0x40020D6")]
	public const string server_ip = "https://prpr-muse-dash.peropero.net/";

	[Token(Token = "0x40020D7")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine m_RetryCoroutine;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40020D8")]
	private UnityWebRequest m_WebRequest;

	[Token(Token = "0x60038AB")]
	[Address(RVA = "0x657850", Offset = "0x656050", Length = "0x161")]
	public NintendoNetworkRequest(string url, ulong id, uint retryCount = 3u, uint interval = 0u, string method = "GET", Dictionary<string, object> datas = null, Dictionary<string, string> headers = null, Action<JObject> callback = null, Action<NetworkRequest> failCallback = null)
		: base(null, default(ulong), default(uint), default(uint), null)
	{
	}

	[Address(RVA = "0x657830", Offset = "0x656030", Length = "0x18")]
	[Token(Token = "0x60038AC")]
	public override void SendRequest()
	{
	}

	[Address(RVA = "0x657740", Offset = "0x655F40", Length = "0xEB")]
	[Token(Token = "0x60038AD")]
	private void Private_SendRequest()
	{
	}

	[Token(Token = "0x60038AE")]
	[Address(RVA = "0x6575B0", Offset = "0x655DB0", Length = "0x185")]
	private void FailCallback(long errorId, string str)
	{
	}

	[Address(RVA = "0x6574D0", Offset = "0x655CD0", Length = "0xD5")]
	[Token(Token = "0x60038AF")]
	private void Callback(DownloadHandler result)
	{
	}
}
