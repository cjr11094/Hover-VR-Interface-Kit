﻿using UnityEngine;

namespace Hover.Cast.Input {

	/*================================================================================================*/
	public abstract class HovercastInput : MonoBehaviour, IInput {

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public abstract void UpdateInput();

		/*--------------------------------------------------------------------------------------------*/
		public abstract IInputMenu GetMenu(bool pIsLeft);

	}

}
