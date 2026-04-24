namespace rail;

public interface IRailVoiceHelper
{

	public IRailVoiceChannel AsyncCreateVoiceChannel(CreateVoiceChannelOption options, string channel_name, string user_data, out RailResult result) { }

	public RailResult DecodeVoice(Byte[] encoded_buffer, uint encoded_length, Byte[] pcm_buffer, uint pcm_buffer_length, out uint pcm_buffer_written) { }

	public RailResult EnableInGameVoiceSpeaking(bool can_speaking) { }

	public RailResult GetCapturedVoiceData(Byte[] buffer, uint buffer_length, out uint encoded_bytes_written) { }

	public uint GetPushToTalkKeyInVoiceChannel() { }

	public EnumRailVoiceChannelSpeakerState GetSpeakerState() { }

	public RailResult GetVoiceCaptureSpecification(RailVoiceCaptureSpecification spec) { }

	public RailResult MuteSpeaker() { }

	public IRailVoiceChannel OpenVoiceChannel(RailVoiceChannelID voice_channel_id, string channel_name, out RailResult result) { }

	public RailResult ResumeSpeaker() { }

	public RailResult SetMicroVolume(uint volume) { }

	public RailResult SetPlayerNicknameInVoiceChannel(string nickname) { }

	public RailResult SetPushToTalkKeyInVoiceChannel(uint push_to_talk_hot_key) { }

	public RailResult SetSpeakerVolume(uint volume) { }

	public RailResult SetupVoiceCapture(RailVoiceCaptureOption options) { }

	public RailResult SetupVoiceCapture(RailVoiceCaptureOption options, RailCaptureVoiceCallback callback) { }

	public RailResult ShowOverlayUI(bool show) { }

	public RailResult StartVoiceCapturing(uint duration_milliseconds) { }

	public RailResult StartVoiceCapturing(uint duration_milliseconds, bool repeat) { }

	public RailResult StartVoiceCapturing() { }

	public RailResult StopVoiceCapturing() { }

}

