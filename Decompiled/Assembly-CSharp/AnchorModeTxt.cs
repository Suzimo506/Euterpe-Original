using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000096")]
public class AnchorModeTxt : MonoBehaviour, IInitialization
{
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_Trans;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400043C")]
	private GameObject m_Child;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400043D")]
	private Dictionary<string, Vector2> m_AnchorTxtOffset;

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x595AD0", Offset = "0x5942D0", Length = "0x2D")]
	private void OnSceneChanged(Scene preScene, Scene curScene)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x595C40", Offset = "0x594440", Length = "0x134")]
	private void SetOffset(string offsetName)
	{
	}

	[Address(RVA = "0x595D80", Offset = "0x594580", Length = "0xF7")]
	[Token(Token = "0x60004BF")]
	private void SetScale(string scaleName)
	{
	}

	[Address(RVA = "0x595B00", Offset = "0x594300", Length = "0xDD")]
	[Token(Token = "0x60004C0")]
	public void OnSetPosition(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x595740", Offset = "0x593F40", Length = "0x7D")]
	[Token(Token = "0x60004C1")]
	public void OnAnchorModeChanged(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x5957C0", Offset = "0x593FC0", Length = "0x30D")]
	public void OnAwake()
	{
	}

	[Address(RVA = "0x595BE0", Offset = "0x5943E0", Length = "0x57")]
	[Token(Token = "0x60004C3")]
	public void OnStart()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x5955E0", Offset = "0x593DE0", Length = "0x153")]
	public void Destroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60004C5")]
	public AnchorModeTxt()
	{
	}
}
