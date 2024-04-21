using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using asdfg.StaticApp;

namespace asdfg.StaticApp
{
    public class ClassData
    {
        
        public static List<ClassStatic> classStatics { get; set; }
        public static List<ClassUniver> classUni { get; set; }
        public static List<ClassStatic> GetData()
        {
            classStatics = new List<ClassStatic>();
            StreamReader reader = new StreamReader(@"base.ioss");
            var SelectData = reader.ReadToEnd();
            
            foreach (var Index in SelectData.Split(':'))
            {
                
                    if (Index != "" && Index.Split(';')[3] == "user")
                    {
                        
                        classStatics.Add(new ClassStatic(Index.Split(';')[0], Index.Split(';')[1], Index.Split(';')[2], Index.Split(';')[3]));
                }   
            }
            return classStatics;
        }

        public static List<ClassUniver> GetDataUni()
        {
            classUni = new List<ClassUniver>();
            StreamReader reader = new StreamReader(@"base.ioss");
            var SelectData = reader.ReadToEnd();
          
            foreach (var Index in SelectData.Split(':'))
            {

                if (Index != "" && Index.Split(';')[3] == "univer")
                {
                    classUni.Add(new ClassUniver(Index.Split(';')[0], Index.Split(';')[1], Index.Split(';')[2], Index.Split(';')[3]));
                }
            }
            return classUni;
        }

    }
}
