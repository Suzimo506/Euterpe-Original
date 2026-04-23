using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

[Token(Token = "0x20000BE")]
public class GlobalUI : SerializedMonoBehaviour
{
	[Token(Token = "0x40004F1")]
	private static GlobalUI s_Instance;

	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x58")]
	public IInitialization[] initObjs;

	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x60")]
	public List<Transform> otherObjs;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004F4")]
	private bool m_Invoke;

	[Token(Token = "0x17000080")]
	public static GlobalUI instance
	{
		[Address(RVA = "0x5C1C20", Offset = "0x5C0420", Length = "0x35")]
		[Token(Token = "0x6000593")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x5C17A0", Offset = "0x5BFFA0", Length = "0x215")]
	[Token(Token = "0x6000594")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x5C1AF0", Offset = "0x5C02F0", Length = "0x12B")]
	private void Start()
	{
	}

	[Address(RVA = "0x5C16F0", Offset = "0x5BFEF0", Length = "0xA3")]
	[Token(Token = "0x6000596")]
	public void AddGlobalItem(Transform targetTrans)
	{
	}

	[Address(RVA = "0x5C19C0", Offset = "0x5C01C0", Length = "0x12B")]
	[Token(Token = "0x6000597")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6000598")]
	public GlobalUI()
	{
	}
}
