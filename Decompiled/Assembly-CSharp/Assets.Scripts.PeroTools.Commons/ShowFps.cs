using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200068A")]
public class ShowFps : SingletonMonoBehaviour<ShowFps>
{
	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x18")]
	public float updateInterval;

	[Token(Token = "0x40023D4")]
	[FieldOffset(Offset = "0x20")]
	private double m_LastInterval;

	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x28")]
	private int m_Frames;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40023D6")]
	private float m_CurrFps;

	[Token(Token = "0x40023D7")]
	[FieldOffset(Offset = "0x30")]
	private GUIStyle m_Style;

	[Address(RVA = "0x932360", Offset = "0x930B60", Length = "0xCD")]
	[Token(Token = "0x6003DAA")]
	private void Start()
	{
	}

	[Address(RVA = "0x932430", Offset = "0x930C30", Length = "0x60")]
	[Token(Token = "0x6003DAB")]
	private void Update()
	{
	}

	[Token(Token = "0x6003DAC")]
	[Address(RVA = "0x9321F0", Offset = "0x9309F0", Length = "0x163")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6003DAD")]
	[Address(RVA = "0x932490", Offset = "0x930C90", Length = "0x3F")]
	public ShowFps()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
