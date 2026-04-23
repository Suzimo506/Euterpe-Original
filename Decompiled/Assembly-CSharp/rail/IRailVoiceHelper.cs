using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D8")]
public interface IRailVoiceHelper
{
	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailVoiceChannel AsyncCreateVoiceChannel(CreateVoiceChannelOption options, string channel_name, string user_data, out RailResult result);

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailVoiceChannel OpenVoiceChannel(RailVoiceChannelID voice_channel_id, string channel_name, out RailResult result);

	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x0", Length = "0x0")]
	EnumRailVoiceChannelSpeakerState GetSpeakerState();

	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult MuteSpeaker();

	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ResumeSpeaker();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA1")]
	RailResult SetupVoiceCapture(RailVoiceCaptureOption options, RailCaptureVoiceCallback callback);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA2")]
	RailResult SetupVoiceCapture(RailVoiceCaptureOption options);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA3")]
	RailResult StartVoiceCapturing(uint duration_milliseconds, bool repeat);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA4")]
	RailResult StartVoiceCapturing(uint duration_milliseconds);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA5")]
	RailResult StartVoiceCapturing();

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult StopVoiceCapturing();

	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetCapturedVoiceData(byte[] buffer, uint buffer_length, out uint encoded_bytes_written);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA8")]
	RailResult DecodeVoice(byte[] encoded_buffer, uint encoded_length, byte[] pcm_buffer, uint pcm_buffer_length, out uint pcm_buffer_written);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FA9")]
	RailResult GetVoiceCaptureSpecification(RailVoiceCaptureSpecification spec);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FAA")]
	RailResult EnableInGameVoiceSpeaking(bool can_speaking);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FAB")]
	RailResult SetPlayerNicknameInVoiceChannel(string nickname);

	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetPushToTalkKeyInVoiceChannel(uint push_to_talk_hot_key);

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetPushToTalkKeyInVoiceChannel();

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ShowOverlayUI(bool show);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FAF")]
	RailResult SetMicroVolume(uint volume);

	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetSpeakerVolume(uint volume);
}
