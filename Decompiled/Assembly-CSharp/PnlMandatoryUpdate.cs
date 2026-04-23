using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000128")]
public class PnlMandatoryUpdate : MonoBehaviour
{
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x18")]
	public Button btnOnMandatoryUpdate;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400074C")]
	private bool isAvailable;

	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400074D")]
	private bool isLatest;

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x7A7F70", Offset = "0x7A6770", Length = "0x6F")]
	public void OnActivate()
	{
	}

	[Address(RVA = "0x7A7FE0", Offset = "0x7A67E0", Length = "0x54")]
	[Token(Token = "0x6000862")]
	private void OnMandatoryUpdate()
	{
	}

	[Address(RVA = "0x7A8040", Offset = "0x7A6840", Length = "0x14F")]
	[Token(Token = "0x6000863")]
	private void SendToBackendUrl(string url, string method = "GET", Dictionary<string, object> datas = null, Action<JObject> succeedCallback = null)
	{
	}

	[Address(RVA = "0x7A8240", Offset = "0x7A6A40", Length = "0xD")]
	[Token(Token = "0x6000864")]
	public PnlMandatoryUpdate()
	{
	}
}
