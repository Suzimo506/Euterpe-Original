using System;
using Cpp2ILInjected;
using rail;

[Token(Token = "0x200007A")]
[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
public delegate void RailCaptureVoiceCallback(EnumRailVoiceCaptureFormat fmt, bool is_last_package, IntPtr encoded_buffer, uint encoded_length);
