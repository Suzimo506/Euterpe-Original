using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace RuntimeAudioClipLoader;

[Token(Token = "0x20001E0")]
public class Manager : MonoBehaviour
{
	[Token(Token = "0x2000A6C")]
	private class AudioInstance
	{
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip audioClip;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003701")]
		public CustomAudioFileReader reader;

		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x20")]
		public float[] dataToSet;

		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x28")]
		public int samplesCount;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003704")]
		public Stream streamToDisposeOnceDone;

		[Token(Token = "0x17000989")]
		public int channels
		{
			[Address(RVA = "0x61ED00", Offset = "0x61D500", Length = "0x30")]
			[Token(Token = "0x60059C1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700098A")]
		public int sampleRate
		{
			[Address(RVA = "0x61ED40", Offset = "0x61D540", Length = "0x2F")]
			[Token(Token = "0x60059C2")]
			get
			{
				return default(int);
			}
		}

		[Address(RVA = "0x52B3F0", Offset = "0x529BF0", Length = "0x17")]
		[Token(Token = "0x60059C3")]
		public static implicit operator AudioClip(AudioInstance ai)
		{
			return null;
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60059C4")]
		public AudioInstance()
		{
		}
	}

	[Token(Token = "0x4000BD2")]
	private static readonly string[] supportedFormats;

	[Token(Token = "0x4000BD3")]
	private static Dictionary<string, AudioClip> cache;

	[Token(Token = "0x4000BD4")]
	private static Queue<AudioInstance> deferredLoadQueue;

	[Token(Token = "0x4000BD5")]
	private static Queue<AudioInstance> deferredSetDataQueue;

	[Token(Token = "0x4000BD6")]
	private static Queue<AudioInstance> deferredSetFail;

	[Token(Token = "0x4000BD7")]
	private static Thread deferredLoaderThread;

	[Token(Token = "0x4000BD8")]
	private static GameObject managerInstance;

	[Token(Token = "0x4000BD9")]
	private static Dictionary<AudioClip, AudioClipLoadType> audioClipLoadType;

	[Token(Token = "0x4000BDA")]
	private static Dictionary<AudioClip, AudioDataLoadState> audioLoadState;

	[Address(RVA = "0x622A80", Offset = "0x621280", Length = "0x1FB")]
	[Token(Token = "0x6000DAC")]
	static Manager()
	{
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x621610", Offset = "0x61FE10", Length = "0x344")]
	public static AudioClip Load(string filePath, bool doStream = false, bool loadInBackground = true, bool useCache = true)
	{
		return null;
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x621960", Offset = "0x620160", Length = "0xA97")]
	public static AudioClip Load(Stream dataStream, AudioFormat audioFormat, string unityAudioClipName, bool doStream = false, bool loadInBackground = true, bool diposeDataStreamIfNotNeeded = true)
	{
		return null;
	}

	[Address(RVA = "0x622400", Offset = "0x620C00", Length = "0x172")]
	[Token(Token = "0x6000DAF")]
	private static void RunDeferredLoaderThread()
	{
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x620B70", Offset = "0x61F370", Length = "0x592")]
	private static void DeferredLoaderMain()
	{
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x6226A0", Offset = "0x620EA0", Length = "0x3D9")]
	private void Update()
	{
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x621110", Offset = "0x61F910", Length = "0x139")]
	private static void EnsureInstanceExists()
	{
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x622580", Offset = "0x620D80", Length = "0x83")]
	public static void SetAudioClipLoadState(AudioClip audioClip, AudioDataLoadState newLoadState)
	{
	}

	[Address(RVA = "0x621250", Offset = "0x61FA50", Length = "0xC9")]
	[Token(Token = "0x6000DB4")]
	public static AudioDataLoadState GetAudioClipLoadState(AudioClip audioClip)
	{
		return default(AudioDataLoadState);
	}

	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x622610", Offset = "0x620E10", Length = "0x83")]
	public static void SetAudioClipLoadType(AudioClip audioClip, AudioClipLoadType newLoadType)
	{
	}

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x621320", Offset = "0x61FB20", Length = "0xC9")]
	public static AudioClipLoadType GetAudioClipLoadType(AudioClip audioClip)
	{
		return default(AudioClipLoadType);
	}

	[Address(RVA = "0x621510", Offset = "0x61FD10", Length = "0x79")]
	[Token(Token = "0x6000DB7")]
	private static string GetExtension(string filePath)
	{
		return null;
	}

	[Address(RVA = "0x621590", Offset = "0x61FD90", Length = "0x80")]
	[Token(Token = "0x6000DB8")]
	public static bool IsSupportedFormat(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x6213F0", Offset = "0x61FBF0", Length = "0x11C")]
	public static AudioFormat GetAudioFormat(string filePath)
	{
		return default(AudioFormat);
	}

	[Address(RVA = "0x620B00", Offset = "0x61F300", Length = "0x6C")]
	[Token(Token = "0x6000DBA")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Manager()
	{
	}
}
