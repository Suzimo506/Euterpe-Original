using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000439")]
public class LobbyManager
{
	[Token(Token = "0x2000AEE")]
	internal struct FFIEvents
	{
		[Token(Token = "0x2000E50")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

		[Token(Token = "0x2000E51")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E52")]
		internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E53")]
		internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E54")]
		internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E55")]
		internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

		[Token(Token = "0x2000E56")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E57")]
		internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038F5")]
		internal LobbyUpdateHandler OnLobbyUpdate;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038F6")]
		internal LobbyDeleteHandler OnLobbyDelete;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038F7")]
		internal MemberConnectHandler OnMemberConnect;

		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x18")]
		internal MemberUpdateHandler OnMemberUpdate;

		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x20")]
		internal MemberDisconnectHandler OnMemberDisconnect;

		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x28")]
		internal LobbyMessageHandler OnLobbyMessage;

		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x30")]
		internal SpeakingHandler OnSpeaking;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40038FC")]
		internal NetworkMessageHandler OnNetworkMessage;
	}

	[Token(Token = "0x2000AEF")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E58")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetLobbyCreateTransactionMethod(IntPtr methodsPtr, ref IntPtr transaction);

		[Token(Token = "0x2000E59")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetLobbyUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E5A")]
		internal delegate Result GetMemberUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction);

		[Token(Token = "0x2000E5B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CreateLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

		[Token(Token = "0x2000E5C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CreateLobbyMethod(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, CreateLobbyCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E5D")]
		internal delegate void UpdateLobbyCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E5E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void UpdateLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, UpdateLobbyCallback callback);

		[Token(Token = "0x2000E5F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void DeleteLobbyCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E60")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void DeleteLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DeleteLobbyCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E61")]
		internal delegate void ConnectLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E62")]
		internal delegate void ConnectLobbyMethod(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, ConnectLobbyCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E63")]
		internal delegate void ConnectLobbyWithActivitySecretCallback(IntPtr ptr, Result result, ref Lobby lobby);

		[Token(Token = "0x2000E64")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ConnectLobbyWithActivitySecretMethod(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, ConnectLobbyWithActivitySecretCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E65")]
		internal delegate void DisconnectLobbyCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E66")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void DisconnectLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectLobbyCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E67")]
		internal delegate Result GetLobbyMethod(IntPtr methodsPtr, long lobbyId, ref Lobby lobby);

		[Token(Token = "0x2000E68")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetLobbyActivitySecretMethod(IntPtr methodsPtr, long lobbyId, StringBuilder secret);

		[Token(Token = "0x2000E69")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetLobbyMetadataValueMethod(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E6A")]
		internal delegate Result GetLobbyMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E6B")]
		internal delegate Result LobbyMetadataCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E6C")]
		internal delegate Result MemberCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

		[Token(Token = "0x2000E6D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetMemberUserIdMethod(IntPtr methodsPtr, long lobbyId, int index, ref long userId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E6E")]
		internal delegate Result GetMemberUserMethod(IntPtr methodsPtr, long lobbyId, long userId, ref User user);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E6F")]
		internal delegate Result GetMemberMetadataValueMethod(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E70")]
		internal delegate Result GetMemberMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E71")]
		internal delegate Result MemberMetadataCountMethod(IntPtr methodsPtr, long lobbyId, long userId, ref int count);

		[Token(Token = "0x2000E72")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void UpdateMemberCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E73")]
		internal delegate void UpdateMemberMethod(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, UpdateMemberCallback callback);

		[Token(Token = "0x2000E74")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SendLobbyMessageCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E75")]
		internal delegate void SendLobbyMessageMethod(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, SendLobbyMessageCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E76")]
		internal delegate Result GetSearchQueryMethod(IntPtr methodsPtr, ref IntPtr query);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E77")]
		internal delegate void SearchCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E78")]
		internal delegate void SearchMethod(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, SearchCallback callback);

		[Token(Token = "0x2000E79")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void LobbyCountMethod(IntPtr methodsPtr, ref int count);

		[Token(Token = "0x2000E7A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetLobbyIdMethod(IntPtr methodsPtr, int index, ref long lobbyId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E7B")]
		internal delegate void ConnectVoiceCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E7C")]
		internal delegate void ConnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, ConnectVoiceCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E7D")]
		internal delegate void DisconnectVoiceCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E7E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void DisconnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectVoiceCallback callback);

		[Token(Token = "0x2000E7F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result ConnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E80")]
		internal delegate Result DisconnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E81")]
		internal delegate Result FlushNetworkMethod(IntPtr methodsPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E82")]
		internal delegate Result OpenNetworkChannelMethod(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E83")]
		internal delegate Result SendNetworkMessageMethod(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen);

		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0x0")]
		internal GetLobbyCreateTransactionMethod GetLobbyCreateTransaction;

		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0x8")]
		internal GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038FF")]
		internal GetMemberUpdateTransactionMethod GetMemberUpdateTransaction;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003900")]
		internal CreateLobbyMethod CreateLobby;

		[Token(Token = "0x4003901")]
		[FieldOffset(Offset = "0x20")]
		internal UpdateLobbyMethod UpdateLobby;

		[Token(Token = "0x4003902")]
		[FieldOffset(Offset = "0x28")]
		internal DeleteLobbyMethod DeleteLobby;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003903")]
		internal ConnectLobbyMethod ConnectLobby;

		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x38")]
		internal ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret;

		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x40")]
		internal DisconnectLobbyMethod DisconnectLobby;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003906")]
		internal GetLobbyMethod GetLobby;

		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x50")]
		internal GetLobbyActivitySecretMethod GetLobbyActivitySecret;

		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003908")]
		internal GetLobbyMetadataValueMethod GetLobbyMetadataValue;

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003909")]
		internal GetLobbyMetadataKeyMethod GetLobbyMetadataKey;

		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400390A")]
		internal LobbyMetadataCountMethod LobbyMetadataCount;

		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x70")]
		internal MemberCountMethod MemberCount;

		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x78")]
		internal GetMemberUserIdMethod GetMemberUserId;

		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x80")]
		internal GetMemberUserMethod GetMemberUser;

		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x88")]
		internal GetMemberMetadataValueMethod GetMemberMetadataValue;

		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x90")]
		internal GetMemberMetadataKeyMethod GetMemberMetadataKey;

		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x98")]
		internal MemberMetadataCountMethod MemberMetadataCount;

		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0xA0")]
		internal UpdateMemberMethod UpdateMember;

		[Token(Token = "0x4003912")]
		[FieldOffset(Offset = "0xA8")]
		internal SendLobbyMessageMethod SendLobbyMessage;

		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003913")]
		internal GetSearchQueryMethod GetSearchQuery;

		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4003914")]
		internal SearchMethod Search;

		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4003915")]
		internal LobbyCountMethod LobbyCount;

		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4003916")]
		internal GetLobbyIdMethod GetLobbyId;

		[Token(Token = "0x4003917")]
		[FieldOffset(Offset = "0xD0")]
		internal ConnectVoiceMethod ConnectVoice;

		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0xD8")]
		internal DisconnectVoiceMethod DisconnectVoice;

		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4003919")]
		internal ConnectNetworkMethod ConnectNetwork;

		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x400391A")]
		internal DisconnectNetworkMethod DisconnectNetwork;

		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x400391B")]
		internal FlushNetworkMethod FlushNetwork;

		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400391C")]
		internal OpenNetworkChannelMethod OpenNetworkChannel;

		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x100")]
		internal SendNetworkMessageMethod SendNetworkMessage;
	}

	[Token(Token = "0x2000AF0")]
	public delegate void CreateLobbyHandler(Result result, ref Lobby lobby);

	[Token(Token = "0x2000AF1")]
	public delegate void UpdateLobbyHandler(Result result);

	[Token(Token = "0x2000AF2")]
	public delegate void DeleteLobbyHandler(Result result);

	[Token(Token = "0x2000AF3")]
	public delegate void ConnectLobbyHandler(Result result, ref Lobby lobby);

	[Token(Token = "0x2000AF4")]
	public delegate void ConnectLobbyWithActivitySecretHandler(Result result, ref Lobby lobby);

	[Token(Token = "0x2000AF5")]
	public delegate void DisconnectLobbyHandler(Result result);

	[Token(Token = "0x2000AF6")]
	public delegate void UpdateMemberHandler(Result result);

	[Token(Token = "0x2000AF7")]
	public delegate void SendLobbyMessageHandler(Result result);

	[Token(Token = "0x2000AF8")]
	public delegate void SearchHandler(Result result);

	[Token(Token = "0x2000AF9")]
	public delegate void ConnectVoiceHandler(Result result);

	[Token(Token = "0x2000AFA")]
	public delegate void DisconnectVoiceHandler(Result result);

	[Token(Token = "0x2000AFB")]
	public delegate void LobbyUpdateHandler(long lobbyId);

	[Token(Token = "0x2000AFC")]
	public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

	[Token(Token = "0x2000AFD")]
	public delegate void MemberConnectHandler(long lobbyId, long userId);

	[Token(Token = "0x2000AFE")]
	public delegate void MemberUpdateHandler(long lobbyId, long userId);

	[Token(Token = "0x2000AFF")]
	public delegate void MemberDisconnectHandler(long lobbyId, long userId);

	[Token(Token = "0x2000B00")]
	public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

	[Token(Token = "0x2000B01")]
	public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

	[Token(Token = "0x2000B02")]
	public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001783")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x17000478")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x214CF50", Offset = "0x214B750", Length = "0x160")]
		[Token(Token = "0x600319C")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x14000032")]
	public event LobbyUpdateHandler OnLobbyUpdate
	{
		[CompilerGenerated]
		[Address(RVA = "0x214CB90", Offset = "0x214B390", Length = "0x9E")]
		[Token(Token = "0x600319D")]
		add
		{
		}
		[Address(RVA = "0x214D200", Offset = "0x214BA00", Length = "0x9E")]
		[Token(Token = "0x600319E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000033")]
	public event LobbyDeleteHandler OnLobbyDelete
	{
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x214CA50", Offset = "0x214B250", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60031A0")]
		[Address(RVA = "0x214D0C0", Offset = "0x214B8C0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000034")]
	public event MemberConnectHandler OnMemberConnect
	{
		[CompilerGenerated]
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0x214CC30", Offset = "0x214B430", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x214D2A0", Offset = "0x214BAA0", Length = "0x9E")]
		[Token(Token = "0x60031A2")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000035")]
	public event MemberUpdateHandler OnMemberUpdate
	{
		[CompilerGenerated]
		[Address(RVA = "0x214CD70", Offset = "0x214B570", Length = "0x9E")]
		[Token(Token = "0x60031A3")]
		add
		{
		}
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0x214D3E0", Offset = "0x214BBE0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000036")]
	public event MemberDisconnectHandler OnMemberDisconnect
	{
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x214CCD0", Offset = "0x214B4D0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x214D340", Offset = "0x214BB40", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000037")]
	public event LobbyMessageHandler OnLobbyMessage
	{
		[Token(Token = "0x60031A7")]
		[CompilerGenerated]
		[Address(RVA = "0x214CAF0", Offset = "0x214B2F0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x214D160", Offset = "0x214B960", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000038")]
	public event SpeakingHandler OnSpeaking
	{
		[CompilerGenerated]
		[Token(Token = "0x60031A9")]
		[Address(RVA = "0x214CEB0", Offset = "0x214B6B0", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x214D520", Offset = "0x214BD20", Length = "0x9E")]
		[Token(Token = "0x60031AA")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000039")]
	public event NetworkMessageHandler OnNetworkMessage
	{
		[Token(Token = "0x60031AB")]
		[CompilerGenerated]
		[Address(RVA = "0x214CE10", Offset = "0x214B610", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x214D480", Offset = "0x214BC80", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x214C960", Offset = "0x214B160", Length = "0xEC")]
	internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031AE")]
	[Address(RVA = "0x214ADA0", Offset = "0x21495A0", Length = "0x2C7")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x21499F0", Offset = "0x21481F0", Length = "0x10E")]
	public LobbyTransaction GetLobbyCreateTransaction()
	{
		return default(LobbyTransaction);
	}

	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x2149F10", Offset = "0x2148710", Length = "0x126")]
	public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
	{
		return default(LobbyTransaction);
	}

	[Token(Token = "0x60031B1")]
	[Address(RVA = "0x214A480", Offset = "0x2148C80", Length = "0x130")]
	public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
	{
		return default(LobbyMemberTransaction);
	}

	[Address(RVA = "0x2148E90", Offset = "0x2147690", Length = "0xA0")]
	[MonoPInvokeCallback]
	[Token(Token = "0x60031B2")]
	private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
	{
	}

	[Address(RVA = "0x2148F40", Offset = "0x2147740", Length = "0x14F")]
	[Token(Token = "0x60031B3")]
	public void CreateLobby(LobbyTransaction transaction, CreateLobbyHandler callback)
	{
	}

	[Address(RVA = "0x214C550", Offset = "0x214AD50", Length = "0x90")]
	[Token(Token = "0x60031B4")]
	[MonoPInvokeCallback]
	private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x214C5F0", Offset = "0x214ADF0", Length = "0x158")]
	public void UpdateLobby(long lobbyId, LobbyTransaction transaction, UpdateLobbyHandler callback)
	{
	}

	[Address(RVA = "0x2149090", Offset = "0x2147890", Length = "0x90")]
	[Token(Token = "0x60031B6")]
	[MonoPInvokeCallback]
	private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x2149130", Offset = "0x2147930", Length = "0x14E")]
	public void DeleteLobby(long lobbyId, DeleteLobbyHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x2148770", Offset = "0x2146F70", Length = "0xA0")]
	[Token(Token = "0x60031B8")]
	private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
	{
	}

	[Address(RVA = "0x2148A20", Offset = "0x2147220", Length = "0x158")]
	[Token(Token = "0x60031B9")]
	public void ConnectLobby(long lobbyId, string secret, ConnectLobbyHandler callback)
	{
	}

	[Address(RVA = "0x2148820", Offset = "0x2147020", Length = "0xA0")]
	[Token(Token = "0x60031BA")]
	[MonoPInvokeCallback]
	private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
	{
	}

	[Address(RVA = "0x21488D0", Offset = "0x21470D0", Length = "0x14E")]
	[Token(Token = "0x60031BB")]
	public void ConnectLobbyWithActivitySecret(string activitySecret, ConnectLobbyWithActivitySecretHandler callback)
	{
	}

	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x2149280", Offset = "0x2147A80", Length = "0x90")]
	[MonoPInvokeCallback]
	private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x2149320", Offset = "0x2147B20", Length = "0x14E")]
	public void DisconnectLobby(long lobbyId, DisconnectLobbyHandler callback)
	{
	}

	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x214A040", Offset = "0x2148840", Length = "0x136")]
	public Lobby GetLobby(long lobbyId)
	{
		return default(Lobby);
	}

	[Address(RVA = "0x21498A0", Offset = "0x21480A0", Length = "0x14E")]
	[Token(Token = "0x60031BF")]
	public string GetLobbyActivitySecret(long lobbyId)
	{
		return null;
	}

	[Address(RVA = "0x2149DA0", Offset = "0x21485A0", Length = "0x167")]
	[Token(Token = "0x60031C0")]
	public string GetLobbyMetadataValue(long lobbyId, string key)
	{
		return null;
	}

	[Address(RVA = "0x2149C30", Offset = "0x2148430", Length = "0x167")]
	[Token(Token = "0x60031C1")]
	public string GetLobbyMetadataKey(long lobbyId, int index)
	{
		return null;
	}

	[Address(RVA = "0x214B140", Offset = "0x2149940", Length = "0x12E")]
	[Token(Token = "0x60031C2")]
	public int LobbyMetadataCount(long lobbyId)
	{
		return default(int);
	}

	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x214B270", Offset = "0x2149A70", Length = "0x12E")]
	public int MemberCount(long lobbyId)
	{
		return default(int);
	}

	[Address(RVA = "0x214A5C0", Offset = "0x2148DC0", Length = "0x13B")]
	[Token(Token = "0x60031C4")]
	public long GetMemberUserId(long lobbyId, int index)
	{
		return default(long);
	}

	[Address(RVA = "0x214A700", Offset = "0x2148F00", Length = "0x142")]
	[Token(Token = "0x60031C5")]
	public User GetMemberUser(long lobbyId, long userId)
	{
		return default(User);
	}

	[Token(Token = "0x60031C6")]
	[Address(RVA = "0x214A300", Offset = "0x2148B00", Length = "0x171")]
	public string GetMemberMetadataValue(long lobbyId, long userId, string key)
	{
		return null;
	}

	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x214A180", Offset = "0x2148980", Length = "0x170")]
	public string GetMemberMetadataKey(long lobbyId, long userId, int index)
	{
		return null;
	}

	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x214B3A0", Offset = "0x2149BA0", Length = "0x13A")]
	public int MemberMetadataCount(long lobbyId, long userId)
	{
		return default(int);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x214C750", Offset = "0x214AF50", Length = "0x90")]
	private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x214C7F0", Offset = "0x214AFF0", Length = "0x162")]
	public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, UpdateMemberHandler callback)
	{
	}

	[Address(RVA = "0x214C030", Offset = "0x214A830", Length = "0x90")]
	[Token(Token = "0x60031CB")]
	[MonoPInvokeCallback]
	private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x214C270", Offset = "0x214AA70", Length = "0x177")]
	[Token(Token = "0x60031CC")]
	public void SendLobbyMessage(long lobbyId, byte[] data, SendLobbyMessageHandler callback)
	{
	}

	[Address(RVA = "0x214AC80", Offset = "0x2149480", Length = "0x111")]
	[Token(Token = "0x60031CD")]
	public LobbySearchQuery GetSearchQuery()
	{
		return default(LobbySearchQuery);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x214BE30", Offset = "0x214A630", Length = "0x90")]
	private static void SearchCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x214BED0", Offset = "0x214A6D0", Length = "0x152")]
	public void Search(LobbySearchQuery query, SearchHandler callback)
	{
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x214B070", Offset = "0x2149870", Length = "0xCF")]
	public int LobbyCount()
	{
		return default(int);
	}

	[Address(RVA = "0x2149B00", Offset = "0x2148300", Length = "0x12F")]
	[Token(Token = "0x60031D1")]
	public long GetLobbyId(int index)
	{
		return default(long);
	}

	[Address(RVA = "0x2148C90", Offset = "0x2147490", Length = "0x90")]
	[Token(Token = "0x60031D2")]
	[MonoPInvokeCallback]
	private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x2148D30", Offset = "0x2147530", Length = "0x151")]
	public void ConnectVoice(long lobbyId, ConnectVoiceHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x2149580", Offset = "0x2147D80", Length = "0x90")]
	private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x2149620", Offset = "0x2147E20", Length = "0x151")]
	public void DisconnectVoice(long lobbyId, DisconnectVoiceHandler callback)
	{
	}

	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x2148B80", Offset = "0x2147380", Length = "0x10D")]
	public void ConnectNetwork(long lobbyId)
	{
	}

	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x2149470", Offset = "0x2147C70", Length = "0x10D")]
	public void DisconnectNetwork(long lobbyId)
	{
	}

	[Address(RVA = "0x2149780", Offset = "0x2147F80", Length = "0x112")]
	[Token(Token = "0x60031D8")]
	public void FlushNetwork()
	{
	}

	[Address(RVA = "0x214BCF0", Offset = "0x214A4F0", Length = "0x130")]
	[Token(Token = "0x60031D9")]
	public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
	{
	}

	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x214C3F0", Offset = "0x214ABF0", Length = "0x150")]
	public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
	{
	}

	[Token(Token = "0x60031DB")]
	[Address(RVA = "0x214B720", Offset = "0x2149F20", Length = "0xC5")]
	[MonoPInvokeCallback]
	private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
	{
	}

	[Address(RVA = "0x214B4E0", Offset = "0x2149CE0", Length = "0xD5")]
	[MonoPInvokeCallback]
	[Token(Token = "0x60031DC")]
	private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031DD")]
	[Address(RVA = "0x214B7F0", Offset = "0x2149FF0", Length = "0xD5")]
	private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031DE")]
	[Address(RVA = "0x214B9B0", Offset = "0x214A1B0", Length = "0xD5")]
	private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
	{
	}

	[Address(RVA = "0x214B8D0", Offset = "0x214A0D0", Length = "0xD5")]
	[MonoPInvokeCallback]
	[Token(Token = "0x60031DF")]
	private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x214B5C0", Offset = "0x2149DC0", Length = "0x159")]
	[Token(Token = "0x60031E0")]
	private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
	{
	}

	[Token(Token = "0x60031E1")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x214BC00", Offset = "0x214A400", Length = "0xED")]
	private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031E2")]
	[Address(RVA = "0x214BA90", Offset = "0x214A290", Length = "0x166")]
	private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
	{
	}

	[Token(Token = "0x60031E3")]
	[Address(RVA = "0x214A850", Offset = "0x2149050", Length = "0x421")]
	public IEnumerable<User> GetMemberUsers(long lobbyID)
	{
		return null;
	}

	[Token(Token = "0x60031E4")]
	[Address(RVA = "0x214C0D0", Offset = "0x214A8D0", Length = "0x19B")]
	public void SendLobbyMessage(long lobbyID, string data, SendLobbyMessageHandler handler)
	{
	}
}
