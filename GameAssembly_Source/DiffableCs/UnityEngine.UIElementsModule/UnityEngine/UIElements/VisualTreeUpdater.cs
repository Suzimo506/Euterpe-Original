namespace UnityEngine.UIElements;

internal sealed class VisualTreeUpdater
{
	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class UpdaterArray
	{
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x10

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 53
		}

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 53
		}

		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		public IVisualTreeUpdater get_Item(int index) { }

	}

	private UpdaterArray m_UpdaterArray; //Field offset: 0x10

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}

