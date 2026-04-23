using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroTools2.Commons;
using UnityEngine;

namespace Assets.Scripts.Structs.Network;

[Token(Token = "0x2000596")]
public class StandardNetworkRequest : NetworkRequest
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40020D9")]
	private WebUtils.PeroWebRequest m_PeroWebRequest;

	[Token(Token = "0x40020DA")]
	[FieldOffset(Offset = "0x70")]
	private Coroutine m_RetryCoroutine;

	[Address(RVA = "0x65E440", Offset = "0x65CC40", Length = "0xE")]
	[Token(Token = "0x60038B0")]
	public StandardNetworkRequest(string url, ulong id, uint retryCount = 3u, uint interval = 0u, string method = "GET", Dictionary<string, object> datas = null, Dictionary<string, string> headers = null, Action<JObject> callback = null, Action<NetworkRequest> failCallback = null)
		: base(null, default(ulong), default(uint), default(uint), null)
	{
	}

	[Address(RVA = "0x65E420", Offset = "0x65CC20", Length = "0x18")]
	[Token(Token = "0x60038B1")]
	public override void SendRequest()
	{
	}

	[Address(RVA = "0x65E2F0", Offset = "0x65CAF0", Length = "0x12C")]
	[Token(Token = "0x60038B2")]
	private void Private_SendRequest()
	{
	}

	[Address(RVA = "0x65E160", Offset = "0x65C960", Length = "0x185")]
	[Token(Token = "0x60038B3")]
	private void FailCallback(long errorId, string str)
	{
	}

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x65E0E0", Offset = "0x65C8E0", Length = "0x72")]
	private void Callback(JObject result)
	{
	}
}
