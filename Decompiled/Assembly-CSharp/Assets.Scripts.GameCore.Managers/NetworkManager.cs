using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.Structs.Network;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000747")]
public class NetworkManager : Singleton<NetworkManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002686")]
	private Dictionary<ulong, NetworkRequest> m_NetworkRequests;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002687")]
	private ulong m_CurIndex;

	[Token(Token = "0x17000668")]
	public bool hasNetwork
	{
		[Address(RVA = "0x43FC10", Offset = "0x43E410", Length = "0x15")]
		[Token(Token = "0x6004430")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004431")]
	[Address(RVA = "0x6DBEE0", Offset = "0x6DA6E0", Length = "0x127")]
	public void Request(string url, uint retryCount = 3u, uint interval = 0u, string method = "GET", Dictionary<string, object> datas = null, Dictionary<string, string> headers = null, Action<JObject> callback = null, Action<NetworkRequest> failCallback = null)
	{
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0x6DBDC0", Offset = "0x6DA5C0", Length = "0x11C")]
	public bool RemoveNetworkRequest(NetworkRequest request)
	{
		return default(bool);
	}

	[Token(Token = "0x6004433")]
	[Address(RVA = "0x6DBCE0", Offset = "0x6DA4E0", Length = "0xD9")]
	private NetworkRequest CreateNewRequest(string url, uint retryCount = 3u, uint interval = 0u, string method = "GET", Dictionary<string, object> datas = null, Dictionary<string, string> headers = null, Action<JObject> callback = null, Action<NetworkRequest> failCallback = null)
	{
		return null;
	}

	[Token(Token = "0x6004434")]
	[Address(RVA = "0x6DC010", Offset = "0x6DA810", Length = "0x6E")]
	public NetworkManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
