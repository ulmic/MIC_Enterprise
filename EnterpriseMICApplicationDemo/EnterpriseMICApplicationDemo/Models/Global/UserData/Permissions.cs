using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EnterpriseMICApplicationDemo.Models.Global.Infrastructure;

namespace EnterpriseMICApplicationDemo.Models.Global.UserData
{
    /// <summary>
    /// This class produces a users permission 
    /// </summary>
    static public class Permissions
    {
        public enum Level : int { President, Presidium, RegionalProgramsHead, DepartamentHead, Curator, Insider };

        /// <summary>
        /// Set Function of user
        /// </summary>
        /// <param name="level">Level of user</param>
        /// <param name="func">Functions</param>
        static public void SetFunctions(Level level, ref bool[] func)
        {
            switch (level)
            {
                case Level.President:
                    func[Const.AppMainFunctions.VIEW_USER_DATA] = Const.Permission.GOT;
                    func[Const.AppMainFunctions.CREATE_NEW_DELIVERY] = Const.Permission.GOT;
                    func[Const.AppMainFunctions.ONLINE_CONFERENCE] = Const.Permission.GOT;
                    break;
                case Level.Presidium:
                    func[Const.AppMainFunctions.VIEW_USER_DATA] = Const.Permission.GOT;
                    func[Const.AppMainFunctions.CREATE_NEW_DELIVERY] = Const.Permission.GOT;
                    func[Const.AppMainFunctions.ONLINE_CONFERENCE] = Const.Permission.GOT;
                    break;
                case Level.RegionalProgramsHead:
                    func[Const.AppMainFunctions.VIEW_USER_DATA] = Const.Permission.GOT;
                    break;
            }
        }

        /// <summary>
        /// Set Level to user
        /// </summary>
        /// <param name="level">level user</param>
        /// <param name="number">identifier</param>
        static public void SetLevel(ref Level level, int number)
        {
            switch (number)
            {
                case 0: level = Level.Insider;
                    break;
                case 1: level = Level.Curator;
                    break;
                case 2: level = Level.DepartamentHead;
                    break;
                case 3: level = Level.RegionalProgramsHead;
                    break;
                case 4: level = Level.Presidium;
                    break;
                case 5: level = Level.President;
                    break;
            }
        }
    }
}
