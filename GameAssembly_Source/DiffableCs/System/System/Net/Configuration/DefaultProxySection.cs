namespace System.Net.Configuration;

public sealed class DefaultProxySection : ConfigurationSection
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 43
	}

	public DefaultProxySection() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	protected virtual void Reset(ConfigurationElement parentElement) { }

}

