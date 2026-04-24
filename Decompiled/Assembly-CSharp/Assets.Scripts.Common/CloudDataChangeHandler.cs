using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000979")]
public class CloudDataChangeHandler : MonoBehaviour
{
	[Space]
	[Token(Token = "0x40033DA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject txtLocal;

	[Token(Token = "0x40033DB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject txtCloud;

	[Space]
	[Token(Token = "0x40033DC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject highLevelCloudAsk;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40033DD")]
	public GameObject highLevelLocalAsk;

	[Space]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40033DE")]
	public GameObject highTips;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40033DF")]
	public GameObject lowTips;

	[FieldOffset(Offset = "0x48")]
	[Space]
	[Token(Token = "0x40033E0")]
	public GameObject highLevelCloud;

	[Token(Token = "0x40033E1")]
	[FieldOffset(Offset = "0x50")]
	public GameObject lowLevelCloud;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40033E2")]
	[Space]
	public GameObject highLevelLocal;

	[Token(Token = "0x40033E3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject lowLevelLocal;

	[Token(Token = "0x40033E4")]
	[FieldOffset(Offset = "0x68")]
	[Space]
	public GameObject highYes;

	[Token(Token = "0x40033E5")]
	[FieldOffset(Offset = "0x70")]
	public GameObject lowYes;

	[Space]
	[Token(Token = "0x40033E6")]
	[FieldOffset(Offset = "0x78")]
	public GameObject highNo;

	[Token(Token = "0x40033E7")]
	[FieldOffset(Offset = "0x80")]
	public GameObject lowNo;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40033E8")]
	[Space]
	public Button btnLocal;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40033E9")]
	public Button btnCloud;

	[Token(Token = "0x40033EA")]
	[Space]
	[FieldOffset(Offset = "0x98")]
	public Button btnYes;

	[Space]
	[Token(Token = "0x40033EB")]
	[FieldOffset(Offset = "0xA0")]
	public Text strLevelCloud;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40033EC")]
	public Text strExpCloud;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40033ED")]
	public Text strDateCloud;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40033EE")]
	[Space]
	public Text strLevelLocal;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40033EF")]
	public Text strExpLocal;

	[Space]
	[Token(Token = "0x40033F0")]
	[FieldOffset(Offset = "0xC8")]
	public Text confirmLevelCloud;

	[Token(Token = "0x40033F1")]
	[FieldOffset(Offset = "0xD0")]
	public Text confirmExpCloud;

	[Token(Token = "0x40033F2")]
	[FieldOffset(Offset = "0xD8")]
	public Text confirmDateCloud;

	[FieldOffset(Offset = "0xE0")]
	[Space]
	[Token(Token = "0x40033F3")]
	public Text confirmLevelLocal;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40033F4")]
	public Text confirmExpLocal;

	[Token(Token = "0x40033F5")]
	[FieldOffset(Offset = "0xF0")]
	private Action<bool> m_AndroidSyncCallback;

	[Token(Token = "0x40033F6")]
	[FieldOffset(Offset = "0xF8")]
	public bool isLocal;

	[FieldOffset(Offset = "0xF9")]
	[Token(Token = "0x40033F7")]
	private bool isRunOnce;

	[Token(Token = "0x40033F8")]
	[FieldOffset(Offset = "0xFC")]
	private int m_TotleKey;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40033F9")]
	private int m_DoneKey;

	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40033FA")]
	private bool m_IsHanding;

	[Token(Token = "0x17000905")]
	public static bool hasHandleCloudDataInit
	{
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x597710", Offset = "0x595F10", Length = "0x37")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x597750", Offset = "0x595F50", Length = "0x3A")]
		set
		{
		}
	}

	[Address(RVA = "0x597170", Offset = "0x595970", Length = "0x14")]
	[Token(Token = "0x600565C")]
	private int CacularLevel(int exp)
	{
		return default(int);
	}

	[Address(RVA = "0x597150", Offset = "0x595950", Length = "0x1E")]
	[Token(Token = "0x600565D")]
	private int CacularCurExp(int exp)
	{
		return default(int);
	}

	[Address(RVA = "0x597190", Offset = "0x595990", Length = "0x393")]
	[Token(Token = "0x600565E")]
	public void Init(int cloudExp, string cloudSaveTime, int localExp, Action<bool> callback)
	{
	}

	[Address(RVA = "0x597530", Offset = "0x595D30", Length = "0xE4")]
	[Token(Token = "0x600565F")]
	private void OnApplicationFocus(bool isFocus)
	{
	}

	[Token(Token = "0x6005660")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CloudDataChangeHandler()
	{
	}
}
