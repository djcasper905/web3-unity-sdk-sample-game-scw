using Microsoft.Maps.Unity;
using UnityEngine;

namespace MoralisUnity.Samples.SimCityWeb3.View.UI
{
	/// <summary>
	/// Replace with comments...
	/// </summary>
	public class MapUI : MonoBehaviour
	{
		// Properties -------------------------------------
		
		public MapPinLayer PropertyMapPinLayer { get { return _propertyMapPinLayer; }}
		
		public MapPropertyUISpawnPoint MapPropertyUISpawnPoint { get { return _mapPropertyUISpawnPoint; }}
		
		public MapRenderer MapRenderer { get { return _mapRenderer; }}

		
		// Fields -----------------------------------------
		[SerializeField]
		private MapRenderer _mapRenderer = null;

		[SerializeField]
		private MapPinLayer _propertyMapPinLayer = null;
		
		[SerializeField]
		private MapPropertyUISpawnPoint _mapPropertyUISpawnPoint = null;

		[SerializeField]
		private ZoomButtonHandler _zoomButtonHandler = null;
		
		// Unity Methods ----------------------------------
		protected void Start()
		{
			
		}

		// General Methods --------------------------------
		public void ZoomIn()
		{
			
			_zoomButtonHandler.OnZoomIn();
		}
		
		
		public void ZoomOut()
		{
			_zoomButtonHandler.OnZoomOut();
		}
		
		// Event Handlers ---------------------------------
	}
}
