using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// This class produces a functional separation
	/// </summary>
	static public class Distribution {
		public static Member Member {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}
	
		public enum Level { President, Presidium, RegionalProgramsHead, DepartamentHead, Curator, Insider };

		/// <summary>
		/// Set Function of user
		/// </summary>
		/// <param name="level">Level of user</param>
		/// <param name="func">Functions</param>
		static public void SetFunctions(Level level, ref bool[] func) {
			if (level == Level.President) {
				func[Const.VIEW_USER_DATA] = Const.GOT;
				func[Const.CREATE_NEW_DELIVERY] = Const.GOT;
				func[Const.ONLINE_CONFERENCE] = Const.GOT;
			}
			if (level == Level.Presidium) {
				func[Const.VIEW_USER_DATA] = Const.GOT;
				func[Const.CREATE_NEW_DELIVERY] = Const.GOT;
				func[Const.ONLINE_CONFERENCE] = Const.GOT;
			}
			if (level == Level.RegionalProgramsHead) {
				func[Const.VIEW_USER_DATA] = Const.GOT;
			}
		}

		/// <summary>
		/// Set Level to user
		/// </summary>
		/// <param name="level">level user</param>
		/// <param name="number">identifier</param>
		static public void SetLevel(ref Level level, int number) {
			if (number == 0) {
				level = Level.Insider;
				return;
			}
			if (number == 1) {
				level = Level.Curator;
				return;
			}
			if (number == 2) {
				level = Level.DepartamentHead;
				return;
			}
			if (number == 3) {
				level = Level.RegionalProgramsHead;
				return;
			}
			if (number == 4) {
				level = Level.Presidium;
				return;
			}
			if (number == 5) {
				level = Level.President;
			}
		}
	}
}