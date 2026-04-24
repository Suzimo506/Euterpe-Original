namespace Rewired.Utils.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IExportToJson
{

	public void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, Object> appendValueDelegate) { }

}

