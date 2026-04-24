using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003FB")]
internal delegate object ImporterFunc(object input);
[Token(Token = "0x20003FC")]
public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
