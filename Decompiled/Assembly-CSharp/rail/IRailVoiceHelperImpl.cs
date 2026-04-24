using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025C")]
public class IRailVoiceHelperImpl : RailObject, IRailVoiceHelper
{
	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailVoiceHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailVoiceHelperImpl()
	{
	}

	[Address(RVA = "0x37B1C0", Offset = "0x3799C0", Length = "0x2B8")]
	[Token(Token = "0x60029BF")]
	public virtual IRailVoiceChannel AsyncCreateVoiceChannel(CreateVoiceChannelOption options, string channel_name, string user_data, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x37BC00", Offset = "0x37A400", Length = "0x2EC")]
	public virtual IRailVoiceChannel OpenVoiceChannel(RailVoiceChannelID voice_channel_id, string channel_name, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x37B830", Offset = "0x37A030", Length = "0xB5")]
	public virtual EnumRailVoiceChannelSpeakerState GetSpeakerState()
	{
		return default(EnumRailVoiceChannelSpeakerState);
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x37BB40", Offset = "0x37A340", Length = "0xB5")]
	public virtual RailResult MuteSpeaker()
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x37BEF0", Offset = "0x37A6F0", Length = "0xB5")]
	public virtual RailResult ResumeSpeaker()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37C300", Offset = "0x37AB00", Length = "0x195")]
	[Token(Token = "0x60029C4")]
	public virtual RailResult SetupVoiceCapture(RailVoiceCaptureOption options, RailCaptureVoiceCallback callback)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37C4A0", Offset = "0x37ACA0", Length = "0x17E")]
	[Token(Token = "0x60029C5")]
	public virtual RailResult SetupVoiceCapture(RailVoiceCaptureOption options)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x37C7C0", Offset = "0x37AFC0", Length = "0xD3")]
	public virtual RailResult StartVoiceCapturing(uint duration_milliseconds, bool repeat)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x37C6F0", Offset = "0x37AEF0", Length = "0xC2")]
	public virtual RailResult StartVoiceCapturing(uint duration_milliseconds)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x37C8A0", Offset = "0x37B0A0", Length = "0xB5")]
	public virtual RailResult StartVoiceCapturing()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37C960", Offset = "0x37B160", Length = "0xB5")]
	[Token(Token = "0x60029C9")]
	public virtual RailResult StopVoiceCapturing()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37B670", Offset = "0x379E70", Length = "0xF8")]
	[Token(Token = "0x60029CA")]
	public virtual RailResult GetCapturedVoiceData(byte[] buffer, uint buffer_length, out uint encoded_bytes_written)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref encoded_bytes_written) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x37B480", Offset = "0x379C80", Length = "0x11C")]
	[Token(Token = "0x60029CB")]
	public virtual RailResult DecodeVoice(byte[] encoded_buffer, uint encoded_length, byte[] pcm_buffer, uint pcm_buffer_length, out uint pcm_buffer_written)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref pcm_buffer_written) = null;
		return default(RailResult);
	}

	[Address(RVA = "0x37B8F0", Offset = "0x37A0F0", Length = "0x247")]
	[Token(Token = "0x60029CC")]
	public virtual RailResult GetVoiceCaptureSpecification(RailVoiceCaptureSpecification spec)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37B5A0", Offset = "0x379DA0", Length = "0xC3")]
	[Token(Token = "0x60029CD")]
	public virtual RailResult EnableInGameVoiceSpeaking(bool can_speaking)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x37C080", Offset = "0x37A880", Length = "0xDD")]
	public virtual RailResult SetPlayerNicknameInVoiceChannel(string nickname)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x37C160", Offset = "0x37A960", Length = "0xC2")]
	public virtual RailResult SetPushToTalkKeyInVoiceChannel(uint push_to_talk_hot_key)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37B770", Offset = "0x379F70", Length = "0xB5")]
	[Token(Token = "0x60029D0")]
	public virtual uint GetPushToTalkKeyInVoiceChannel()
	{
		return default(uint);
	}

	[Address(RVA = "0x37C620", Offset = "0x37AE20", Length = "0xC3")]
	[Token(Token = "0x60029D1")]
	public virtual RailResult ShowOverlayUI(bool show)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37BFB0", Offset = "0x37A7B0", Length = "0xC2")]
	[Token(Token = "0x60029D2")]
	public virtual RailResult SetMicroVolume(uint volume)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37C230", Offset = "0x37AA30", Length = "0xC2")]
	[Token(Token = "0x60029D3")]
	public virtual RailResult SetSpeakerVolume(uint volume)
	{
		return default(RailResult);
	}
}
