using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _32Designs.Designs.单例模式
{
    public class code
    {
        public static LogClass log;
        public static readonly object lockObj;

        // 饿汉式单例 利用静态构造函数来实现
        static code()
        {
            log = new LogClass();
        }

        // 懒汉式单例
        public static LogClass LogInstance
        {
            get
            {
                if (log == null)
                {
                    lock (lockObj)
                    {
                        if (log == null)
                        {
                            log = new LogClass();
                        }
                    }
                }
                return log;
            }
        }

        // 内部类静态构造实现
        public static LogClass LogInstance2
        {
            get
            {
                return Inside.obj;
            }
        }

        public class Inside
        {
            static Inside() { }
            internal static LogClass obj = new LogClass();
        }
    }

    public class LogClass
    {
        //记录日志xxxxxx
    }
}