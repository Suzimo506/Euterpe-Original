using System;
using System.Collections;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.PeroTools.PreProcessSystem;

[Token(Token = "0x20005B9")]
public class PreWarmSystem : SerializedMonoBehaviour
{
	[Token(Token = "0x400216D")]
	public const int sliceCount = 3;

	[Token(Token = "0x400216E")]
	public static PreWarmSystem current;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400216F")]
	public IPreWarm[] iPreWarms;

	[NonSerialized]
	[HideInInspector]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002170")]
	public bool prewarmCompleted;

	[Address(RVA = "0x981A40", Offset = "0x980240", Length = "0x1E6")]
	[Token(Token = "0x600396E")]
	public void Awake()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95460", Offset = "0x94860")]
	[Token(Token = "0x600396F")]
	[Address(RVA = "0x981F40", Offset = "0x980740", Length = "0x65")]
	private IEnumerator Execute()
	{
		return null;
	}

	[Token(Token = "0x6003970")]
	[Address(RVA = "0x981CA0", Offset = "0x9804A0", Length = "0x12B")]
	public void DisableGameObjects()
	{
	}

	[Address(RVA = "0x981DD0", Offset = "0x9805D0", Length = "0x163")]
	[Token(Token = "0x6003971")]
	public void EnableAllDisabledGameObjects()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95620", Offset = "0x94A20")]
	[Token(Token = "0x6003972")]
	[Address(RVA = "0x981C30", Offset = "0x980430", Length = "0x65")]
	public IEnumerator CallPreWarms()
	{
		return null;
	}

	[Token(Token = "0x6003973")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public PreWarmSystem()
	{
	}
}
