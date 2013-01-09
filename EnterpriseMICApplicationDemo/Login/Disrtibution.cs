using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo {
  static public class Distribution {
    public enum Level { President, Presidium, RegionalProgramsHead, DepartamentHead, Curator, Insider };

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