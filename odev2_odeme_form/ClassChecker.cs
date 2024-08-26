using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace odev2_odeme_form
{
    public class ClassChecker
    {
        public bool ClassExists(string className)
        {
            // Assembly'deki tüm tipleri (class'ları) alıyoruz
            var types = Assembly.GetExecutingAssembly().GetTypes();

            // Belirli bir class var mı diye sorguluyoruz
            bool classExists = types.Any(t => t.Name == className);

            return classExists;
        }

        public Type SinifKontrolVeOlustur(string className)
        {
            // Önce sınıfın var olup olmadığını kontrol ediyoruz
            if (ClassExists(className))
            {
                // Eğer sınıf mevcutsa, o sınıfı döndür
                return Type.GetType("odev2_odeme_form." + className);
            }
            else
            {
                // Eğer sınıf mevcut değilse, dinamik olarak oluştur
                AssemblyName assemblyName = new AssemblyName("DynamicAssembly");
                AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
                ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicModule");

                // Yeni sınıfı tanımlıyoruz
                TypeBuilder typeBuilder = moduleBuilder.DefineType("odev2_odeme_form." + className, TypeAttributes.Public);

                // Örnek olarak bir property ekliyoruz
                typeBuilder.DefineField("Id", typeof(int), FieldAttributes.Public);
                typeBuilder.DefineField("className", typeof(string), FieldAttributes.Public);
                typeBuilder.DefineField("displayName", typeof(string), FieldAttributes.Public);

                // Sınıfı oluşturuyoruz
                Type dynamicClass = typeBuilder.CreateType();

                // Oluşturulan yeni sınıfı döndür
                return dynamicClass;
            }
        }


    }
}
