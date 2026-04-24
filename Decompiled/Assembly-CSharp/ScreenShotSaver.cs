using Assets.Scripts.Common.ImageSaver;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000169")]
public class ScreenShotSaver : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008D9")]
	public RectTransform centerRoot;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x20")]
	private ImageSaver m_ImageSaver;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x28")]
	public Image targetImage;

	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x30")]
	public string fileName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008DD")]
	public int resolutionScale;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008DE")]
	public Camera camera;

	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 centerRootOriginPos;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008E0")]
	private Vector2 tranformOriginSize;

	[Address(RVA = "0x62C100", Offset = "0x62A900", Length = "0xCC")]
	[Token(Token = "0x6000A3B")]
	private void Start()
	{
	}

	[Address(RVA = "0x62BBB0", Offset = "0x62A3B0", Length = "0xB7")]
	[Token(Token = "0x6000A3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x62C0D0", Offset = "0x62A8D0", Length = "0x27")]
	private void SaveTexture2D(Texture2D texture)
	{
	}

	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x62BFE0", Offset = "0x62A7E0", Length = "0xED")]
	public void SaveScreenshot()
	{
	}

	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x62BCD0", Offset = "0x62A4D0", Length = "0x30C")]
	private void SaveScreenshotCoroutine()
	{
	}

	[Address(RVA = "0x62BC70", Offset = "0x62A470", Length = "0x5E")]
	[Token(Token = "0x6000A40")]
	public void RefreshScale()
	{
	}

	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x62C1D0", Offset = "0x62A9D0", Length = "0x4D")]
	public ScreenShotSaver()
	{
	}
}
