using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBL3_LTUD
{
    public class Student
    {
        private static Student _Instance;
        private string id_user;
        private string Name;
        private int _Count;
        public int Count
        {
            get{
                return this._Count;
            }
            private set{}
        }
        public static Student Instance
        {
           get
           {
            if(_Instance == null)
           {
             _Instance = new Student();
           }
           return _Instance;}
           private set{}
        }
        
    }
}