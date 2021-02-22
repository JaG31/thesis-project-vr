using UnityEngine;

namespace SimpleFileBrowser
{
	public class FileBrowserQuickLink : FileBrowserItem
	{
		#region Properties
		private string m_targetPath;
		public string TargetPath { get { return m_targetPath; } }
		#endregion

		#region Initialization Functions

		private BoxCollider boxCollider;
		private RectTransform rectTransform;
		public void SetQuickLink( Sprite icon, string name, string targetPath )
		{

			RectTransform rectTransform = GetComponent<RectTransform>();

			BoxCollider boxCollider = GetComponent<BoxCollider>();
			if (boxCollider == null)
			{
				boxCollider = gameObject.AddComponent<BoxCollider>();
			}

			boxCollider.center = new Vector3(61.5f, -16f, 0f);

			boxCollider.size = new Vector3(100, rectTransform.sizeDelta.y, 0.1f);
			SetFile( icon, name, true );

			m_targetPath = targetPath;
		}
		#endregion
	}
}