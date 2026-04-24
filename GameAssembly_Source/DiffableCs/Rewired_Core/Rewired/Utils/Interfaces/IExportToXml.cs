namespace Rewired.Utils.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IExportToXml
{

	public bool writesOwnElementTag
	{
		 get { } //Length: 0
	}

	public bool get_writesOwnElementTag() { }

	public void WriteXml(XmlWriter writer) { }

}

