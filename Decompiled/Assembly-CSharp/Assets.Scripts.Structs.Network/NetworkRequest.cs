using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Structs.Network;

[Token(Token = "0x2000594")]
public abstract class NetworkRequest
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40020CA")]
	protected uint m_RetryCount;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40020CB")]
	protected uint m_MaxRetryCount;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40020CC")]
	protected uint m_RetryInterval;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40020CD")]
	protected Action<JObject> m_Callback;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40020CE")]
	protected Action<NetworkRequest> m_FailCallback;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40020CF")]
	protected List<KeyValuePair<long, string>> m_FailInfo;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40020D0")]
	protected string m_Url;

	[Token(Token = "0x40020D1")]
	[FieldOffset(Offset = "0x48")]
	protected string m_Method;

	[Token(Token = "0x40020D2")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<string, object> m_Datas;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40020D3")]
	protected Dictionary<string, string> m_Headers;

	[Token(Token = "0x17000529")]
	public ulong networkId
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60038A0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700052A")]
	public string url
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60038A1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052B")]
	public bool isAbortRequest
	{
		[CompilerGenerated]
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x5B5230", Offset = "0x5B3A30", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60038A3")]
		[CompilerGenerated]
		[Address(RVA = "0x5B52F0", Offset = "0x5B3AF0", Length = "0x4")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700052C")]
	public bool isRequesting
	{
		[CompilerGenerated]
		[Address(RVA = "0x6574C0", Offset = "0x655CC0", Length = "0x5")]
		[Token(Token = "0x60038A4")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x490700", Offset = "0x48EF00", Length = "0x4")]
		protected set
		{
		}
	}

	[Address(RVA = "0x6572B0", Offset = "0x655AB0", Length = "0x5D")]
	[Token(Token = "0x60038A6")]
	public void GetFailInfosNoAlloc(List<KeyValuePair<long, string>> buffer)
	{
	}

	[Address(RVA = "0x657310", Offset = "0x655B10", Length = "0x96")]
	[Token(Token = "0x60038A7")]
	public List<KeyValuePair<long, string>> GetFailInfos()
	{
		return null;
	}

	[Address(RVA = "0x6572A0", Offset = "0x655AA0", Length = "0x5")]
	[Token(Token = "0x60038A8")]
	public virtual void AbortRequest()
	{
	}

	[Address(RVA = "0x6573B0", Offset = "0x655BB0", Length = "0x104")]
	[Token(Token = "0x60038A9")]
	protected NetworkRequest(string url, ulong id, uint retryCount = 3u, uint interval = 0u, string method = "GET", Dictionary<string, object> datas = null, Dictionary<string, string> headers = null, Action<JObject> callback = null, Action<NetworkRequest> failCallback = null)
	{
	}

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void SendRequest();
}
