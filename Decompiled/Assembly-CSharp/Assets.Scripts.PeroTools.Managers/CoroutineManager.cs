using System;
using System.Collections;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000642")]
public class CoroutineManager : SingletonMonoBehaviour<CoroutineManager>, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400233E")]
	private bool m_IsCoroutineActive;

	[Token(Token = "0x1700059D")]
	public bool IsGlobal
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x6003C5F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003C4F")]
	[Address(RVA = "0x758330", Offset = "0x756B30", Length = "0x35")]
	public void StopCoroutine(ref Coroutine cor)
	{
	}

	[Token(Token = "0x6003C50")]
	[Address(RVA = "0x757B70", Offset = "0x756370", Length = "0xE3")]
	public Coroutine Delay(Action callback, float seconds, bool ignoreActive = false)
	{
		return null;
	}

	[Address(RVA = "0x757C60", Offset = "0x756460", Length = "0x27D")]
	[Token(Token = "0x6003C51")]
	public Coroutine Delay(Action callback, decimal seconds)
	{
		return null;
	}

	[Address(RVA = "0x757A50", Offset = "0x756250", Length = "0x111")]
	[Token(Token = "0x6003C52")]
	public Coroutine Delay(Action callback, int frames, bool isFixed = false)
	{
		return null;
	}

	[Address(RVA = "0x757EE0", Offset = "0x7566E0", Length = "0xA3")]
	[Token(Token = "0x6003C53")]
	public Coroutine EndFrameAction(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6003C54")]
	[Address(RVA = "0x7580D0", Offset = "0x7568D0", Length = "0x25C")]
	public Coroutine StartCoroutine(Action callback, Func<bool> boolFunc, float failTime = -1f, Action failCallback = null)
	{
		return null;
	}

	[Token(Token = "0x6003C55")]
	[Address(RVA = "0x758020", Offset = "0x756820", Length = "0xA3")]
	public Coroutine StartCoroutine(Func<UnityEngine.Object> callback)
	{
		return null;
	}

	[Address(RVA = "0x7579B0", Offset = "0x7561B0", Length = "0x9D")]
	[Token(Token = "0x6003C56")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2B730", Offset = "0x2AB30")]
	private IEnumerator CoroutineUtilEnumerator(Action callback, Func<bool> boolFunc)
	{
		return null;
	}

	[Address(RVA = "0x7576A0", Offset = "0x755EA0", Length = "0x81")]
	[Token(Token = "0x6003C57")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2B920", Offset = "0x2AD20")]
	private IEnumerator CoroutineEndOfFrame(Action callback)
	{
		return null;
	}

	[Address(RVA = "0x7577D0", Offset = "0x755FD0", Length = "0x91")]
	[Token(Token = "0x6003C58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2BA20", Offset = "0x2AE20")]
	private IEnumerator CoroutineFramesEnumerator(Action callback, int frames)
	{
		return null;
	}

	[Address(RVA = "0x757730", Offset = "0x755F30", Length = "0x91")]
	[Token(Token = "0x6003C59")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2BB30", Offset = "0x2AF30")]
	private IEnumerator CoroutineFixedFramesEnumerator(Action callback, int frames)
	{
		return null;
	}

	[Token(Token = "0x6003C5A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2BC80", Offset = "0x2B080")]
	[Address(RVA = "0x757870", Offset = "0x756070", Length = "0x81")]
	private IEnumerator CoroutineObjectEnumerator(Func<UnityEngine.Object> callback)
	{
		return null;
	}

	[Address(RVA = "0x757900", Offset = "0x756100", Length = "0xA5")]
	[Token(Token = "0x6003C5B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2BEF0", Offset = "0x2B2F0")]
	private IEnumerator CoroutineSecondsEnumerator(Action callback, float seconds, bool ignoreActive)
	{
		return null;
	}

	[Address(RVA = "0x757F90", Offset = "0x756790", Length = "0x62")]
	[Token(Token = "0x6003C5C")]
	private void Init()
	{
	}

	[Address(RVA = "0x758000", Offset = "0x756800", Length = "0x9")]
	[Token(Token = "0x6003C5D")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6003C5E")]
	[Address(RVA = "0x758010", Offset = "0x756810", Length = "0x5")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003C60")]
	[Address(RVA = "0x758370", Offset = "0x756B70", Length = "0x3C")]
	public CoroutineManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
