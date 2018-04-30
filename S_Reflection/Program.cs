using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace S_Reflection
{
    /// <summary>
    /// 总结反射其实是个很有用的东西，可以像B超一样透视一个类
    /// GetConstructor(), GetConstructors()：返回ConstructorInfo类型，用于取得该类的构造函数的信息
    /// GetEvent(), GetEvents()：返回EventInfo类型，用于取得该类的事件的信息
    /// GetField(), GetFields()：返回FieldInfo类型，用于取得该类的字段（成员变量）的信息
    /// GetInterface(), GetInterfaces()：返回InterfaceInfo类型，用于取得该类实现的接口的信息
    /// GetMember(), GetMembers()：返回MemberInfo类型，用于取得该类的所有成员的信息
    /// GetMethod(), GetMethods()：返回MethodInfo类型，用于取得该类的方法的信息
    /// GetProperty(), GetProperties()：返回PropertyInfo类型，用于取得该类的属性的信息
    /// 
    /// 下面是获取根据类名 获取实例
    ///            Type o = Type.GetType("S_Reflection.Person");//加载类型
    ///           dynamic p = Activator.CreateInstance(o, "zb");//根据类型创建实例
    /// https://blog.csdn.net/gnd15732625435/article/details/78587483
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //Type type = Type.GetType("S_Reflection.Person");
            Type o = Type.GetType("S_Reflection.Person");//加载类型
            dynamic p = Activator.CreateInstance(o,"zb");//根据类型创建实例
          
            p.age = 10;
            Type type = typeof(Person);
            //获取方法
            MethodInfo m = type.GetMethod("GetName");
            //执行方法
            Console.WriteLine(m.Invoke(p,null));
            //获取属性--- get方法和 set方法
            PropertyInfo info1 = type.GetProperty("age");
            //获取值,也可以修改值
            Console.WriteLine(info1.GetValue(p));

            //获取的是公共变量
            FieldInfo[] fis = type.GetFields();
            foreach (FieldInfo fi in fis)
            {
                Console.WriteLine(fi.Name);
            }
           
            

            //访问私有变量 BindingFlags.Instance | BindingFlags.NonPublic 加上这两个即可
        }
    }
}
