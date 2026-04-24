using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace RuntimeAudioClipLoader;

[Attribute(Name = "RequireComponent", RVA = "0x646D0", Offset = "0x63AD0")]
[Token(Token = "0x20001DF")]
public class DemoLoadAudioFromStreamingAssets : MonoBehaviour
{
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x18")]
	public bool loadInBackground;

	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000BCF")]
	public bool doStream;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BD0")]
	public string urlToLoad;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource audioSource;

	[Token(Token = "0x1700010F")]
	private string sourceFolder
	{
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x6200F0", Offset = "0x61E8F0", Length = "0x60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x620050", Offset = "0x61E850", Length = "0x47")]
	private void Start()
	{
	}

	[Address(RVA = "0x61F680", Offset = "0x61DE80", Length = "0x9CA")]
	[Token(Token = "0x6000DA9")]
	private void OnGUI()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x64AC0", Offset = "0x63EC0")]
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x61F5F0", Offset = "0x61DDF0", Length = "0x81")]
	private IEnumerator DownloadClipFromUrl(string url)
	{
		return null;
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x6200A0", Offset = "0x61E8A0", Length = "0x4A")]
	public DemoLoadAudioFromStreamingAssets()
	{
	}
}
