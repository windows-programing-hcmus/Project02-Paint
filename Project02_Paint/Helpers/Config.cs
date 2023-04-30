using MyContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{

    public class Config
    {
        
        public static Dictionary<string, IDrawer> painterPrototypes = new Dictionary<string, IDrawer>();
        public static Dictionary<string, IShapeAbility> shapesPrototypes = new Dictionary<string, IShapeAbility>();

        public static void firstConfig()
        {

            var exeFolder = AppDomain.CurrentDomain.BaseDirectory;
            var folderInfo = new DirectoryInfo(exeFolder);
            var dllFiles = folderInfo.GetFiles("*.dll");

            foreach (var dll in dllFiles)
            {
                Assembly assembly = Assembly.LoadFrom(dll.FullName);

                Type[] types = assembly.GetTypes();

              
                IShapeAbility? entity = null;
                IDrawer? business = null;

                foreach (Type type in types)
                {
                    if (type.IsClass)
                    {
                        if (typeof(IShapeAbility).IsAssignableFrom(type))
                        {
                            entity = (Activator.CreateInstance(type) as IShapeAbility)!;
                        }

                        if (typeof(IDrawer).IsAssignableFrom(type))
                        {
                            business = (Activator.CreateInstance(type) as IDrawer)!;
                        }
                    }
                }

           
                if (entity != null)
                {
                    shapesPrototypes.Add(entity!.Name, entity);
                    painterPrototypes.Add(entity!.Name, business!);
                }
            }

        }
    }
}
