using Cpp2ILInjected;
using PeroTools2.Commons;
using PeroTools2.Watermark;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.WaterMark;

[Token(Token = "0x200056A")]
public class WaterMarkTestManager : SingletonMonoBehaviour<WaterMarkTestManager>
{
	[SerializeField]
	[Token(Token = "0x4001FF4")]
	[FieldOffset(Offset = "0x58")]
	private OverlayWatermark m_Watermark;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4001FF5")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F2D0", Offset = "0x8E6D0")]
	private TMP_Text m_TextureWaterMarkInfo;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001FF6")]
	[SerializeField]
	private Material m_Material;

	[Token(Token = "0x1700051A")]
	public string testerID
	{
		[Address(RVA = "0x608F20", Offset = "0x607720", Length = "0x31")]
		[Token(Token = "0x6003829")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051B")]
	public string testerPWD
	{
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x608F60", Offset = "0x607760", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600382B")]
	[Address(RVA = "0x608960", Offset = "0x607160", Length = "0x5E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x608B80", Offset = "0x607380", Length = "0x2F")]
	[Token(Token = "0x600382C")]
	public void Init()
	{
	}

	[Address(RVA = "0x608E80", Offset = "0x607680", Length = "0x5E")]
	[Token(Token = "0x600382D")]
	private void Start()
	{
	}

	[Token(Token = "0x600382E")]
	[Address(RVA = "0x608A10", Offset = "0x607210", Length = "0x162")]
	public void FirstCheck()
	{
	}

	[Token(Token = "0x600382F")]
	[Address(RVA = "0x608DD0", Offset = "0x6075D0", Length = "0xAC")]
	public void SetInfo(string testerID, string contact_information)
	{
	}

	[Address(RVA = "0x608BB0", Offset = "0x6073B0", Length = "0x6A")]
	[Token(Token = "0x6003830")]
	public void ReflashInfo()
	{
	}

	[Token(Token = "0x6003831")]
	[Address(RVA = "0x608D70", Offset = "0x607570", Length = "0x60")]
	public void SaveWaterMarkInfo(string tester_id, string tester_pwd)
	{
	}

	[Token(Token = "0x6003832")]
	[Address(RVA = "0x608C20", Offset = "0x607420", Length = "0x14B")]
	public Texture2D SaveImageWithWaterMark(Texture2D origalTexture)
	{
		return null;
	}

	[Token(Token = "0x6003833")]
	[Address(RVA = "0x6089C0", Offset = "0x6071C0", Length = "0x46")]
	public void DeleteWaterMarkInfo()
	{
	}

	[Address(RVA = "0x608EE0", Offset = "0x6076E0", Length = "0x38")]
	[Token(Token = "0x6003834")]
	public WaterMarkTestManager()
	{
		((SingletonMonoBehaviour<T>)(object)this)._002Ector();
	}
}
