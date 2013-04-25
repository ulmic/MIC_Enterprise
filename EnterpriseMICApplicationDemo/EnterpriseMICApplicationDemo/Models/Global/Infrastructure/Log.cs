using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace EnterpriseMICApplicationDemo.Models.Global.Infrastructure
{
	public static class Log {
		private static Logger logger = LogManager.GetCurrentClassLogger();
        public delegate void tryCode();
        public delegate void catchCode();
        public delegate void finallyCode();
        
        public static tryCode Try(Action code)
        {
            return new tryCode(code);
        }

        public static catchCode Catch(Action code)
        {
            return new catchCode(code);
        }

        public static finallyCode Finally(Action code) {
            return new finallyCode(code);
        }

        /// <summary>
        /// example: 
        /// Log.HandleExpception(
        ///        Log.Try(() => { 
        ///               //execution code
        ///            }), 
        ///        Log.Catch(() => { 
        ///              //exception handle code
        ///            }),
        ///        Log.Finally(() => {      
        ///              //finally code
        ///            }));
        /// </summary>
        /// <param name="executeCode">выполняемый код</param>
        /// <param name="exceptionHandleCode">код после отлова исключения, необязательный параметр</param>
        /// <param name="exceptionHandleCode">код выполняющийся в любом случае, необязательный параметр</param>
        public static void HandleExpception(tryCode executeCode, catchCode exceptionHandleCode = null, finallyCode finCode = null)
        {
            try {
                executeCode();
            } catch (Exception ex) {
                System.Windows.MessageBox.Show(@"Произошла неизвестная ошибка. Данные об ошибке отправлены администратору.
                                                 Если обнаружите ненормальности в работе, то, пожалуйста, перезагрузите приложение.
                                                 Всё будет хорошо.");
                exceptionHandleCode();
                logger.ErrorException("Got exception.", ex);
            } finally {
                finCode();
            }
		}
	}
}