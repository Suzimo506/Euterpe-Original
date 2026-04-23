using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using DG.Tweening;
using E7.Native;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x200063E")]
public class AudioManager : Singleton<AudioManager>, IPause
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002328")]
	private Tweener m_BGMTweener;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002329")]
	private Dictionary<string, AudioClip> m_SfxBuffer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400232A")]
	private Dictionary<string, NativeAudioPointer> m_AndroidSfxBuffer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400232B")]
	private AudioClip m_PreviousBgmCache;

	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0x48")]
	private Action m_OnCurLoopClipEnd;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400232D")]
	private Coroutine m_BgmChangeCorotine;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400232E")]
	private bool m_VoiceIsMute;

	[Token(Token = "0x17000596")]
	public FastPool pool
	{
		[Token(Token = "0x6003BFD")]
		[CompilerGenerated]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000597")]
	public AudioSource bgm
	{
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x6003BFE")]
		private set
		{
		}
	}

	[Token(Token = "0x17000598")]
	public GameObject gameObject
	{
		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003C00")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000599")]
	public float bgmVolume
	{
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x754E60", Offset = "0x753660", Length = "0x1D")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x754E80", Offset = "0x753680", Length = "0x1E")]
		[Token(Token = "0x6003C0F")]
		set
		{
		}
	}

	[Token(Token = "0x1700059A")]
	public bool IsGlobal
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x6003C1D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003C02")]
	[Address(RVA = "0x7527C0", Offset = "0x750FC0", Length = "0x401")]
	private void Init()
	{
	}

	[Token(Token = "0x6003C03")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OptimizeForVivo(ref int dspBuffer)
	{
	}

	[Token(Token = "0x6003C04")]
	[Address(RVA = "0x754190", Offset = "0x752990", Length = "0x107")]
	public bool Preload(string assetName, bool isAndroidPreload = false)
	{
		return default(bool);
	}

	[Address(RVA = "0x7544E0", Offset = "0x752CE0", Length = "0x10A")]
	[Token(Token = "0x6003C05")]
	public bool Preload(string assetName, string audioName, bool isAndroidPreload = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C06")]
	[Address(RVA = "0x7542A0", Offset = "0x752AA0", Length = "0x23C")]
	public void Preload(IList<string> preloadAudioNames, bool isAndroidPreload)
	{
	}

	[Token(Token = "0x6003C07")]
	[Address(RVA = "0x753F40", Offset = "0x752740", Length = "0x245")]
	public void PreloadBattleSfx(IList<string> preloadSfx, IList<string> normalSfx, bool isAndroidPreload)
	{
	}

	[Address(RVA = "0x753EB0", Offset = "0x7526B0", Length = "0x81")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x270D0", Offset = "0x264D0")]
	[Token(Token = "0x6003C08")]
	private IEnumerator PlayOverCallback(AudioSource audioSource, Action callback)
	{
		return null;
	}

	[Address(RVA = "0x752E60", Offset = "0x751660", Length = "0x156")]
	[Token(Token = "0x6003C09")]
	public void PauseSfx()
	{
	}

	[Token(Token = "0x6003C0A")]
	[Address(RVA = "0x754760", Offset = "0x752F60", Length = "0x156")]
	public void ResumeSfx()
	{
	}

	[Token(Token = "0x6003C0B")]
	[Address(RVA = "0x7549D0", Offset = "0x7531D0", Length = "0x1E")]
	public void SetBGMMute(bool mute)
	{
	}

	[Address(RVA = "0x754AD0", Offset = "0x7532D0", Length = "0x156")]
	[Token(Token = "0x6003C0C")]
	public void StopSound()
	{
	}

	[Address(RVA = "0x7549F0", Offset = "0x7531F0", Length = "0xD0")]
	[Token(Token = "0x6003C0D")]
	public void StopBGM()
	{
	}

	[Token(Token = "0x6003C10")]
	[Address(RVA = "0x7545F0", Offset = "0x752DF0", Length = "0x12A")]
	public void Release()
	{
	}

	[Address(RVA = "0x753940", Offset = "0x752140", Length = "0xD5")]
	[Token(Token = "0x6003C11")]
	public AudioSource PlayLoop(AudioClip clip, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6003C12")]
	[Address(RVA = "0x7537D0", Offset = "0x751FD0", Length = "0x16F")]
	public AudioSource PlayLoop(string name, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6003C13")]
	[Address(RVA = "0x753A20", Offset = "0x752220", Length = "0x18C")]
	public void PlayOneShot(AudioSource audioSource, string name, float volume = 1f)
	{
	}

	[Token(Token = "0x6003C14")]
	[Address(RVA = "0x753D20", Offset = "0x752520", Length = "0x8B")]
	public void PlayOneShot(AudioSource audioSource, AudioClip clip, float volume = 1f)
	{
	}

	[Address(RVA = "0x753BB0", Offset = "0x7523B0", Length = "0x16B")]
	[Token(Token = "0x6003C15")]
	public AudioSource PlayOneShot(AudioClip clip, float volume = 1f, Action callback = null)
	{
		return null;
	}

	[Address(RVA = "0x753DB0", Offset = "0x7525B0", Length = "0xF4")]
	[Token(Token = "0x6003C16")]
	public AudioSource PlayOneShot(string name, float volume = 1f, Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x6003C17")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public NativeSource PlayAndroidOneShot(string name, float volume = 1f, int index = -1, Action callback = null)
	{
		return default(NativeSource);
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x273A0", Offset = "0x267A0")]
	[Address(RVA = "0x752730", Offset = "0x750F30", Length = "0x81")]
	[Token(Token = "0x6003C18")]
	private IEnumerator DetectAudioFinished(AudioClip audioClip)
	{
		return null;
	}

	[Address(RVA = "0x7526C0", Offset = "0x750EC0", Length = "0x6E")]
	[Token(Token = "0x6003C19")]
	private void ClearBgmChangeCorotine()
	{
	}

	[Address(RVA = "0x753290", Offset = "0x751A90", Length = "0x39E")]
	[Token(Token = "0x6003C1A")]
	public void PlayBGM(string name, float fadeTime = 0f, float volumeFrom = 0f, Ease ease = Ease.Linear, bool forceReplay = false, bool mute = false, Action onCurLoopClipEnd = null)
	{
	}

	[Address(RVA = "0x752BD0", Offset = "0x7513D0", Length = "0x280")]
	[Token(Token = "0x6003C1B")]
	public void LoadBgm(string name)
	{
	}

	[Token(Token = "0x6003C1C")]
	[Address(RVA = "0x753020", Offset = "0x751820", Length = "0x265")]
	public void PlayBGM(AudioClip clip, float fadeTime = 0f, float volumeFrom = 0f, Ease ease = Ease.Linear, bool forceReplay = false)
	{
	}

	[Address(RVA = "0x752FC0", Offset = "0x7517C0", Length = "0x52")]
	[Token(Token = "0x6003C1E")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x754720", Offset = "0x752F20", Length = "0x36")]
	[Token(Token = "0x6003C1F")]
	public void ResumeBgm()
	{
	}

	[Address(RVA = "0x7548C0", Offset = "0x7530C0", Length = "0x20")]
	[Token(Token = "0x6003C20")]
	public void Resume()
	{
	}

	[Address(RVA = "0x7548F0", Offset = "0x7530F0", Length = "0xD6")]
	[Token(Token = "0x6003C21")]
	public void Resume(bool isExit, bool includeSfx, Action bgmResumeCallback)
	{
	}

	[Token(Token = "0x6003C22")]
	[Address(RVA = "0x753630", Offset = "0x751E30", Length = "0x17C")]
	public void PlayButtonClickedSfx(ClickSfxType sfxType)
	{
	}

	[Address(RVA = "0x754DF0", Offset = "0x7535F0", Length = "0x6E")]
	[Token(Token = "0x6003C23")]
	public AudioManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
