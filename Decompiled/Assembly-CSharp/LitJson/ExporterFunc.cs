using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F9")]
internal delegate void ExporterFunc(object obj, JsonWriter writer);
[Token(Token = "0x20003FA")]
public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
