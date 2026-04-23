using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200008C")]
public abstract class UnitySerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x0")]
	private List<TKey> keyData;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000398")]
	[HideInInspector]
	[SerializeField]
	private List<TValue> valueData;

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1709260", Offset = "0x1707A60", Length = "0x132")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[Address(RVA = "0x1709970", Offset = "0x1708170", Length = "0x260")]
	[Token(Token = "0x6000407")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[Address(RVA = "0x170A0A0", Offset = "0x17088A0", Length = "0xF9")]
	[Token(Token = "0x6000408")]
	protected UnitySerializedDictionary()
	{
		((Dictionary<TKey, TValue>)(object)this)._002Ector();
	}
}
