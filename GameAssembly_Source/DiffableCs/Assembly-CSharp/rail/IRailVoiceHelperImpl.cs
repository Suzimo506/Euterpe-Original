namespace rail;

public class IRailVoiceHelperImpl : RailObject, IRailVoiceHelper
{

	internal IRailVoiceHelperImpl(IntPtr cPtr) { }

	public override IRailVoiceChannel AsyncCreateVoiceChannel(CreateVoiceChannelOption options, string channel_name, string user_data, out RailResult result) { }

	public override RailResult DecodeVoice(Byte[] encoded_buffer, uint encoded_length, Byte[] pcm_buffer, uint pcm_buffer_length, out uint pcm_buffer_written) { }

	public override RailResult EnableInGameVoiceSpeaking(bool can_speaking) { }

	protected virtual void Finalize() { }

	public override RailResult GetCapturedVoiceData(Byte[] buffer, uint buffer_length, out uint encoded_bytes_written) { }

	public override uint GetPushToTalkKeyInVoiceChannel() { }

	public override EnumRailVoiceChannelSpeakerState GetSpeakerState() { }

	public override RailResult GetVoiceCaptureSpecification(RailVoiceCaptureSpecification spec) { }

	public override RailResult MuteSpeaker() { }

	public override IRailVoiceChannel OpenVoiceChannel(RailVoiceChannelID voice_channel_id, string channel_name, out RailResult result) { }

	public override RailResult ResumeSpeaker() { }

	public override RailResult SetMicroVolume(uint volume) { }

	public override RailResult SetPlayerNicknameInVoiceChannel(string nickname) { }

	public override RailResult SetPushToTalkKeyInVoiceChannel(uint push_to_talk_hot_key) { }

	public override RailResult SetSpeakerVolume(uint volume) { }

	public override RailResult SetupVoiceCapture(RailVoiceCaptureOption options) { }

	public override RailResult SetupVoiceCapture(RailVoiceCaptureOption options, RailCaptureVoiceCallback callback) { }

	public override RailResult ShowOverlayUI(bool show) { }

	public override RailResult StartVoiceCapturing(uint duration_milliseconds) { }

	public override RailResult StartVoiceCapturing(uint duration_milliseconds, bool repeat) { }

	public override RailResult StartVoiceCapturing() { }

	public override RailResult StopVoiceCapturing() { }

}

